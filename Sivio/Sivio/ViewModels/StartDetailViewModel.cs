using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace Sivio.ViewModels
{
    class StartDetailViewModel : ViewModelBase
    {
        public static Map mapa;
        private List<Models.ObrasModel> obras;
        private Services.ApiClient apiClient = new Services.ApiClient();
        //private bool atualizando;

        public List<Models.ObrasModel> Obras
        {
            get { return obras; }
            set { SetProperty(ref obras, value); }
        }

        /*
        public bool Atualizando
        {
            get { return atualizando; }
            set
            {
                SetProperty(ref atualizando, value);
            }
        }

        public ICommand AtualizaCommand => new Command(async () =>
        {
            await GetTodoes();
        });
        */

        public StartDetailViewModel(){
            LoadObras();
        }

        private async Task LoadObras()
        {
            Obras = await apiClient.GetObras();
            foreach (var item in Obras)
            {
                var pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(item.Latitude, item.Longitude),
                    Label = item.ResumoObra,
                };

                mapa.Pins.Add(pin);
            }
        }
    }
}
