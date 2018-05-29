
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace Sivio.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartDetail : ContentPage
    {
        public StartDetail()
        {
            InitializeComponent();

            BindingContext = new ViewModels.StartDetailViewModel();
            ViewModels.StartDetailViewModel.mapa = ufmaMap;

            Centralizar();
        }

        private void Centralizar()
        {
            ufmaMap.MoveToRegion(
                MapSpan.FromCenterAndRadius(
                    new Position(-2.5571836, -44.3115651), Distance.FromMiles(0.5)));
        }
    }
}