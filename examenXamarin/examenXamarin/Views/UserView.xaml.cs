using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using examenXamarin.Services;
using System.Threading.Tasks;
using examenXamarin.Models;

namespace examenXamarin.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class UserView : ContentPage
	{
        private ApiService apiService;
        public UserView ()
		{
			InitializeComponent ();
            apiService = new ApiService();
            initDB();
        }
        
        private async void initDB()
        {
            for (int i=0; i<=5; i++) {
                 int rating = 0;
                var usersApi = await apiService.GetAllOrders();
                for ( int j=0; j<=10; j++)
                {
                    //Randoms
                    Random rnd = new Random();
                    int numero = rnd.Next(5);
                    rating += numero / 2;
                    Console.WriteLine("Rating: {0}", rating);
                }

                var medico = new Medico
                {
                    imageUrl = usersApi[0].results.picture.large,
                };


            }


        }

        private Task DisplayAlert(string v1, Func<string> toString, string v2)
        {
            throw new NotImplementedException();
        }
    }
}