﻿using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using eWohnung.ViewModel;
using Newtonsoft.Json.Linq;
using Xamarin.Forms;

namespace eWohnung
{
    public partial class App : Application
    {
        public static ViewModelLocator Locator;
        public static NavigationPage NavPage;

        public App()
        {
            InitializeComponent();           

            NavPage = new NavigationPage(new Login());
            Locator = new ViewModelLocator();
            MainPage = NavPage;
            
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
