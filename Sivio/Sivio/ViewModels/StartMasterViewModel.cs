using Sivio.Views;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace Sivio.ViewModels
{
    class StartMasterViewModel : ViewModelBase
    {
        public ObservableCollection<StartMenuItem> MenuItems { get; set; }

        public StartMasterViewModel()
        {
            MenuItems = new ObservableCollection<StartMenuItem>(new[]
            {
                    new StartMenuItem { Id = 0, Title = "Obras"},
                    new StartMenuItem { Id = 1, Title = "Empresas"},
                    new StartMenuItem { Id = 2, Title = "Sobre"},
                    /*new MainViewMenuItem { Id = 3, Title = "Page 4" },
                    new MainViewMenuItem { Id = 4, Title = "Page 5" },*/
                });
        }
    }
}