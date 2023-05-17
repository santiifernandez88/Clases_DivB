using System.Drawing;

namespace Clase4_B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bicicleta unaBici0 = new Bicicleta((Colores)101, "Jose", 26);

            Bicicleta unaBici1 = new Bicicleta((Colores)102, "Maria", 26);

            Bicicleta unaBici2 = new Bicicleta((Colores)103, "Pablo", 26);

            unaBici0.acelerar();
            Console.WriteLine("**********");
            Bicicleta.acelerar(unaBici2);

            if(unaBici0  == unaBici1) 
            {
                Console.WriteLine("Son iguales");
            }
            else
            {
                Console.WriteLine("No son iguales");
            }

            int suma = unaBici1 + unaBici0;
            Console.WriteLine("La suma de los rodados: {0}", suma);

            /*Console.WriteLine(unaBici.ToString());
            Console.WriteLine(Bicicleta.Fecha);*/

            Sumar(5, 9, 7);
            Sumar(1, 5);
            Sumar("HOLA", "MUNDO");
            
        }

        public static void Sumar(int n, int b)
        {
            Console.WriteLine(n + b);
        }

        public static void Sumar(int n, int b, int a)
        {
            Console.WriteLine(n + b + a);
        }

        public static string Sumar(String cadena1, String cadena2)
        {
            return cadena1 + cadena2;
        }

        //Para que un metodo se sobrecargue tienen que tener los mismos parametros
        //Si tienen distintos parametros, no se sobrecargan

    }
}