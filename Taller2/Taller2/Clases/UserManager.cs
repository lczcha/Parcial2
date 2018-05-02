using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;


namespace Taller2.Clases
{
    class UserManager
    {
        // nos trae la conexion.
        const String URL = "http://pastoral.iucesmag.edu.co/practica/listar.php";
        //const String URL = "http://localhost/practica/listar.php";

        private HttpClient getCliente()
        {
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Add("Accept", "application/json");// permita interprete pasar a json
            client.DefaultRequestHeaders.Add("Connection", "close");

            return client;
        }

        public async Task<IEnumerable<User>> getUsuarios()
        { // IEnumerable permite visualizar una lista que contiene datos
            HttpClient client = getCliente();

            var res = await client.GetAsync(URL);

            if (res.IsSuccessStatusCode)
            {
                string content = await res.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<IEnumerable<User>>(content);// se descompone informacion de los valores (leibes) para interprete de XAML
            }

            return Enumerable.Empty<User>();

        }

    }
}