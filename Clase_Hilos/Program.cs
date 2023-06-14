using System.Collections.Concurrent;

namespace Clase_Hilos
{
    public class Contador
    {
        public int Id { get; set; }
    }
    internal class Program
    {
        public static Task<int> Tarea1() // el int en el generic es el tipo de retorno que le das
        {
            return Task<int>.Run(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine($"Tarea1. hilo id = {Thread.CurrentThread.ManagedThreadId}");

                return 1;
            }); // otra forma de hacer lo de abajo 

            /*Task<int> tarea1 = new Task<int>(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine($"Tarea1. hilo id = {Thread.CurrentThread.ManagedThreadId}");

                return 1;
            });
        
            tarea1.Start();

            return tarea1;*/
        }
       
        public static Task<int> RandomAsync(ConcurrentStack<int> stack, int numero) 
        {
            return Task<int>.Run(() =>
            {
                int min = 100;
                int max = 3000;
                var random = new Random().Next(min, max);
                Thread.Sleep(random);
                //contador.Id = numero;
                stack.Push(numero);
                stack.Push(numero);
                stack.Push(numero);

                return random;
            });
        }

        public static Task<int> RandomAsync(ConcurrentStack<int> stack, int numero, Action<int> collback)
        {
            return Task<int>.Run(() =>
            {
                int min = 100;
                int max = 3000;
                var random = new Random().Next(min, max);
                Thread.Sleep(random);
                //contador.Id = numero;
                stack.Push(numero);
                stack.Push(numero);
                stack.Push(numero);

                collback(random);

                return random;
            });
        }

        static async Task Main(string[] args)
        {
            Console.WriteLine($"Main. hilo id = {Thread.CurrentThread.ManagedThreadId}");

            ConcurrentStack<int> ints = new ConcurrentStack<int>();

             _ = RandomAsync(ints, 1, (numero) =>
            {
                Console.WriteLine(numero);
            });
            
            var contador = new Contador();
            var listaRandom = new Task<int>[5];

            listaRandom[0] = RandomAsync(ints, 0);
            listaRandom[1] = RandomAsync(ints, 1);
            listaRandom[2] = RandomAsync(ints, 2);
            listaRandom[3] = RandomAsync(ints, 3);
            listaRandom[4] = RandomAsync(ints, 4);

            Task.WaitAll(listaRandom);

            foreach (var item in ints)
            {
                Console.WriteLine($"Item = {item.ToString()}");
            }

            //Task.WaitAll(listaRandom);
            /*var contador = new Contador();
            var listaRandom = new Task<int>[5];

            listaRandom[0] = RandomAsync(contador, 0);
            listaRandom[1] = RandomAsync(contador, 1);
            listaRandom[2] = RandomAsync(contador, 2);
            listaRandom[3] = RandomAsync(contador, 3);
            listaRandom[4] = RandomAsync(contador, 4);

            Task.WaitAll(listaRandom);

            await RandomAsync(contador, 0);
            await RandomAsync(contador, 1);
            await RandomAsync(contador, 2);
            await RandomAsync(contador, 3);
            await RandomAsync(contador, 4);

            Console.WriteLine($"Contador.Id = {contador.Id}");

            foreach (Task<int> i in listaRandom)
            {
                Console.WriteLine(i.Result);
            }*/

            /*var listaTareas = new Task<int>[5];
            for (int i = 0; i < listaTareas.Length; i++)
            {
                listaTareas[i] = Tarea1();
            }
            Task.WaitAll(listaTareas);

            foreach (Task<int> i in listaTareas)
            {
                Console.WriteLine(i.Result);
            }

            int numeroAsync = await Tarea1();
            //numeroAsync = await Tarea1();
            //numeroAsync = await Tarea1();

            Console.WriteLine($"numeroAsync: {numeroAsync}");*/

            //Task tarea1 = new Task(Tarea1()); // la otra de metodo lambda
            /* Task tarea1 = new Task(() =>
             {
                 Thread.Sleep(3000);
                 Console.WriteLine($"Tarea1. hilo id = {Thread.CurrentThread.ManagedThreadId}");
             });

             tarea1.Start();

             Console.WriteLine("Pre wait");

             tarea1.Wait();

             Console.WriteLine("Post wait");*/
        }
    }
}