using System.Linq;
using eWohnung.Model;
using Xamarin.Forms;

namespace eWohnung
{
    public partial class ListaTest : ContentPage
    {
        public ListaTest()
        {
            InitializeComponent();

        }

        private void VisualElement_OnUnfocused(object sender, FocusEventArgs e)
        {
            AlenTestLista.BeginRefresh();

            string filter = AlenSearchBar.Text;
            AlenTestLista.ItemsSource = filter == null
                ? App.Locator.Stan.ListaStanova
                : App.Locator.Stan.ListaStanova.Where(s => s.SifraStana.ToLower().Contains(filter.ToLower()));

            AlenTestLista.EndRefresh();
        }

        private void AlenSearchBar_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            if(string.IsNullOrEmpty(e.NewTextValue))
                VisualElement_OnUnfocused(sender, null);

        }

        private async void AlenTestLista_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            AlenTestLista.SelectedItem = null;
            App.Locator.Stan.Stan = e.Item as StanTest;
            await App.NavPage.Navigation.PushAsync(new DetaljiStana());
        }
    }
}
