

namespace examenXamarin.Views
{
    using examenXamarin.Models;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;

    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class UserDetailView : ContentPage
	{

        private Medico user;
        private UserDetailView(User selectedItem)
		{
			InitializeComponent ();

		}

        public UserDetailView(Medico selectedItem) { 
   
            this.user = selectedItem;
            this.imageUrl.Source = user.imageUrl;
            this.fullname.Text = user.fullname;
        }
    }
}