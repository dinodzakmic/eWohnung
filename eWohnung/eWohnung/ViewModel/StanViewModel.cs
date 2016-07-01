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
        public List<StanTest> ListaStanova { get; set; }
        public StanTest Stan { get; set; }
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

        public StanViewModel()
        {
        }

        #region Dodavanje stanova
        public async Task DodajStanove()
        {
            try
            {
                IsConnected = true;
                string url = @"http://81.169.153.223:8080/eWohnung-service/service/stanovi/";
                var json = await new HttpClient().GetStringAsync(url);
                ListaStanova = JsonConvert.DeserializeObject<List<StanTest>>(json);
            }
            catch (WebException we)
            {
                if (we.Status == WebExceptionStatus.ConnectFailure)
                {
                    IsConnected = false;                   
                }
            }
            

        }
        #endregion
    }
}
