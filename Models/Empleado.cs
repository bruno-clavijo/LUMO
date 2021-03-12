using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LumoNotificaciones.Models
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public int NumEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public int? IdArea { get; set; }
        public int? IdHorario { get; set; }
        public int? IdOficina { get; set; }
        public string Equipo { get; set; }
    }
}
