using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Clase_Archivos
{
    internal class Serializadora
    {
        public static void EscribirXML(string path, string file, List<Empleado> miEmpleado) // para una lista lo mismo pero con la lista
        {
            // podria hacer todas las validaciones
            using(StreamWriter sw = new StreamWriter(path+file)) 
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<Empleado>));
                ser.Serialize(sw, miEmpleado);  


            }
        }

        public static void LeerXML(string path)
        {
            List<Empleado> lectura;

            using(StreamReader sr = new StreamReader(path)) 
            {
                XmlSerializer des = new XmlSerializer(typeof(List<Empleado>));
                lectura = (List<Empleado>)des.Deserialize(sr);
            }
            foreach(Empleado e in lectura)
            {
                Console.WriteLine(e.ToString());
            }

           // Console.WriteLine(lectura.ToString());
        }


    }
}
