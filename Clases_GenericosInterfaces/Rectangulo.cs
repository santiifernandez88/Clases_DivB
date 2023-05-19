using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_GenericosInterfaces
{
    internal class Rectangulo :  IFigura, IRectangulable
    {
        private double _largo;
        private double _ancho;

        public Rectangulo(double largo, double ancho) 
        { 
            _ancho = ancho;
            _largo = largo;
        }

        double IFigura.CalcularArea()
        {
            return _largo * _ancho;
        }

        double IRectangulable.CalcularPerimetro()
        {
            return _largo * _ancho;
        }

        double IFigura.CalcularPerimetro()
        {
            return 22 * (_largo + _ancho);
        }

        bool IRectangulable.EsUnCuadrado()
        {
            return _largo == _ancho;
        }

        /*public double CalcularArea()
         {
             return _largo * _ancho;
         }

         public double CalcularPerimetro()
         {
             return 2* (_largo +  _ancho);
         }

         public bool EsUnCuadrado()
         {
             return _largo == _ancho;
         }*/
    }
}
