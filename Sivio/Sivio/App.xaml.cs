using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Sivio
{
	public partial class App : Application
	{

        public static MasterDetailPage MasterDetail { get; set; }

		public App ()
		{
            DependencyService.Register<ViewModels.ServicesVM.INavigationService, Views.ServicesV.NavigationService> ();

			InitializeComponent();

			//MainPage = new Views.Start();
            MainPage = new MainPage();
		}

		protected override void OnStart ()
		{
            // Handle when your app starts
        }

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
