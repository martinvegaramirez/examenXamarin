using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace examenXamarin.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainView : ContentPage
	{

        public MainView ()
		{
			InitializeComponent ();
            btnLogin.Clicked += btnLogin_Clicked;
            
        }

        private async void btnLogin_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(entEmail.Text) )
            {
                await DisplayAlert("Error", "Debe de introducir un usuario valido","Aceptar");
                entEmail.Focus();
                return;
            }
            if (string.IsNullOrEmpty(entPass.Text))
            {
                await DisplayAlert("Error", "Su contraseña no debe ser nula", "Aceptar");
                entPass.Focus();
                return;
            }

            //await Navigation.PushAsync(new MainView());
            
      
        }
    }
}