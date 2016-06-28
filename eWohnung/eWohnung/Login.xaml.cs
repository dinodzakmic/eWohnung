using System;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Xamarin.Forms;

namespace eWohnung
{
    public partial class Login : ContentPage
    {
        public string UsernameJson;
        public string PasswordJson;
        public Login()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            await LoginTask(UsernameEntry.Text, PasswordEntry.Text);
        }

        public async Task LoginTask(string username, string password)
        {
            string url = @"http://81.169.153.223:8080/eWohnung-service/service/login/username/test/password/test";
            var json = Task.Run(async () => await new HttpClient().GetStringAsync(url)).Result;

            Debug.WriteLine(json);
            var test = JObject.Parse(json);
            UsernameJson = (string) test["username"];
            PasswordJson = (string) test["password"];

            ActivityIndicator.IsRunning = true;
            ButtonLogin.IsVisible = false;
            await Task.Delay(TimeSpan.FromSeconds(2));

            if (username != null && username.Equals(UsernameJson) && password.Equals(PasswordJson))
            {
                ActivityIndicator.IsRunning = false;
                await Navigation.PushAsync(new HomePage(), true);
                //Application.Current.MainPage = new ListaTest();
                ButtonLogin.IsVisible = true;
            }
            else
            {
                ActivityIndicator.IsRunning = false;
                await DisplayAlert("Error", "Username or password incorrect!", "OK");
                ButtonLogin.IsVisible = true;
            }


        }

        protected override void OnDisappearing()
        {
            Navigation.RemovePage(this);
        }
    }
}
