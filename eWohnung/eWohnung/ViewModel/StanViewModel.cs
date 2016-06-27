using System.Collections.Generic;
using eWohnung.Model;

namespace eWohnung.ViewModel
{
    public class StanViewModel : MainViewModel
    {
        public List<Stanovi> ListaStanova { get; set; }

        public StanViewModel()
        {
            DodajStanove();
        }

        #region Dodavanje stanova
        private void DodajStanove()
        {
          ListaStanova = new List<Stanovi>
            {
                new Stanovi
                {
                    Photo = "stan_slika_test2.jpg",
                    Name = "Dvosoban stan",
                    Description = "Lijep pravo"
                },
                new Stanovi
                {
                    Photo = "stan_slika_test2.jpg",
                    Name = "Apartman",
                    Description = "Kratak period"
                },
                new Stanovi
                {
                    Photo = "stan_slika_test2.jpg",
                    Name = "Garsonjera",
                    Description = "Za samce"
                },
                new Stanovi
                {
                    Photo = "stan_slika_test2.jpg",
                    Name = "Poslovni prostor",
                    Description = "Atraktivna lokacija"
                },
                new Stanovi
                {
                    Photo = "stan_slika_test2.jpg",
                    Name = "Dvosoban stan",
                    Description = "Lijep pravo"
                },
                new Stanovi
                {
                    Photo = "stan_slika_test2.jpg",
                    Name = "Apartman",
                    Description = "Kratak period"
                },
                new Stanovi
                {
                    Photo = "stan_slika_test2.jpg",
                    Name = "Garsonjera",
                    Description = "Za samce"
                },
                new Stanovi
                {
                    Photo = "stan_slika_test2.jpg",
                    Name = "Poslovni prostor",
                    Description = "Atraktivna lokacija"
                },
                new Stanovi
                {
                    Photo = "stan_slika_test2.jpg",
                    Name = "Dvosoban stan",
                    Description = "Lijep pravo"
                },
                new Stanovi
                {
                    Photo = "stan_slika_test2.jpg",
                    Name = "Apartman",
                    Description = "Kratak period"
                },
                new Stanovi
                {
                    Photo = "stan_slika_test2.jpg",
                    Name = "Garsonjera",
                    Description = "Za samce"
                },
                new Stanovi
                {
                    Photo = "stan_slika_test2.jpg",
                    Name = "Poslovni prostor",
                    Description = "Atraktivna lokacija"
                },
                new Stanovi
                {
                    Photo = "stan_slika_test2.jpg",
                    Name = "Dvosoban stan",
                    Description = "Lijep pravo"
                },
                new Stanovi
                {
                    Photo = "stan_slika_test2.jpg",
                    Name = "Apartman",
                    Description = "Kratak period"
                },
                new Stanovi
                {
                    Photo = "stan_slika_test2.jpg",
                    Name = "Garsonjera",
                    Description = "Za samce"
                },
                new Stanovi
                {
                    Photo = "stan_slika_test2.jpg",
                    Name = "Poslovni prostor",
                    Description = "Atraktivna lokacija"
                },
                new Stanovi
                {
                    Photo = "stan_slika_test2.jpg",
                    Name = "Poslovni prostor",
                    Description = "Atraktivna lokacija"
                },
                new Stanovi
                {
                    Photo = "stan_slika_test2.jpg",
                    Name = "Dvosoban stan",
                    Description = "Lijep pravo"
                },
                new Stanovi
                {
                    Photo = "stan_slika_test2.jpg",
                    Name = "Apartman",
                    Description = "Kratak period"
                },
                new Stanovi
                {
                    Photo = "stan_slika_test2.jpg",
                    Name = "Garsonjera",
                    Description = "Za samce"
                },
                new Stanovi
                {
                    Photo = "stan_slika_test2.jpg",
                    Name = "Poslovni prostor",
                    Description = "Atraktivna lokacija"
                },
                new Stanovi
                {
                    Photo = "stan_slika_test2.jpg",
                    Name = "Poslovni prostor",
                    Description = "Atraktivna lokacija"
                },
                new Stanovi
                {
                    Photo = "stan_slika_test2.jpg",
                    Name = "Dvosoban stan",
                    Description = "Lijep pravo"
                },
                new Stanovi
                {
                    Photo = "stan_slika_test2.jpg",
                    Name = "Apartman",
                    Description = "Kratak period"
                },
                new Stanovi
                {
                    Photo = "stan_slika_test2.jpg",
                    Name = "Garsonjera",
                    Description = "Za samce"
                },
                new Stanovi
                {
                    Photo = "stan_slika_test2.jpg",
                    Name = "Poslovni prostor",
                    Description = "Atraktivna lokacija"
                }

            };  
        }
        #endregion
    }
}
