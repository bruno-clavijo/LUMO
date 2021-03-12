using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LumoNotificaciones {
    public class Mensajes {
        public Mensajes( ) {
            
        }
        public static string ObtenMensajes( string usuario ) {

            StringBuilder cadena = new StringBuilder();
            cadena.Append("KPI: Ventas");
            cadena.Append(Environment.NewLine);
            cadena.Append("Total de ventas del mes: $500 millones");
            cadena.Append(Environment.NewLine);
            cadena.Append("Porcentaje cumplido: %70.62");
            cadena.Append(Environment.NewLine);
            cadena.Append("Proyectado: $708 millones");
            cadena.Append(Environment.NewLine);
            cadena.Append("Faltante: $208 millones");
            return cadena.ToString();
        }
    }
}