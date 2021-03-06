﻿using SQLite.Net.Attributes;
using System;

namespace examenXamarin.Models
{
    public class Medico
    {
        [PrimaryKey, AutoIncrement]
        public string imageUrl { get; set; }
        [Unique]
        public string fullname { get; set; }
        public string rating { get; set; }
        public string email { get; set; }
        public string street { get; set; }
        public string city { get; set; }

        public string state { get; set; }
        public string postalcode { get; set; }
        public string telephone { get; set; }
        public string lat { get; set; }
        public string lon { get; set; }

    }
}
