using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Excepciones
{
    internal class MyException : Exception
    {
        Object error;

        public MyException(string mensaje, Object objeto):base(mensaje) 
        { 
            this.error = objeto;
        }

        public Object Error
        {
            get 
            { 
                return this.error; 
            
            }
        }


    }
}
