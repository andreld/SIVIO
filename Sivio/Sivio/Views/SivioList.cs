using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Sivio.Views
{
    public class SivioList : ListView
    {
        //a SivioList terá uma propriedade exclusiva declarada abaixo
        public static BindableProperty ItemClickCommandProperty = BindableProperty.Create(nameof(ItemClickCommand),
            typeof(ICommand), typeof(SivioList), null);

        public static BindableProperty LoadCommandProperty = BindableProperty.Create(nameof(LoadCommand),
            typeof(ICommand), typeof(SivioList), null);

        //public event EventHandler ItemTapped;

        private ICommand LoadCommand
        {
            get
            {
                return (ICommand)this.GetValue(LoadCommandProperty);
            }
            set
            {
                this.SetValue(LoadCommandProperty, value);
            }
        }

        // essa propriedade é do tipo ICommand e deve ser implementada na viewmodel
        public ICommand ItemClickCommand
        {
            get
            {
                return (ICommand)this.GetValue(ItemClickCommandProperty);
            }
            set
            {
                this.SetValue(ItemClickCommandProperty, value);
            }
        }

        public SivioList()
        {
            //a classe List tem seus métodos manipuladores de eventos que são publishers, ou seja
            this.ItemTapped += OnItemTapped; //método publicador += evento inscritos 
            //this.ItemAppearing += OnItemAppearing;

        }

        private void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item != null)
            {
                SelectedItem = null;
                ItemClickCommand?.Execute(e.Item);
                //SelectedItem = null;
            }
        }

            /*
        protected virtual void OnItemTapped()
        {
            ItemTapped?.Invoke(this, EventArgs.Empty);
        }

        //publisher of the event
        protected void OnItemAppearing(object sender, ItemVisibilityEventArgs e)
        {
            if (this.ItemsSource is IList items && e.Item == items[items.Count - 1])
            {
                if (this.LoadCommand != null && this.LoadCommand.CanExecute(null))
                {
                    this.LoadCommand.Execute(null);
                }
            }
        }*/
    }
}
