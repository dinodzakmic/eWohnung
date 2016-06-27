using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace eWohnung
{
    
    public partial class HomePage
    {
        public HomePage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        protected override void OnAppearing()
        {
            Opacity = 1;
        }      
    }
}
