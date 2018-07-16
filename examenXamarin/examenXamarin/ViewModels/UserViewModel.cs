
namespace examenXamarin.ViewModels
{
    using examenXamarin.Models;
    using examenXamarin.Services;
    using GalaSoft.MvvmLight.Command;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Linq;
    using System.Windows.Input;

    public class UserViewModel : INotifyPropertyChanged
	{

        public List<Medico> Users { get; set; }

        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        private ApiService apiService;
        private RootObject userApi ;
       
        #endregion

        #region Atributes
        string _imageUrl;
        string _fullname;
        string _email;
        #endregion


        #region Properties
        public string imageUrl
        { 
            get
            {
                return _imageUrl;
            }
            set
            {
                if ( _imageUrl != value )
                {
                    _imageUrl = value;
                    PropertyChanged?.Invoke(
                        this, new PropertyChangedEventArgs(nameof(imageUrl)));
                }
            }
        }

        public string fullname
        {
            get
            {
                return _fullname;
            }
            set
            {
                if (_fullname != value)
                {
                    _fullname = value;
                    PropertyChanged?.Invoke(
                        this, new PropertyChangedEventArgs(nameof(fullname)));
                }
            }
        }

        public string email
        {
            get
            {
                return _email;
            }
            set
            {
                if (_email != value)
                {
                    _email = value;
                    PropertyChanged?.Invoke(
                        this, new PropertyChangedEventArgs(nameof(email)));
                }
            }
        }
        #endregion
       
        #region Constructors

        public UserViewModel()
        {

            Console.WriteLine("Antes de init DB");
            Users = new List<Medico>();
            userApi = new RootObject();
            apiService = new ApiService();
            initDB();


        }

        #endregion

        #region Methods
        private async void initDB()
        {
            for (int i = 0; i < 5; i++)
            {
                int rating = 0;
                userApi = await apiService.GetUser();
                for (int j = 0; j < 10; j++)
                {
                    //Randoms
                    Random rnd = new Random();
                    int numero = rnd.Next(5);
                    rating += numero;
                }
                rating = rating / 10;
                var medico = new Medico
                {
                    imageUrl = userApi.results[0].picture.large,
                    fullname = userApi.results[0].name.title + ' ' + userApi.results[0].name.first + ' ' + userApi.results[0].name.last,
                    rating = rating.ToString(),
                    email = userApi.results[0].email,
                    street = userApi.results[0].location.street,
                    city = userApi.results[0].location.city,
                    state = userApi.results[0].location.state,
                    postalcode = userApi.results[0].location.postcode,
                    telephone = userApi.results[0].phone,
                    lat = userApi.results[0].location.coordinates.latitude,
                    lon = userApi.results[0].location.coordinates.longitude

                };

                Users.Add(medico);
                Console.WriteLine("Grabando Record {0} {1}",i, medico.fullname);
                /*
                using (var da = new DataAccess())
                {
                    da.Insert(medico);
                    //productsListView.ItemsSource = da.GetList<Product>(false).OrderBy(p => p.Description);
                    Medicos = da.GetList<Medico>(false);
                    Console.WriteLine("Insertando {0}", i);
                }
                */

            }


        }

        #endregion

        #region Commands
        public ICommand AceptarCommand {
            get
            {
                return new RelayCommand(Aceptar);
            }
        }

        void Aceptar()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}