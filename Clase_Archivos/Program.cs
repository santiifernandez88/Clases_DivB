namespace Clase_Archivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StreamWriter sw = new StreamWriter("nombre.txt", true); // se abre // el true es para seguir escribiendo el false para sobreescribir o crear
            /*using (StreamWriter sw = new StreamWriter("nombre.txt")) // using bloque seguro de codigo // using un administrador contexto de codigo
            {
                sw.WriteLine("Mi nombre es german"); // se usa
                sw.WriteLine("Soy profe de utn");
            }*/

            //sw.Close(); // se cierra (Las tres claves de archivos)


            //string ruta = AppDomain.CurrentDomain.BaseDirectory; //opcion1 //Para abrir la carpeta del proyecto
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\mis_archivos\"; // para mandarlo donde quieras
            //string lectura;
            string nombre = "empleadito.xml";

            List<Empleado> lista = new List<Empleado>();

            lista.Add(new Cadete("Juan", 5000f, true));
            lista.Add(new Cadete("Luis", 75000f, false));
            lista.Add(new Administrativo("Maria", 9000f, false, 25));
            lista.Add(new Administrativo("Roberto", 5420f, false, 30));

            /*lista.Add(new Empleado("Juan", 5000f));
            lista.Add(new Empleado("Luis", 75000f));
            lista.Add(new Empleado("Maria", 9000f));
            lista.Add(new Empleado("Roberto", 5420f));*/


            try
            {
                /* Logger.EscribirTexto(ruta, "prueba.txt", "hola, soy german");
                 lectura = Logger.LeerTexto(ruta + "prueba.txt");
                 Console.WriteLine(lectura); */

                /*Ticket.ImprimirTicket(ruta, "ticket_mario.txt");
                Console.WriteLine(Ticket.LeerTicket(ruta + "ticket_mario.txt"));*/

                //Empleado nuevo = new Empleado("Juan", 8500f);

                //Serializadora.EscribirXML(ruta, nombre, nuevo);
                Serializadora.EscribirXML(ruta, nombre, lista);
                Serializadora.LeerXML(ruta + nombre); // no se hace la asquerosidad de los parametros

                SerJason.EscribirEnJson(ruta + nombre, lista);

                List<Empleado> nueva = SerJason.LeerDesdeJson(ruta + nombre);
                foreach(Empleado e in nueva)
                {
                    Console.WriteLine(e.ToString());
                }

            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);       
            }
            
            
                                                      
            //Console.WriteLine(ruta); // para ver por consola la ruta del archivo


        }
    }
}