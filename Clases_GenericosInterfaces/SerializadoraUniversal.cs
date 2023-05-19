using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Clases_GenericosInterfaces
{
    internal class SerializadoraUniversal<T> //where T : ISerializable 
    {
        private string _pathfile;
        public SerializadoraUniversal(string pathFile) 
        {
            _pathfile = pathFile;
        }

        public M Leer<M>()
        {
            M lista;
            try
            {
                using (StreamReader sr = new StreamReader(_pathfile))
                {
                    XmlSerializer des = new XmlSerializer(typeof(M));
                    lista = (M)des.Deserialize(sr);
                    
                }
            
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message); 
            }

            return lista;
        }

        public void Escribir<M>(M queSerializar)
        {
            try 
            {
                using (StreamWriter sw = new StreamWriter(_pathfile))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(M));
                    ser.Serialize(sw, queSerializar);


                }
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);   
            }
            
        }

    }
}
