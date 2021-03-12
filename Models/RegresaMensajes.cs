using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LumoNotificaciones.Models
{
    public class RegresaMensajes
    {
        public List<Mensaje> Lista { get; set; }
        public HttpResponseMessage Message { get; set; }
    }

    public class Mensaje
    {
        public int IdMensaje { get; set; }
        public int? IdArea { get; set; }
        public int? IdUsuario { get; set; }
        public DateTime Fecha { get; set; }
        public string MensajeDescripcion { get; set; }
        public bool Estatus { get; set; }
        public int IdUsuarioRegistro { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Titulo { get; set; }
        public bool Visto { get; set; } = false;

        public int TipoMensaje { get; set; }
    }


    public class RegresaConfiguracion
    {
        public Configuracion Configuracion { get; set; }
        public HttpResponseMessage Message { get; set; }
    }

    public class Configuracion
    {
        public string Id { get; set; }
        public string Valor { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }
    }
}
