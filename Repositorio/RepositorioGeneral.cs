using System;
using System.Configuration;
using System.IO;

namespace LumoNotificaciones.Repositorio
{
    public class RepositorioGeneral
    {
        public string ObtenerConfigWebConfig(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        public bool GuardarVersion(string value)
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings["Version"].Value = value;
            configuration.Save();

            ConfigurationManager.RefreshSection("appSettings");

            return true;
        }
    }
}
