using examenXamarin.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace examenXamarin.Services
{
    public class ApiService
    {
        public async Task<List<UserApi>> GetAllOrders()
        {
           try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri("https://randomuser.me");
                var url = "/api/";
                var response = await client.GetAsync(url);
                if (!response.IsSuccessStatusCode)
                {
                    return new List<UserApi>();
                    await DisplayAlert("Error", "No hay conexion", "Aceptar");
                }

                var result = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<UserApi>>(result);
            }
            catch
            {
                return new List<UserApi>();
            }
        }

        private Task DisplayAlert(string v1, string v2, string v3)
        {
            throw new NotImplementedException();
        }
    }
 }
