using System;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace examenXamarin
{
    using Xamarin.Forms;
    using Views;
    using System.Collections.Generic;
    using examenXamarin.Models;

    public partial class App : Application
	{
        public static NavigationPage Navigator { get; internal set; }


        public App ()
		{
			InitializeComponent();


            MainPage = new UserDetailView( );
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
