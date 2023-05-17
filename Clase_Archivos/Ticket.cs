using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Archivos
{
    internal class Ticket
    {
        public static void ImprimirTicket(string path, string file)
        {
            string rutaCompleta = Path.Combine(path, file);
            //puedo verificar lo anterior sobre directorios y archivos
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Ticket numero: 45");
            sb.AppendLine("Fecha: " + DateTime.Now.ToString());
            sb.AppendLine("Importe: 5555");

            File.WriteAllText(rutaCompleta, sb.ToString());
        }

        public static string LeerTicket(string path)
        {
            string datos;

            datos = File.ReadAllText(path);

            return datos;
        }

    }
}
