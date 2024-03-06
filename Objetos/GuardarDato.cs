using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Objetos
{
    public class GuardarDato
    {
        public List<Usuario> Deserializar(string ruta)
        {
            List<Usuario> usuarios = null;
            string jsonText = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + ruta);

            usuarios = JsonConvert.DeserializeObject<List<Usuario>>(jsonText);
            return usuarios;
        }
        public List<Filamento> Deserializar()
        {
            List<Filamento> usuarios = null;
            string jsonText = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "\\Filamentos.json");

            usuarios = JsonConvert.DeserializeObject<List<Filamento>>(jsonText);
            return usuarios;
        }
        public void Serializar(string ruta,  List<Filamento> contenido)
        {
            string json = JsonConvert.SerializeObject(contenido);
            File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + ruta, json);
        }
        /// <summary>
        /// sobre carga para recibir una lista de usuarios
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="objeto"></param>
        public void Serializar(string ruta, List<Usuario> contenido)
        {
            string json = JsonConvert.SerializeObject(contenido);
            File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + ruta, json);
        }
    }
}
