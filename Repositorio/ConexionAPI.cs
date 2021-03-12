using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

using LumoNotificaciones.Models;

namespace LumoNotificaciones.Repositorio
{
    public class ConexionAPI
    {
        public string ObtenerConfiguracion(string id)
        {
            using (var client = new HttpClient())
            {
                var url = @"http://localhost:44333/Configuracion/ObtenerConfiguracion/?id=" + id;
                var request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                request.ContentType = "application/json";
                request.Accept = "application/json";

                try
                {
                    using (WebResponse response = request.GetResponse())
                    {
                        using (Stream strReader = response.GetResponseStream())
                        {
                            if (strReader == null) return string.Empty;

                            using (StreamReader objReader = new StreamReader(strReader))
                            {
                                string responseBody = objReader.ReadToEnd();
                                return responseBody;
                            }
                        }
                    }
                }
                catch (WebException ex)
                {
                    return string.Empty;
                }
            }
        }

        public string ObtenerEmpleado(string PC)
        {
            using (var client = new HttpClient())
            {
                var url = @"http://localhost:44333/Configuracion/ObtenerCorreo/?PC=" + PC;
                var request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                request.ContentType = "application/json";
                request.Accept = "application/json";

                try
                {
                    using (WebResponse response = request.GetResponse())
                    {
                        using (Stream strReader = response.GetResponseStream())
                        {
                            if (strReader == null) return string.Empty;

                            using (StreamReader objReader = new StreamReader(strReader))
                            {
                                string responseBody = objReader.ReadToEnd();
                                return responseBody;
                            }
                        }
                    }
                }
                catch (WebException ex)
                {
                    return string.Empty;
                }
            }
        }
    }
}
