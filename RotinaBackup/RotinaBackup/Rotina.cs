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
                string file = ConfigurationManager.AppSettings["File"];
                string destino = $"{ConfigurationManager.AppSettings["Destino"]}\\{DateTime.Now.ToString("ddMMyyyy")}";
                if (!Directory.Exists(destino))
                    Directory.CreateDirectory(destino);
                File.Copy($"{pathy}\\{file}", $"{destino}\\{file}");
            }
            catch (Exception ex)
            {

            }
        }
    }
}