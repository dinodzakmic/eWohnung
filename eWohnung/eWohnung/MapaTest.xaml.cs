using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace eWohnung
{
    public partial class MapaTest : ContentPage
    {
        public MapaTest()
        {
            InitializeComponent();
            var map = new Map(MapSpan.FromCenterAndRadius(
                new Position(48.137366, 11.575830),
                Distance.FromKilometers(1)));

            map.Pins.Add(new Pin()
            {
                Address = "Adresa",
                Label = "Grad",
                Position = new Position(48.136994, 11.574918)
            });

            map.Pins.Add(new Pin()
            {
                Address = "Adresa",
                Label = "Grad",
                Position = new Position(48.137388, 11.577032)
            });

            map.Pins.Add(new Pin()
            {
                Address = "Adresa",
                Label = "Grad",
                Position = new Position(48.137953, 11.576420)
            });

            map.Pins.Add(new Pin()
            {
                Address = "Adresa",
                Label = "Grad",
                Position = new Position(48.136042, 11.573792)
            });

            this.Content = map;
        }
    }
}
