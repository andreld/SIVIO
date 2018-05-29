using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sivio.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Start : MasterDetailPage
    {
        public Start()
        {
            InitializeComponent();
            //BindingContext = new ViewModels.StartViewModel();
            App.MasterDetail = this;
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as StartMenuItem;
            if (item == null)
                return;

            /*var page = (Page)Activator.CreateInstance(item.TargetType);
            page.Title = item.Title;

            Detail = new NavigationPage(page);*/
            
            IsPresented = false;
            MasterPage.ListView.SelectedItem = null;

            if (item.Title == "Obras")
            {
                await App.MasterDetail.Detail.Navigation.PushAsync(new ObrasView());
            }

            if (item.Title == "Empresas")
            {
                await App.MasterDetail.Detail.Navigation.PushAsync(new EmpresasView());
            }

            if (item.Title == "Sobre")
            {
                await App.MasterDetail.Detail.Navigation.PushAsync(new SobreView());
            }

        }
    }
}