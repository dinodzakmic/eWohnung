using System.Linq;
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
                : App.Locator.Stan.ListaStanova.Where(s => s.Name.ToLower().Contains(filter.ToLower())).ToList();

            AlenTestLista.EndRefresh();
        }

        private void AlenSearchBar_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            if(string.IsNullOrEmpty(e.NewTextValue))
                VisualElement_OnUnfocused(sender, null);

        }
    }
}
