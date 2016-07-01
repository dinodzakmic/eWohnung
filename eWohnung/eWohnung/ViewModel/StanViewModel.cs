using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Threading.Tasks;
using eWohnung.Model;
using Newtonsoft.Json;

namespace eWohnung.ViewModel
{
    public class StanViewModel : MainViewModel
    {
        public List<StanTest> ListaStanova { get; set; }

        public StanViewModel()
        {
        }

        #region Dodavanje stanova
        public async Task DodajStanove()
        {
            string url = @"http://81.169.153.223:8080/eWohnung-service/service/stanovi/";
            var json = await new HttpClient().GetStringAsync(url);
            ListaStanova = JsonConvert.DeserializeObject<List<StanTest>>(json);

            #region comment

            //ListaStanova = new List<Stanovi>
            //  {
            //      new Stanovi
            //      {
            //          Photo = "stan_slika_test2.jpg",
            //          Name = "Dvosoban stan",
            //          Description = "Lijep pravo"
            //      },
            //      new Stanovi
            //      {
            //          Photo = "stan_slika_test2.jpg",
            //          Name = "Apartman",
            //          Description = "Kratak period"
            //      },
            //      new Stanovi
            //      {
            //          Photo = "stan_slika_test2.jpg",
            //          Name = "Garsonjera",
            //          Description = "Za samce"
            //      },
            //      new Stanovi
            //      {
            //          Photo = "stan_slika_test2.jpg",
            //          Name = "Poslovni prostor",
            //          Description = "Atraktivna lokacija"
            //      },
            //      new Stanovi
            //      {
            //          Photo = "stan_slika_test2.jpg",
            //          Name = "Dvosoban stan",
            //          Description = "Lijep pravo"
            //      },
            //      new Stanovi
            //      {
            //          Photo = "stan_slika_test2.jpg",
            //          Name = "Apartman",
            //          Description = "Kratak period"
            //      },
            //      new Stanovi
            //      {
            //          Photo = "stan_slika_test2.jpg",
            //          Name = "Garsonjera",
            //          Description = "Za samce"
            //      },
            //      new Stanovi
            //      {
            //          Photo = "stan_slika_test2.jpg",
            //          Name = "Poslovni prostor",
            //          Description = "Atraktivna lokacija"
            //      },
            //      new Stanovi
            //      {
            //          Photo = "stan_slika_test2.jpg",
            //          Name = "Dvosoban stan",
            //          Description = "Lijep pravo"
            //      },
            //      new Stanovi
            //      {
            //          Photo = "stan_slika_test2.jpg",
            //          Name = "Apartman",
            //          Description = "Kratak period"
            //      },
            //      new Stanovi
            //      {
            //          Photo = "stan_slika_test2.jpg",
            //          Name = "Garsonjera",
            //          Description = "Za samce"
            //      },
            //      new Stanovi
            //      {
            //          Photo = "stan_slika_test2.jpg",
            //          Name = "Poslovni prostor",
            //          Description = "Atraktivna lokacija"
            //      },
            //      new Stanovi
            //      {
            //          Photo = "stan_slika_test2.jpg",
            //          Name = "Dvosoban stan",
            //          Description = "Lijep pravo"
            //      },
            //      new Stanovi
            //      {
            //          Photo = "stan_slika_test2.jpg",
            //          Name = "Apartman",
            //          Description = "Kratak period"
            //      },
            //      new Stanovi
            //      {
            //          Photo = "stan_slika_test2.jpg",
            //          Name = "Garsonjera",
            //          Description = "Za samce"
            //      },
            //      new Stanovi
            //      {
            //          Photo = "stan_slika_test2.jpg",
            //          Name = "Poslovni prostor",
            //          Description = "Atraktivna lokacija"
            //      },
            //      new Stanovi
            //      {
            //          Photo = "stan_slika_test2.jpg",
            //          Name = "Poslovni prostor",
            //          Description = "Atraktivna lokacija"
            //      },
            //      new Stanovi
            //      {
            //          Photo = "stan_slika_test2.jpg",
            //          Name = "Dvosoban stan",
            //          Description = "Lijep pravo"
            //      },
            //      new Stanovi
            //      {
            //          Photo = "stan_slika_test2.jpg",
            //          Name = "Apartman",
            //          Description = "Kratak period"
            //      },
            //      new Stanovi
            //      {
            //          Photo = "stan_slika_test2.jpg",
            //          Name = "Garsonjera",
            //          Description = "Za samce"
            //      },
            //      new Stanovi
            //      {
            //          Photo = "stan_slika_test2.jpg",
            //          Name = "Poslovni prostor",
            //          Description = "Atraktivna lokacija"
            //      },
            //      new Stanovi
            //      {
            //          Photo = "stan_slika_test2.jpg",
            //          Name = "Poslovni prostor",
            //          Description = "Atraktivna lokacija"
            //      },
            //      new Stanovi
            //      {
            //          Photo = "stan_slika_test2.jpg",
            //          Name = "Dvosoban stan",
            //          Description = "Lijep pravo"
            //      },
            //      new Stanovi
            //      {
            //          Photo = "stan_slika_test2.jpg",
            //          Name = "Apartman",
            //          Description = "Kratak period"
            //      },
            //      new Stanovi
            //      {
            //          Photo = "stan_slika_test2.jpg",
            //          Name = "Garsonjera",
            //          Description = "Za samce"
            //      },
            //      new Stanovi
            //      {
            //          Photo = "stan_slika_test2.jpg",
            //          Name = "Poslovni prostor",
            //          Description = "Atraktivna lokacija"
            //      }

            #endregion

        }
        #endregion
    }
}
