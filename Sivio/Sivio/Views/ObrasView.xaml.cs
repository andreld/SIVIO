using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sivio.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ObrasView : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }

        public ObrasView()
        {
            InitializeComponent();

            BindingContext = new ViewModels.ObrasViewModel();
            //onde estava a OC
			
			//MyListView.ItemsSource = Items;
        }


        /*
        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }*/
    }
}
