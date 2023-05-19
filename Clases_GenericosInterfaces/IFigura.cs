using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_GenericosInterfaces
{
    internal interface IFigura
    {
        // no se pueden hacer atributos en un interfaz, si propiedades

        //Los metodos no pueden ser privados por el encapsulamiento, solamente publico

        public double CalcularArea();

        public double CalcularPerimetro();

       

    }
}
