using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Clase_Archivos
{
    internal class SerJason
    {
        public static bool EscribirEnJson(string rutaArchivo, List<Empleado> lista)
        {
            try
            {
                string json = JsonConverter.SerializeObject(lista,Newtonsoft.Json.Formattin,Indented):
                File.WriteAllText(rutaArchivo, json);
                return true;
            }
            catch(Exception ex) 
            {
                return false;            
            }
        }

        public static List<Empleado> LeerDesdeJson()
        {

        }


    }
}
