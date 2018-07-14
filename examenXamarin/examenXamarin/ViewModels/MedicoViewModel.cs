using examenXamarin.Models;
using examenXamarin.Services;

namespace examenXamarin.ViewModels
{
    public class MedicoViewModel
    {

        #region Atributes
        private ApiService apiService;
        #endregion

        #region Constructors
        public MedicoViewModel()
        {
            apiService = new ApiService();
        }
        #endregion

        private async void Start()
        {

            var userApi = await apiService.GetUser();


           

        }




    }
}
