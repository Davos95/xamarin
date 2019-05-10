using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using XamarinEmpleados.Models;

namespace XamarinEmpleados.Repositories
{
    public class RepostioryEmpleados
    {
        private String urlapi;
        public RepostioryEmpleados()
        {
            this.urlapi = "https://apiempleadodvb.azurewebsites.net/";
        }

        private HttpClient GetHttpClient()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            return client;
        }

        public async Task<List<Empleado>> GetEmpleados()
        {
            String peticion = "api/Empleados";
            Uri uri = new Uri(this.urlapi + peticion);
            HttpClient client = this.GetHttpClient();
            HttpResponseMessage response = await client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                String contenido = await response.Content.ReadAsStringAsync();
                List<Empleado> empleados = JsonConvert.DeserializeObject<List<Empleado>>(contenido);
                return empleados;
            }
            else
            {
                return null;
            }
        }
    }
}
