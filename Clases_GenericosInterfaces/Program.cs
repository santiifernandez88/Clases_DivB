namespace Clases_GenericosInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lectura = new Lectura<IFigura>();
            lectura.LeerArchivo();

            var serializador  = new SerializadoraUniversal<List<Circulo>>("");

            var serializador2 = new SerializadoraUniversal<Circulo>("");

            serializador.Leer<List<Circulo>>();
            serializador.Leer<Circulo>();
            serializador.Escribir<string>("");
            serializador.Escribir<Circulo>(new Circulo(5));

            /*var circulo = new Circulo(5);
            var circuloGrande = new Circulo(15);
            var rectangulo = new Rectangulo(5, 10);
            var rectanguloGrande = new Rectangulo(15, 5);

            var lista = new List<IFigura>();
            lista.Add(circulo);
            lista.Add(circuloGrande);
            lista.Add(rectangulo);
            lista.Add(rectanguloGrande);

            foreach(var figura in lista)
            {
                Console.WriteLine($"Area: {figura.CalcularArea()}");
                Console.WriteLine($"Perimetro: {figura.CalcularPerimetro()}");

            }

            var rectangulos = new List<IRectangulable>();
            rectangulos.Add(rectangulo);
            rectangulos.Add(rectanguloGrande);

            foreach(var rectangulo1 in rectangulos)
            {
                var perimetroFigura = ((IFigura)rectangulo1).CalcularPerimetro();
                var perimetroRectangulo = ((IRectangulable)rectangulo1).CalcularPerimetro();

                Console.WriteLine($"Es un cuadrado de IFigura: {perimetroFigura}");
                Console.WriteLine($"Es un cuadrado de IRectangulable: {perimetroRectangulo}");*/
        }
        }
    }
}