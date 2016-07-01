using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using eWohnung.Model;
using Newtonsoft.Json;

namespace eWohnung.ViewModel
{
    public class StanViewModel : MainViewModel
    {
        private ObservableCollection<StanTest> _listaStanova;

        public ObservableCollection<StanTest> ListaStanova
        {
            get { return _listaStanova; }
            set
            {
                _listaStanova = value;
                RaisePropertyChanged();
            }
        }
        public StanTest Stan { get; set; }
        
        public StanViewModel()
        {
        }

        #region Dodavanje stanova
        public async Task DodajStanove()
        {
            try
            {
                IsLoading = true;
                IsConnected = true;
                string url = @"http://81.169.153.223:8080/eWohnung-service/service/stanovi/";
                var json = await new HttpClient().GetStringAsync(url);
                ListaStanova = JsonConvert.DeserializeObject<ObservableCollection<StanTest>>(json);
            }
            catch (WebException we)
            {
                if (we.Status == WebExceptionStatus.ConnectFailure)
                {
                    IsLoading = false;
                    IsConnected = false;                   
                }
            }
            

        }
        #endregion
    }
}
