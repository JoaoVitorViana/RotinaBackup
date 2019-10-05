using System;
using System.Configuration;
using System.IO;

namespace RotinaBackup
{
    public class Rotina
    {
        public static void GerarBackup()
        {
            try
            {
                string pathy = ConfigurationManager.AppSettings["Local"];
                string destino = ConfigurationManager.AppSettings["Destino"];
                if (!Directory.Exists(destino))
                    Directory.CreateDirectory(destino);
                File.Copy(pathy, $"{destino}\\db{DateTime.Now.ToString("ddMMyyyy")}.mdf");
            }
            catch (Exception ex)
            {

            }
        }
    }
}