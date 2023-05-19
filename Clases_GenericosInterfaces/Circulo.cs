using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_GenericosInterfaces
{
    internal class Circulo : IFigura
    {
        private double _radio;

        public Circulo(double radio) 
        {
            _radio = radio;
        }

        public double CalcularArea()
        {
            return Math.PI * _radio * _radio;
        }

        public double CalcularPerimetro()
        {
            return 2* Math.PI * _radio;
        }

    }
}
