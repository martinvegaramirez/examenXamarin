using SQLite.Net.Attributes;
using System;

namespace examenXamarin.Models
{
    class Medico
    {
        [PrimaryKey, AutoIncrement]
        public string imageUrl { get; set; }
        public string fullname { get; set; }
        public string rating { get; set; }
        public string email { get; set; }
        public string street { get; set; }
  
        public string state { get; set; }
        public string postalcode { get; set; }
        public string telephone { get; set; }
        public string lat { get; set; }
        public string lon { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {3} {4}", imageUrl, email, fullname, rating);
        }

    }
}
