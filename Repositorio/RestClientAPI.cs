using System;
using System.Collections.Generic;
using System.Net.Http;
using Dashboard.Dll.NETF.Encapsulacion;
using LumoNotificaciones.Models;
using Newtonsoft.Json;

namespace LumoNotificaciones.Repositorio
{
    public class RestClientAPI
    {
        DBMensajes restClient = new DBMensajes();
        NotificacionesSQLite sqLite = new NotificacionesSQLite();

        public DBMensajes.Configuracion ObtenerConfiguracion(string Id)
        {
            DBMensajes.Configuracion result = null;

            try
            {
                result = restClient.Intervalo(Id);

                sqLite.GuardarBitacora("API: ObtenerMensajes", DateTime.Now);
            }
            catch (Exception ex)
            {
                sqLite.GuardarBitacora("Error en metodo ObtenerConfiguracion API. Error: " + ex.Message, DateTime.Now);
            }
            return result;
        }


        public RegresaMensajes ObtenerMensajes(string PC)
        {
            RegresaMensajes result = null;

            try
            {
                string requestParams = string.Empty;
                List<KeyValuePair<string, string>> lstParameters = new List<KeyValuePair<string, string>>();

                lstParameters.Add(new KeyValuePair<string, string>("Equipo", PC));
                requestParams = new FormUrlEncodedContent(lstParameters).ReadAsStringAsync().Result;

                string responseObj = restClient.Get(PC, "");

                result = JsonConvert.DeserializeObject<RegresaMensajes>(responseObj);

                sqLite.GuardarBitacora("API: ObtenerMensajes", DateTime.Now);
            }
            catch (Exception ex)
            {
                sqLite.GuardarBitacora("Error en metodo ObtenerMensajes API. Error: " + ex.Message, DateTime.Now);
            }
            return result;
        }

        public RegresaUpdate UpdateMensajes(int IdMensaje)
        {
            RegresaUpdate result = null;

            try
            {
                string requestParams = string.Empty;
                List<KeyValuePair<string, string>> lstParameters = new List<KeyValuePair<string, string>>();

                lstParameters.Add(new KeyValuePair<string, string>("IdMensaje", IdMensaje.ToString()));
                requestParams = new FormUrlEncodedContent(lstParameters).ReadAsStringAsync().Result;

                string responseObj = restClient.Update(IdMensaje);

                result = JsonConvert.DeserializeObject<RegresaUpdate>(responseObj);

                sqLite.GuardarBitacora("API: UpdateMensajes" + result.Message.StatusCode, DateTime.Now);
            }
            catch (Exception ex)
            {
                sqLite.GuardarBitacora("Error en metodo UpdateMensajes API. Error: " + ex.Message, DateTime.Now);
            }
            return result;
        }

        public List<DBMensajes.MensajeNoContent> ObtenerMensajesGeneral(string PC, int Mantenimiento)
        {
            List<DBMensajes.MensajeNoContent> result = null;

            try
            {
                string requestParams = string.Empty;
                List<KeyValuePair<string, string>> lstParameters = new List<KeyValuePair<string, string>>();

                lstParameters.Add(new KeyValuePair<string, string>("Equipo", PC));
                requestParams = new FormUrlEncodedContent(lstParameters).ReadAsStringAsync().Result;

                result = restClient.GetMessagesFullNoContent(PC, Mantenimiento);

                //result = JsonConvert.DeserializeObject<DBMensajes.MensajeNoContent>(responseObj);

                sqLite.GuardarBitacora("API: ObtenerMensajes", DateTime.Now);
            }
            catch (Exception ex)
            {
                sqLite.GuardarBitacora("Error en metodo ObtenerMensajes API. Error: " + ex.Message, DateTime.Now);
            }
            return result;
        }
    }
}
