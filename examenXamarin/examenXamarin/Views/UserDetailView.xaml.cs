

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
        public string imageUrl;
        public string fullname;
        public string email;
        public string rating;
        public string street;
        public string city;
        public string state;
        public string postalcode;
        public string telephone;
        public string lat;
        public string lon;

        public UserDetailView()
        {
            InitializeComponent();
            user = new User();
            users = new User().GetUsers();
            user = users[0];

            //Codigo final
            this.imageUrl = user.imageUrl;
            this.fullname = user.fullname;
            this.email = user.email;
            this.rating = user.rating;
            this.street = user.street;
            this.city = user.city;
            this.state = user.state;
            this.postalcode = user.postalcode;
            this.telephone = user.telephone;
            this.lat = user.lat;
            this.lon = user.lon;

        }

        // public UserDetailView(User selectedItem) { 

        // this.user = selectedItem;
        //  this.imageUrl.Source = user.imageUrl;
        //  this.fullname.Text = user.fullname;
        // }
    }
}