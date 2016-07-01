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

        private UserTest UserJson { get; set; }

        public LoginViewModel()
        {
            LoginCommand = new Command<User>(async user => await LoginTask(user));
        }

        public async Task LoginTask(User user)
        {
            try
            {
                string url = @"http://81.169.153.223:8080/eWohnung-service/service/login/username/test/password/test";
                var json = await new HttpClient().GetStringAsync(url);

                UserJson = JsonConvert.DeserializeObject<UserTest>(json);

                IsLoading = true;
                await Task.Delay(TimeSpan.FromSeconds(1));

                if (user.GetUsername() != null && user.GetUsername().Equals(UserJson.Username) && user.GetPassword().Equals(UserJson.Password))
                {
                    IsLoading = false;
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
                if(we.Status == WebExceptionStatus.ConnectFailure)
                    await App.NavPage.CurrentPage.DisplayAlert("Greska", "Provjerite konekciju!", "OK");
            }
           

        }
    }
}
