using MotorolaDesktop.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MotorolaDesktop.RepositoriesCell
{
    public class CelularesRepository
    {
        string urlApi = "https://motorola-1e1f.restdb.io/rest/celulares";
        HttpClient client = new HttpClient();
        

        public CelularesRepository()
        {
            //configuramos que trabajará con respuestas JSON
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("apikey", "6670e05bb5eda1f5a6fce9e8");
        }
        public async Task<ObservableCollection<Celulares>?> ObtenerCelularesAsync()
        {
            var response = await client.GetStringAsync(urlApi);
            return JsonConvert.DeserializeObject<ObservableCollection<Celulares>>(response);
        }
        //public string _id { get; set; }
        //public string nombre { get; set; }
        //public string modelo { get; set; }
        //public string autor { get; set; }
        //public string urlimagen { get; set; }
        //public string descripcion { get; set; }
        public async Task<Celulares?> AgregarAsync(string nombre, string modelo, string autor, string urlimagen, string descripcion)
        {
            //creamos un objeto del tipo Nota con los parámetros que llegan
            Celulares celulares = new Celulares()
            {
                nombre = nombre,
                modelo = modelo,
                autor = autor,
                urlimagen = urlimagen,
                descripcion = descripcion,
            };
            //enviamos por POST el objeto que creamos a la URL de la API
            var celularesjson = new StringContent(JsonConvert.SerializeObject(celulares), Encoding.UTF8, "application/json");
            var response = await client.PostAsync(urlApi, celularesjson);

            //retorna el objeto que se agregó en la API ya con su ID generado por la base de datos
            return JsonConvert.DeserializeObject<Celulares>(
                await response.Content.ReadAsStringAsync());
        }
        public async Task<Celulares?> ActualizarAsync(string nombre, string modelo, string autor, string urlimagen, string descripcion, string id)
        {
            //creamos un objeto del tipo Libro con los parámetros que llegan
            Celulares celulares = new Celulares()
            {
                nombre = nombre,
                modelo = modelo,
                autor = autor,
                urlimagen = urlimagen,
                descripcion = descripcion,
            };



            //enviamos por POST el objeto que creamos a la URL de la API
            var celularesjson = new StringContent(
                    JsonConvert.SerializeObject(celulares),
                    Encoding.UTF8, "application/json");

            var response = await client.PutAsync(urlApi + "/" + id, celularesjson);

            //retorna el objeto que se agregó en la API ya con su ID generado por la base de datos
            return JsonConvert.DeserializeObject<Celulares>(
                await response.Content.ReadAsStringAsync());
        }


        public async Task<Celulares?> ObtenerPorIdAsync(string id)
        {
            var response = await client.GetStringAsync($"{urlApi}/{id}");
            return JsonConvert.DeserializeObject<Celulares>(response);
        }

        public async Task<bool> EliminarAsync(string id)
        {
            var response = await client.DeleteAsync(urlApi + "/" + id);
            return response.IsSuccessStatusCode;
        }
    }
}

