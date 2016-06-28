using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace eWohnung
{
    
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }   
    }
}
