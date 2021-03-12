using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace LumoNotificaciones
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Verificar si ya existe un proceso para la aplicación y eliminar el más viejo si existe
            string procesoLUMO = Process.GetCurrentProcess().ProcessName;

            var procesosLUMO = Process.GetProcesses()
                .Where(p => p.ProcessName == procesoLUMO)
                .OrderBy(p => p.StartTime);

            if (procesosLUMO.Count() > 1)
                procesosLUMO.First().Kill();
                        
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
