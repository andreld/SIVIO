using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Sivio.Views.ServicesV
{
    class NavigationService : ViewModels.ServicesVM.INavigationService
    {
        //ajeitar para recebr o objeto item
        public async Task NavigateTo(string item)
        {   
            await App.MasterDetail.Detail.Navigation.PushAsync(new Views.EmpresasView());
        }
    }
}
