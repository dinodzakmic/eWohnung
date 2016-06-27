using eWohnung.ViewModel;
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
