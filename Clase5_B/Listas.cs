using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Immutable;
using System.Security.Cryptography.X509Certificates;

namespace Clase5_B
{
    internal class Listas
    {

        public static void Colecciones()
        {
            Console.WriteLine("Colecciones");
            // Pilas();
            // Colas();
            // Diccionarios();
            // Inmutables();
            // Genericas();
            // NoGenericas();

           /* float c;
            c = 5; //implicito

            int t;
            t = (int)5.25; // explicito*/
        }


       /* public static explicit Dolar(Peso unPeso)
        {
            int valor;
            Dolar unDolar;
            valor = unPeso.cantidad / cotizizacion;
            unDolar = new Dolar(valor);

            return unDolar;
            
        } 

        public static implicit operator Peso(Dolar unDolar)
        {
            float valor;
            valor = unDolar.cantidad * 398;
            return new Peso(valor);
        }
       */

        public static void Pilas()
        {
            //LIFO
            Stack<string> stack = new Stack<string>();

            stack.Push("c");
            stack.Push("b");
            stack.Push("a");

            // stack.Pop();
            // stack.Clear();
            Console.WriteLine(stack.Peek());

            foreach (string item in stack)
            {
                Console.WriteLine(item);
            }
        } // sirve como una pila de x cosas
        public static void Colas()
        {
            //FIFO
            Queue<string> queue = new Queue<string>();

            queue.Enqueue("a");
            queue.Enqueue("b");
            queue.Enqueue("c");

            foreach (string item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------------");
            var borrado = queue.Dequeue(); //borra el ultimo elemento
            Console.WriteLine($"El elemento borrado es {borrado}");

            Console.WriteLine($"Elemento peek: {queue.Peek()}");// muestra el primer elemento

            foreach (string item in queue)
            {
                Console.WriteLine(item);
            }


        } // sirve para utilizar como si fuese una cola 
        public static void Diccionarios() 
        {
            var cds = new Dictionary<string, CD>();

            cds.Add("ACDC", new CD("Back in Black", "ACDC", 1982)); // las claves son unicas

            //Console.WriteLine(cds["Slayer"]); No seguro
            Console.WriteLine(cds["acdc"]);
            var agrego = cds.TryAdd("ACDC", new CD("Back in Black", "ACDC", 1982));

            if (agrego)
            {
                Console.WriteLine($"Se agrego");
            }
            else
            {
                Console.WriteLine("No se agrego");
            }

            var indiceUno = cds.ElementAt(1); // devuelve el elemento del indice

            foreach (KeyValuePair<string, CD> cd in cds)  // en la practica ponemos var
            {
                Console.WriteLine(cd.Key);
            }

            var rta = cds.TryGetValue("acddc", out var acdc);
            cds.ContainsKey("acdc");
            if (rta)
            {
                Console.WriteLine(acdc);
            }
            else
            {
                Console.WriteLine("No existe ACDC");
            }


            cds.Remove("acdc");
            cds.Clear();
        }  // es generica, se utiliza para guardar collecciones con una key
        public static void Inmutables() // son genericas tambien, sirven para no inmutar la coleccion 
        {
            var inmutable = ImmutableArray.Create<string>("a", "b", "c");
            
            var inmutable2 = inmutable.Add("a");

            foreach(var valor in inmutable)
            {
                Console.WriteLine(valor);
            }
            Console.WriteLine("-------------");
            foreach(var valor in inmutable2)
            {
                Console.WriteLine(valor);
            }
        }
        public static void Genericas()
        {
            List<CD> cds = new List<CD>();

            cds.Add(new CD("Titulo1", "Artista1", 2001));
            cds.Add(new CD("Titulo2", "Artista2", 2001));
            cds.Add(new CD("Titulo3", "Artista3", 2001));

            //Console.WriteLine($"{cds[1].Mostrar()}");

            foreach(CD c in cds) 
            {
                Console.WriteLine(c.artista);            
            }

            Console.WriteLine(" --------------------");
            cds.Sort(//una funcion que ordene en la clase cd);
            //cds.Reverse(); TIENE DIVERSAS FUNCIONES COMO EN LA LL

            foreach (CD c in cds)
            {
                Console.WriteLine(c.artista);
            }

        } // Son las mas faciles de manipular pq se puede hacer lo que quiera
        public static void NoGenericas()
        {
            Console.WriteLine("Colecciones no genericas");
            ArrayList listas = new ArrayList(); 

            listas.Add(1);
            listas.Add("Hola");
            listas.Add(new CD());

            foreach (var item in listas) 
            {
                var i = listas.IndexOf(item);
                Console.WriteLine(item);
            }
        }//No usamos 

        

    }
}
