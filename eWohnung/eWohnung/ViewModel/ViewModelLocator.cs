using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;

namespace eWohnung.ViewModel
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<StanViewModel>();
            SimpleIoc.Default.Register<LoginViewModel>();
        }

        public MainViewModel Main => ServiceLocator.Current.GetInstance<MainViewModel>();
        public StanViewModel Stan => ServiceLocator.Current.GetInstance<StanViewModel>();
        public LoginViewModel Login => ServiceLocator.Current.GetInstance<LoginViewModel>();

        public static void Cleanup()
        {
            
        }
    }
}