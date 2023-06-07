namespace Clase_DelegadosLambda
{
    public delegate int SumarDelegate(int a, int b);
    public delegate int OrdenamientoPersonasDelegate(User user1, User user2);

    internal class Program
    {
        public static int Sumar(int a, int b) // la firma tiene que coincidir con el metodo delegado
        {
            return a + b;
        }

        public static int SumarOctal(int a, int b)
        {
            return (a + b) * 8;
        }

        public static int OrdenarPorNombre(User user1, User user2)
        {
            return user1.Nombre.CompareTo(user2.Nombre);
        }

        public static void MostrarLista(List<User> lista) 
        {
            foreach (User user in lista) 
            {
                Console.WriteLine(user);
            }
        
        }

        public static void OrdenarUsuarios(SumarDelegate func)// // OrdenamientoPersonasDelegate
        {
            int a = 1;
            int b = 2;
            
            func(a, b);
        }

        public delegate void DelegadoVoid();

        public static void Action1()
        {
            Console.WriteLine("Action 1");
        }
        public static void Action1(string asd)
        {
            Console.WriteLine("Action 1");
        }

        public static void Action1(int asd)
        {
            Console.WriteLine($"Action 1, numero: {asd}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Action<int> delegadoMulticast = n1 => {
                Console.WriteLine($"{n1} Delegado lambda");
            };

            delegadoMulticast += Action1;
            delegadoMulticast += Action1;

            delegadoMulticast(5);

            foreach(var delegado in  delegadoMulticast.GetInvocationList())
            {
                Console.WriteLine(delegado.Method.Name);
            }

            // Tres tipos de delegados
            // Action => void y puede recibir cualquier parametro
            // Func => retorna algo
            // Predicate => bool y recibe un parametro

            Action delegadoAction = Action1;           
            DelegadoVoid delegadoAction2 = Action1;

            Action<string> delegadoActionString = Action1;

            /* SumarDelegate sumarDel = new SumarDelegate(Sumar); // chequeo de tipos o seguridad de tipos

            SumarDelegate sumarDel = Sumar;

            int resultado = sumarDel(1, 2);

            Console.WriteLine($"Resultado: {resultado}");

            sumarDel = SumarOctal;

            resultado = sumarDel(1, 2);

            Console.WriteLine($"Resultado SumarOctal: {resultado}");

            List<User> users = new List<User>();

            users.Add(new User("Sofia", "Perez"));
            users.Add(new User("Mauro", "Perez"));
            users.Add(new User("Juan", "Perez"));
            users.Add(new User("Maria", "Perez"));
            users.Add(new User("Carlos", "Perez"));

            MostrarLista(users);
            Console.WriteLine("===================");
            //users.Sort(OrdenarPorNombre);
            users.Sort((user1, user2) => user1.Nombre.CompareTo(user2.Nombre)); // si se necesita mas 2 lineas de codigo se abren llaves

            //OrdenarUsuarios(users, (user1, user2) => user1.Nombre.CompareTo(user2.Nombre));
            Console.WriteLine("Lista ordenada");

            MostrarLista(users);

            OrdenarUsuarios((a, b) => a + b);
            OrdenarUsuarios((a, b) => a - b);
            OrdenarUsuarios((a, b) => a * b);*/


        }
    }
}