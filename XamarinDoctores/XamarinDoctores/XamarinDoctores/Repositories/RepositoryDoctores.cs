using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using XamarinDoctores.Models;

namespace XamarinDoctores.Repositories
{
    public class RepositoryDoctores
    {
        String urlapi;
        public RepositoryDoctores() { this.urlapi = "https://apidoctoresdvb.azurewebsites.net/"; }
        private HttpClient GetHttpClient()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("applpication/json"));
            return client;
        }

        public async Task<List<Doctor>> GetDoctores()
        {
            String peticion = "api/Doctores";
            Uri url = new Uri(this.urlapi + peticion);
            HttpClient client = this.GetHttpClient();
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                String json = await response.Content.ReadAsStringAsync();
                List<Doctor> doctores = JsonConvert.DeserializeObject<List<Doctor>>(json);
                return doctores;
            } else
            {
                return null;
            }

        }
    }
}
