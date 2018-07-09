using SQLite.Net.Interop;


namespace examenXamarin.Models
{
    public interface IConfig 
    {
        string DirectoryDB { get; }

        ISQLitePlatform Platform { get; }

    }
}
