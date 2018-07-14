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

        List<User> Users { get; set; }
        User user { get; set; }
        public App ()
		{
			InitializeComponent();

            //MainPage = new MainView();
            user = new User();
            Users = user.GetUsers();
            MainPage = new UserDetailView(Users[0]);
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
