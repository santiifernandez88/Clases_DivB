using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4_B
{
    internal class Bicicleta
    {
        private Colores _color;
        private String _dueño;
        private int _rodado;
        private static DateTime _fecha;

        static Bicicleta() //Constructores estatico no reciben parametros
        {
            _fecha = DateTime.Now;
            Console.WriteLine("Inicializando... ");
        }

        #region "Propiedades"
        public Colores Color { get { return _color; } }
        public String Dueño { get { return _dueño; } }
        public int Rodado { get { return _rodado; } }
        public static DateTime Fecha { get { return _fecha; } }

        #endregion 

        public Bicicleta(Colores color, string dueño, int rodado) : this(dueño, rodado)
        {
            _color = color;
        }

        public Bicicleta(String dueño, int rodado) : this(dueño) //Constructores en cascada -- SOBRECARGA
        {
            _rodado = rodado;
        }

        public Bicicleta(String dueño)
        {
            _dueño = dueño;
        }

        //Sobre escribimos el metodo ToString
        public override string ToString()
        {
            return _dueño + " " + _rodado + " " + _color;
        }

        public void acelerar()
        {
            Console.WriteLine($"{this._dueño} esta andando: ");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Cambio: N°{i}");
            }
        }

        public void acelerar(int cambio)
        {
            for (int i = 1; i <= cambio; i++)
            {
                Console.WriteLine($"Cambio: N°{i}");
            }
        }

        public static void acelerar(Bicicleta unaBicicleta)
        {
            unaBicicleta.acelerar(10);
        }

        public static bool operator ==(Bicicleta unaBici, Bicicleta otraBici)
        {
            bool resultado = false;

            if (unaBici._rodado == otraBici._rodado && unaBici._dueño == otraBici._dueño && unaBici._color == otraBici._color)
            {
                resultado = true;
            }

            return resultado;
        }
        
        public static bool operator !=(Bicicleta unaBici, Bicicleta otraBici)
        {
            return !(unaBici == otraBici);
        }

        public static int operator +(Bicicleta unaBici, Bicicleta otraBici)
        {
            return unaBici._rodado + otraBici._rodado;
        }
    }
}