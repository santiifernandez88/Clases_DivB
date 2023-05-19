using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_GenericosInterfaces
{
    internal class Lectura<T> where T : IFigura  // se puede class // new() 
    {
        protected List<T> _lista;

        /// <summary>
        /// Lee un archivo y devuelve una lista
        /// </summary>
        public List<T> LeerArchivo()
        {
            return new List<T>();
        }

        /*public List<M> LeerArchivo2<M>() // para este metodo no es necesario tener la clase generica
        {
            return new List<M>();
        }*/

    }
}
