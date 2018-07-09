
using examenXamarin.Models;
using SQLite.Net.Interop;
using System;
using Xamarin.Forms;

[assembly: Dependency(typeof(examenXamarin.iOS.Config))]

namespace examenXamarin.iOS
{
    public class Config : IConfig
    {
        private string directoryDB;
        private ISQLitePlatform platform;

        public string DirectoryDB
        {
            get
            {
                if (string.IsNullOrEmpty(directoryDB))
                {
                    var directory = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                    directoryDB = System.IO.Path.Combine(directory, "..", "Library");
                }

                return directoryDB;
            }
        }

        public ISQLitePlatform Platform
        {
            get
            {
                if (platform == null)
                {
                    platform = new SQLite.Net.Platform.XamarinIOS.SQLitePlatformIOS();
                }

                return platform;
            }
        }

        ISQLitePlatform IConfig.Platform => throw new System.NotImplementedException();
    }
}

