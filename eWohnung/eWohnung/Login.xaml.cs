using System;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using eWohnung.Model;
using Newtonsoft.Json.Linq;
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
            var user = new User(UsernameEntry.Text, PasswordEntry.Text);
            await App.Locator.Login.LoginTask(user);
        }

        protected override void OnDisappearing()
        {
            Navigation.RemovePage(this);
        }
    }
}
