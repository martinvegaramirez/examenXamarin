using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using examenXamarin.Services;
using System.Threading.Tasks;
using examenXamarin.Models;
using examenXamarin.ViewModels;

namespace examenXamarin.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class UserView : ContentPage
	{

        UserViewModel vm;

        public UserView()
        {
            InitializeComponent();
            vm = new  UserViewModel();
            BindingContext = vm;
            listUsers.ItemSelected += listUsers_ItemSelected;
        }

        

        private async void listUsers_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
           // await Navigation.PushAsync(new NavigationPage(new UserDetailView((Medico)e.SelectedItem)));
        }

    
 
    }
}