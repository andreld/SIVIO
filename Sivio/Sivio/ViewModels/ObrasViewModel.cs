using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using Sivio.Views;
using System.Windows.Input;
using Android.Widget;

namespace Sivio.ViewModels
{
    class ObrasViewModel : ViewModelBase
    {

        private ObservableCollection<Models.ObrasModel> obrasSource;

        //Essa propriedade se ligará com a propriedade ItemsSource da View
        public ObservableCollection<Models.ObrasModel> ObrasSource {
            get
            {
                return obrasSource;
            }
            set
            {
                //obrasSource = value;
                //OnPropertyChanged();
                SetProperty(ref obrasSource, value);
            }
        }

        public ObrasViewModel()
        {
            //inicializa a Lista com alguns elementos, no aplicativo iremos puxar os dados do webservice
            //com o método Load();

            ObrasSource = new ObservableCollection<Models.ObrasModel>
            {
                new Models.ObrasModel{
                    FKInstalacao ="CCH",
                    ResumoObra = "Reforma Genérica",
                    DescriObra = "Reforma Genérica lorem ipsum ajkjsak  jkaksak kajskj." +
                    "aksjaksj aksjakj sk kajskajs jaksjaksj j kasj"+
                    "Reforma Genérica lorem ipsum ajkjsak  jkaksak kajskj." +
                    "aksjaksj aksjakj sk kajskajs jaksjaksj j kasj"+
                    "Reforma Genérica lorem ipsum ajkjsak  jkaksak kajskj." +
                    "aksjaksj aksjakj sk kajskajs jaksjaksj j kasj"+
                    "Reforma Genérica lorem ipsum ajkjsak  jkaksak kajskj." +
                    "aksjaksj aksjakj sk kajskajs jaksjaksj j kasj"+
                    "Reforma Genérica lorem ipsum ajkjsak  jkaksak kajskj." +
                    "aksjaksj aksjakj sk kajskajs jaksjaksj j kasj"+
                    "Reforma Genérica lorem ipsum ajkjsak  jkaksak kajskj." +
                    "aksjaksj aksjakj sk kajskajs jaksjaksj j kasj"+
                    "Reforma Genérica lorem ipsum ajkjsak  jkaksak kajskj." +
                    "aksjaksj aksjakj sk kajskajs jaksjaksj j kasj"+
                    "Reforma Genérica lorem ipsum ajkjsak  jkaksak kajskj." +
                    "aksjaksj aksjakj sk kajskajs jaksjaksj j kasj"+
                    "Reforma Genérica lorem ipsum ajkjsak  jkaksak kajskj." +
                    "aksjaksj aksjakj sk kajskajs jaksjaksj j kasj"+
                    "Reforma Genérica lorem ipsum ajkjsak  jkaksak kajskj." +
                    "aksjaksj aksjakj sk kajskajs jaksjaksj j kasj"+
                    "Reforma Genérica lorem ipsum ajkjsak  jkaksak kajskj." +
                    "aksjaksj aksjakj sk kajskajs jaksjaksj j kasj"+
                    "Reforma Genérica lorem ipsum ajkjsak  jkaksak kajskj." +
                    "aksjaksj aksjakj sk kajskajs jaksjaksj j kasj",
                    FKReponsavel = "EmpresaX",
                    Custo = 105638.56,
                    Prazo = 300,
                    DataInicio = new DateTime(2018,5,3),
                    OrigemRecursos = "Governo Federal"
                },

                new Models.ObrasModel{
                    FKInstalacao = "CCET",
                    DescriObra = "Reforma estacionamento",
                    ResumoObra = "Reforma Genérica",
                    FKReponsavel = "EmpresaX",
                    Custo = 1000000.45,
                    Prazo = 300,
                    DataInicio = new DateTime(2018,5,3),
                    OrigemRecursos = "Governo Federal"
                },

                new Models.ObrasModel{FKInstalacao = "CCET",
                    DescriObra = "Construção de novo prédio",
                    ResumoObra = "Reforma Genérica",
                    FKReponsavel = "EmpresaX",
                    Custo = 1000000.45,
                    Prazo = 300,
                    DataInicio = new DateTime(2018,5,3),
                    OrigemRecursos = "Governo Federal"
                },
            };
            //this.Load(); 
        }

        public ICommand ItemClickCommand
        {
            get
            {
                return new Command((item) =>
                {
                    var showItem = item as Models.ObrasModel;
                    //var page = (Page)Activator.CreateInstance(typeof(ContentPage));
                    var page = new Sivio.Views.ObrasBasePage(showItem);

                    App.MasterDetail.Detail.Navigation.PushAsync(page);
                });
            }
        }

        public void Load()
        {
            //carrega itens a partir do webservice
        }
    }
}
