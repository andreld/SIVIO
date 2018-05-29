using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sivio.ViewModels.ServicesVM
{
    public interface INavigationService
    {
        //navegações
        Task NavigateTo(string item);
    }
}
