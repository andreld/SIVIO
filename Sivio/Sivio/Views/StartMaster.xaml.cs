using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sivio.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartMaster : ContentPage
    {
        public ListView ListView;

        public StartMaster()
        {
            InitializeComponent();

            BindingContext = new ViewModels.StartMasterViewModel();
            ListView = MenuItemsListView;
        }

        /*class StartMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<StartMenuItem> MenuItems { get; set; }
            
            public StartMasterViewModel()
            {
                MenuItems = new ObservableCollection<StartMenuItem>(new[]
                {
                    new StartMenuItem { Id = 0, Title = "Page 1" },
                    new StartMenuItem { Id = 1, Title = "Page 2" },
                    new StartMenuItem { Id = 2, Title = "Page 3" },
                    new StartMenuItem { Id = 3, Title = "Page 4" },
                    new StartMenuItem { Id = 4, Title = "Page 5" },
                });
            }
            
            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }*/
    }
}