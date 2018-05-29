using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace Sivio
{
	public partial class MainPage : ContentPage
	{

        private Services.ApiClient apiClient = new Services.ApiClient();

        public MainPage()
		{

			InitializeComponent();

            MyMap.MoveToRegion(
                MapSpan.FromCenterAndRadius(
                    new Position(-2.5571836, -44.3115651), Distance.FromMiles(1)));
          
            var pin = new Pin
            {
                Type = PinType.Place,
                Position = new Position(-2.5571836, -44.3115651),
                Label = "UFMA",
                Address = "www.ufma.br",
            };
        }
    }
}
