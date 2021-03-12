using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace LumoNotificaciones.Models
{
    class NotificacionesSQLite
    {
        public NotificacionesSQLite()
        {
            try
            {
                if (!File.Exists("Notificaciones.sqlite"))
                {
                    SQLiteConnection.CreateFile("Notificaciones.sqlite");
                    string bitacora = "create table bitacora (mensaje varchar(500), fecha datetime)";

                    SQLiteConnection connection = Connection();
                    SQLiteCommand comando = connection.CreateCommand();
                    comando.CommandText = bitacora;
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {

            }
        }

        private SQLiteConnection Connection ()
        {
            SQLiteConnection sqLiteConnection;
            sqLiteConnection = new SQLiteConnection("Data Source=Notificaciones.sqlite; Version = 3; New = True; Compress = True; ");
            try
            {
                sqLiteConnection.Open();
                return sqLiteConnection;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool GuardarBitacora(string Mensaje, DateTime Fecha)
        {
            try
            {
                string bitacora = "insert into bitacora values ('" + Mensaje + "', '" + Fecha + "')";

                SQLiteConnection connection = Connection();
                SQLiteCommand comando = connection.CreateCommand();
                comando.CommandText = bitacora;
                comando.ExecuteNonQuery();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
