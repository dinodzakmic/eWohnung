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
        #region IsEnabled

        private bool _isEnabled = true;

        public bool IsEnabled
        {
            get { return _isEnabled; }
            set
            {
                _isEnabled = value;
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
            GoToListCommand = new Command<QuickAccess>(async quickAction => await GoToList(quickAction));
            GoToMapCommand = new Command<QuickAccess>(async quickAction => await GoToMap(quickAction));
            GoToSearchCommand = new Command<QuickAccess>(async quickAction => await GoToSearch(quickAction));
            GoToSettingsCommand = new Command<QuickAccess>(async quickAccess => await GoToSettings(quickAccess));
        }
        private async Task GoToList(QuickAccess quickAction)
        {
            if (!IsEnabled) return;

            IsEnabled = false;
            await quickAction.FadeTo(0.5, 500, Easing.BounceIn);
            IsLoading = true;
            await Task.Delay(TimeSpan.FromSeconds(1));
            await App.NavPage.Navigation.PushAsync(new ListaTest());
            IsLoading = false;
            quickAction.Opacity = 1;
            IsEnabled = true;
        }
        private async Task GoToMap(QuickAccess quickAction)
        {
            if (!IsEnabled) return;

            IsEnabled = false;
            await quickAction.FadeTo(0.5, 500, Easing.BounceIn);
            IsLoading = true;
            await Task.Delay(TimeSpan.FromSeconds(1));
            await App.NavPage.Navigation.PushAsync(new MapaTest());
            IsLoading = false;
            quickAction.Opacity = 1;
            IsEnabled = true;
        }
        private async Task GoToSearch(QuickAccess quickAction)
        {
            if (!IsEnabled) return;

            IsEnabled = false;
            await quickAction.FadeTo(0.5, 500, Easing.BounceIn);
            //IsLoading = true;
            await Task.Delay(TimeSpan.FromSeconds(1));
            //IsLoading = false;
            quickAction.Opacity = 1;
            IsEnabled = true;
            await App.NavPage.DisplayAlert("ToDo", "This needs to be implemented", "OK");
        }
        private async Task GoToSettings(QuickAccess quickAction)
        {
            if (!IsEnabled) return;

            IsEnabled = false;
            await quickAction.FadeTo(0.5, 500, Easing.BounceIn);
            //IsLoading = true;
            await Task.Delay(TimeSpan.FromSeconds(1));
            //IsLoading = false;
            quickAction.Opacity = 1;
            IsEnabled = true;
            await App.NavPage.DisplayAlert("ToDo", "This needs to be implemented", "OK");
        }
    }
}