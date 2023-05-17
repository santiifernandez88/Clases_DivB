using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Archivos
{
    internal class Logger
    {
        public static void EscribirTexto(string path, string file, string texto)
        {
            
            try
            {
                if (!Directory.Exists(path)) // si no existe el directorio...
                {
                    Directory.CreateDirectory(path);
                }
                using (StreamWriter sw = new StreamWriter(path + file))
                {
                    sw.WriteLine(texto);
                }
            }
            catch
            {
                throw new Exception("Hubo un problema al intentar escribir en el archivo");
            }
            
        }

        public static string LeerTexto(string path)
        {
            StringBuilder sb = new StringBuilder();
            //string datos = null;
            string linea;

            using(StreamReader sr = new StreamReader(path)) // Abrir el archivo para lectura
            {
                //datos = sr.ReadToEnd();
                while ((linea = sr.ReadLine()) != null) 
                { 
                    sb.AppendLine(linea);
                
                }
            }

            return sb.ToString();
        }





    }
}
