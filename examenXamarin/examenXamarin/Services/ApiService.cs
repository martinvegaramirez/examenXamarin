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
        public async Task<RootObject> GetUser()
        {
           try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri("https://randomuser.me");
                var url = "/api/";
                var response = await client.GetAsync(url);
                var result = await response.Content.ReadAsStringAsync();
                if (!response.IsSuccessStatusCode)
                {
                    return new RootObject();
                    await DisplayAlert("Error", "No hay conexion", "Aceptar");
                }

                var ro = JsonConvert.DeserializeObject<RootObject>(result);
                return ro;
            }
            catch
            {
                return new RootObject();
            }
        }

        private Task DisplayAlert(string v1, string v2, string v3)
        {
            throw new NotImplementedException();
        }
    }
 }
