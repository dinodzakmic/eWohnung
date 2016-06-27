using System;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using Xamarin.Forms;

namespace eWohnung.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        #region IsLoading

        private bool _isLoading;

        public bool IsLoading
        {
            get { return _isLoading;}
            set
            {
                _isLoading = value;
                RaisePropertyChanged();
            }
        }
        #endregion

        #region Commands

        public ICommand GoToListCommand { get; set; }
        public ICommand GoToMapCommand { get; set; }
        public ICommand GoToSearchCommand { get; set; }
        public ICommand GoToSettingsCommand { get; set; }


        #endregion

        public MainViewModel()
        {
            GoToListCommand = new Command(async () => await GoToList());
            GoToMapCommand = new Command(async () => await GoToMap());
            GoToSearchCommand = new Command(async () => await GoToSearch());
            GoToSettingsCommand = new Command(async () => await GoToSettings());
        }
        private async Task GoToList()
        {
            await App.NavPage.CurrentPage.FadeTo(0.5, 500, Easing.BounceIn);
            IsLoading = true;
            await Task.Delay(TimeSpan.FromSeconds(1));
            await App.NavPage.Navigation.PushAsync(new ListaTest());
            IsLoading = false;
        }
        private async Task GoToMap()
        {
            await App.NavPage.CurrentPage.FadeTo(0.5, 500, Easing.BounceIn);
            IsLoading = true;
            await Task.Delay(TimeSpan.FromSeconds(1));
            await App.NavPage.Navigation.PushAsync(new MapaTest());
            IsLoading = false;
        }
        private async Task GoToSearch()
        {
            await App.NavPage.DisplayAlert("ToDo", "This needs to be implemented", "OK");
        }
        private async Task GoToSettings()
        {
            await App.NavPage.DisplayAlert("ToDo", "This needs to be implemented", "OK");
        }

       

       

        
    }
}