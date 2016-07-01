using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using eWohnung.Model;
using GalaSoft.MvvmLight;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
        #region IsConnected
        private bool _isConnected;

        public bool IsConnected
        {
            get { return _isConnected; }
            set
            {
                _isConnected = value;
                RaisePropertyChanged();
            }
        }
        #endregion
        #region QuickAction
        public QuickAccess QuickAction { get; set; }
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

            QuickAction = quickAction;
            await ExecuteNavigation(new ListaTest(), App.Locator.Stan.DodajStanove());
            //await App.Locator.Stan.DodajStanove();
        }
        private async Task GoToMap(QuickAccess quickAction)
        {
            if (!IsEnabled) return;

            QuickAction = quickAction;
            await ExecuteNavigation(new MapaTest(), null);

        }
        private async Task GoToSearch(QuickAccess quickAction)
        {
            if (!IsEnabled) return;

            QuickAction = quickAction;
            await ExecuteNavigation(new SearchPage(), null);
        }
        private async Task GoToSettings(QuickAccess quickAction)
        {
            if (!IsEnabled) return;

            QuickAction = quickAction;
            await ExecuteNavigation(new SettingsPage(), null);
        }

        private async Task ExecuteNavigation(Page page, Task actionTask)
        {
            IsEnabled = false;
            await QuickAction.FadeTo(0.5, 500, Easing.BounceIn);
            IsLoading = true;
            await Task.Delay(TimeSpan.FromMilliseconds(100));

            if (actionTask != null)
                await actionTask;

            CancellationToken canToken = new CancellationToken();
            await App.NavPage.Navigation.PushAsync(page).ContinueWith(async t =>
            {
                if (t.IsCompleted)
                {
                    await Task.Delay(TimeSpan.FromMilliseconds(100), canToken);
                    IsLoading = false;
                    QuickAction.Opacity = 1;
                    IsEnabled = true;
                }
            }, canToken);
        }  
    }
}