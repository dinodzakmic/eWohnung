using System;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace eWohnung
{
    public partial class Login : ContentPage
    {
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
            ActivityIndicator.IsRunning = true;
            ButtonLogin.IsVisible = false;
            await Task.Delay(TimeSpan.FromSeconds(2));

            if (username != null && (username.Equals("a") && password.Equals("a")))
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
