using EjerciciosDePrueba.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.Unicode;
using System.Threading.Tasks;

namespace EjerciciosDePrueba.Repositories
{
    public class LibroRepository
    {
        string urlApi = "https://biblioisp20-b71c.restdb.io/rest/libros";
        HttpClient client = new HttpClient();


        public LibroRepository ()
        {
            //configuramos que trabajará con respuestas JSON
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("apikey", "64f8c70e6888543b6e0bfe85");
        }
        public async Task<ObservableCollection<Libros>?> ObtenerLibrosAsync()
        {
            var response = await client.GetStringAsync(urlApi);
            return JsonConvert.DeserializeObject<ObservableCollection<Libros>>(response);
        }
    
    //public string _id { get; set; }
    //public string nombre { get; set; }
    //public int paginas { get; set; }
    //public string autor { get; set; }
    //public string editorial { get; set; }
    //public string portada_url { get; set; }
    //public string sinopsis { get; set; }
    //public string genero { get; set; }
    public async Task<Libros?>AgregarAsync(string nombre, int paginas, string autor, string editorial, string portada_url, string sinopsis, string genero)
    {
        //creamos un objeto del tipo Nota con los parámetros que llegan
        Libros libro= new Libros()
        {
            nombre = nombre,
            autor = autor,
            editorial = editorial,
            portada_url = portada_url,
            sinopsis = sinopsis,
            paginas = paginas,
            genero = genero
        };



        //enviamos por POST el objeto que creamos a la URL de la API
        var librosjson = new StringContent(JsonConvert.SerializeObject(libro),Encoding.UTF8, "application/json");
        var response = await client.PostAsync(urlApi, librosjson);
            
                

        //retorna el objeto que se agregó en la API ya con su ID generado por la base de datos
        return JsonConvert.DeserializeObject<Libros>(
            await response.Content.ReadAsStringAsync());
    }

    public async Task<Libros?> ActualizarAsync(string nombre, int paginas, string autor, string editorial, string portada_url, string sinopsis, string genero, string id)
        {
            //creamos un objeto del tipo Libro con los parámetros que llegan
            Libros libro = new Libros()
            {
                nombre = nombre,
                autor = autor,
                editorial = editorial,
                portada_url = portada_url,
                sinopsis = sinopsis,
                paginas = paginas,
                genero = genero
            };



            //enviamos por POST el objeto que creamos a la URL de la API
            var librojson = new StringContent(
                    JsonConvert.SerializeObject(libro),
                    Encoding.UTF8, "application/json");

            var response = await client.PutAsync(urlApi + "/" + id, librojson);

            //retorna el objeto que se agregó en la API ya con su ID generado por la base de datos
            return JsonConvert.DeserializeObject<Libros>(
                await response.Content.ReadAsStringAsync());
        }


        public async Task<Libros?> ObtenerPorIdAsync(string id)
        {
            var response = await client.GetStringAsync($"{urlApi}/{id}");
            return JsonConvert.DeserializeObject<Libros>(response);
        }

        public async Task<bool> EliminarAsync(string id)
        {
            var response = await client.DeleteAsync(urlApi + "/" + id);
            return response.IsSuccessStatusCode;
        }
    }
}
