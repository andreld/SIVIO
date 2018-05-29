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
	public partial class ObrasBasePage : ContentPage
	{

		public ObrasBasePage (Models.ObrasModel item)
		{
			InitializeComponent();

            this.Title = item.FKInstalacao;
            this.labelResumo.Text = item.DescriObra;
            this.labelEmpresa.Text = item.FKReponsavel.ToString();
            this.labelOrigem.Text = item.OrigemRecursos;
            this.labelCusto.Text = "R$" + item.Custo.ToString();
            this.labelDataInicio.Text = item.DataInicio.ToString("dd/MM/yyyy");
            this.labelPrazo.Text = item.Prazo.ToString() + " dias";
		}
	}
}