

namespace examenXamarin.Views
{
    using examenXamarin.Models;
    using System.Collections.Generic;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;

    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class UserDetailView : ContentPage
	{

        //private Medico user;
        private List<User> users { get; set; }

        private User user;
        public UserDetailView()
        {
            InitializeComponent();
            user = new User();
            users = new User().GetUsers();
            user = users[0];
        }

       // public UserDetailView(User selectedItem) { 
   
           // this.user = selectedItem;
          //  this.imageUrl.Source = user.imageUrl;
          //  this.fullname.Text = user.fullname;
       // }
    }
}