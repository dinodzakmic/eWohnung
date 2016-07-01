using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eWohnung.Model
{
    public class StanTest
    {
        public string SifraStana { get; set; }
        public string BrojStanaUZgradi { get; set; }
        public string UlicaBroj { get; set; }
        public string UkupnaKvadratura { get; set; }
        public string Sprat { get; set; }
        public string BrojSoba { get; set; }
        public string XKoordinata { get; set; }
        public string YKoordinata { get; set; }
        public string ViseEtazni { get; set; }
        public string UkupnoSpratova { get; set; }
        public bool Potkrovlje { get; set; }
        public bool Kablovska { get; set; }
        public bool Internet { get; set; }
        public string Namjesten { get; set; }
        public string MogucnostPrijaveOsoba { get; set; }
        public bool Lift { get; set; }
        public User Prezentirao { get; set; }
        public User Predao { get; set; }
        public bool Renoviran { get; set; }
        public bool OstavaSpajz { get; set; }
        public bool SupaZaBiciklo { get; set; }

        public List<StanTest> ListaStanova { get; set; }

        public StanTest(string sifraStana, string brojStanaUZgradi, string ulicaBroj, string ukupnaKvadratura, string sprat, string brojSoba, string xKoordinata, string yKoordinata, string viseEtazni, string ukupnoSpratova, bool potkrovlje, bool kablovska, bool internet, string namjesten, string mogucnostPrijaveOsoba, bool lift, User prezentirao, User predao, bool renoviran, bool ostavaSpajz, bool supaZaBiciklo)
        {
            SifraStana = sifraStana;
            BrojStanaUZgradi = brojStanaUZgradi;
            UlicaBroj = ulicaBroj;
            UkupnaKvadratura = ukupnaKvadratura;
            Sprat = sprat;
            BrojSoba = brojSoba;
            XKoordinata = xKoordinata;
            YKoordinata = yKoordinata;
            ViseEtazni = viseEtazni;
            UkupnoSpratova = ukupnoSpratova;
            Potkrovlje = potkrovlje;
            Kablovska = kablovska;
            Internet = internet;
            Namjesten = namjesten;
            MogucnostPrijaveOsoba = mogucnostPrijaveOsoba;
            Lift = lift;
            Prezentirao = prezentirao;
            Predao = predao;
            Renoviran = renoviran;
            OstavaSpajz = ostavaSpajz;
            SupaZaBiciklo = supaZaBiciklo;
        }

        public StanTest()
        {
            
        }
    }
}

   