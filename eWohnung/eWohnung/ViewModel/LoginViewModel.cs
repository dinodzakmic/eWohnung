using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Input;
using eWohnung.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Xamarin.Forms;

namespace eWohnung.ViewModel
{
    public class LoginViewModel : MainViewModel
    {
        #region Commands        
        public ICommand LoginCommand { get; set; }
        #endregion
        #region UserTest
        public int Id;
        public string NameJson;
        public string SurnameJson;
        public string UsernameJson;
        public string PasswordJson;
        public List<RegioniDjelovanja> RegioniDjelovanjaJson;
        public string Email;
        #endregion
        #region

        private string _username;

        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
                RaisePropertyChanged();
            }
        }

        private string _password;

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                RaisePropertyChanged();
            }
        }

        private User _user;
        public User User
        {
            get { return _user; }
            set
            {
                _user = value;
                RaisePropertyChanged();
            }
        }
        #endregion
        private UserTest UserJson { get; set; }

        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await LoginTask());
        }

        public async Task LoginTask()
        {
            try
            {
                if (Username.Equals("") && !Password.Equals(""))
                {
                    await App.NavPage.DisplayAlert("Error", "Please enter your username!", "OK");
                    return;
                }


                if (!Username.Equals("") && Password.Equals(""))
                {
                    await App.NavPage.DisplayAlert("Error", "Please enter your password!", "OK");
                    return;
                }

                if (Username.Equals("") && Password.Equals(""))
                {
                    await App.NavPage.DisplayAlert("Error", "Please enter your username and password!", "OK");
                    return;
                }

                IsLoading = true;
                User = new User(Username, Password);

                string url = @"http://81.169.153.223:8080/eWohnung-service/service/login/username/test/password/test";
                var json = await new HttpClient().GetStringAsync(url);

                UserJson = JsonConvert.DeserializeObject<UserTest>(json);
                
                await Task.Delay(TimeSpan.FromSeconds(1));

                if (User.GetUsername() != null && User.GetUsername().Equals(UserJson.Username) && User.GetPassword().Equals(UserJson.Password))
                {
                    IsLoading = false;
                    Password = null;
                    await App.NavPage.Navigation.PushAsync(new HomePage());
                }
                else
                {
                    IsLoading = false;
                    await App.NavPage.CurrentPage.DisplayAlert("Error", "Username or password incorrect!", "OK");
                }
            }
            catch (WebException we)
            {
                if (we.Status == WebExceptionStatus.ConnectFailure)
                {
                    IsLoading = false;
                    await App.NavPage.CurrentPage.DisplayAlert("Error", "Check your connection!", "OK");
                }
            }
           

        }
    }
}
