using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LumoNotificaciones.Models
{
    public class Configuracion
    {
        public string Id { get; set; }
        public string Valor { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }
    }
}