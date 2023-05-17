using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4_B
{
    public enum Colores
    {
        Rojo=100,
        Azul,
        Amarillo,
        Verde,
        Negro
    }

    // FORMAS DE TRABAJAR CON UN ENUMERADO 

    /*foreach(Colores unColor in Enum.GetValues(typeof(Colores)))
    {
        Console.WriteLine(unColor);
    }*/

    /*Colores unColor;
    String color = "rojo";

    unColor = (Colores)Enum.Parse(typeof(Colores), color, true);

    Console.WriteLine(unColor);*/

    /*Colores unColor;
    int numeroColor = 2;
    unColor = (Colores)numeroColor;

    Console.WriteLine(unColor);*/

    /*Colores unColor = (Colores)103;

    switch(unColor) 
    {
        case Colores.Rojo:
            Console.WriteLine("Es rojo");
        break;
        default:
            Console.WriteLine("No es rojo");
        break;
    }*/
}
