
namespace examenXamarin.ViewModels
{
    using examenXamarin.Models;
    using GalaSoft.MvvmLight.Command;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Windows.Input;

    public class UserViewModel 
	{
        #region Properties

        public string imageUrl
        {
            get;
            set;
        }

        public string fullname
        {
            get;
            set;
        }

        public string email
        {
            get;
            set;
        }
        #endregion
        //public List<User> users { get; set; }

        public UserViewModel()
        {
           // users = new User().GetUsers();
        }

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