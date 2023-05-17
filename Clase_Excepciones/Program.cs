namespace Clase_Excepciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listaEnteros = new List<int>();
            List<Object> listaObjects = new List<Object> {2, 6, 7, "Perro", 6, 3}; 

            try
            {
                CargarLista(listaEnteros, listaObjects);
            }
            catch(MyException e) 
            {
                Console.WriteLine(e.Message + "- Intento agregar el elemento {0} a una lista de enteros", e.Error.ToString());
            }
            finally
            {
                foreach(int i in listaEnteros)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void CargarLista(List<int> enteros, List<Object> objetos)
        {
            bool flag = false;
            Object unObjeto = null;

            foreach(Object o in objetos) 
            {
                if(o is int)
                {
                    enteros.Add((int)o);    
                }
                else
                {
                    flag = true;
                    unObjeto = o;                   
                }
            }

            if(flag)
            {
                throw new MyException("Error al intentar cargar la lista", unObjeto);
            }
        }

        /* try
             {
                 int entero = int.Parse("5");
                 int resultado = 10 / entero;
             }
             catch(FormatException ex)
             {
                 Console.WriteLine("Ocurrio una excepcion de formato");
             }
             catch(DivideByZeroException ex) 
             {
                 Console.WriteLine("No se puede dividir por cero");
             }
             catch(Exception ex) 
             {
                 Console.WriteLine("Un error inesperado ha ocurrido");
             }

            try
            {
                metodo1();
    }
            catch (Exception ex) 
            {
                //Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Message);
            }

        static void metodo1()
        {
            try
            {
                metodo2();
            }
            catch(Exception ex)
            {
                string mensaje;
                mensaje = ex.Message + "Error en metodo1";
                throw new Exception(mensaje, ex);
            }
            
        }
        static void metodo2()
        {
            try
            {
                metodo3();
            }
            catch(Exception ex)
            {
                string mensaje;
                mensaje = ex.Message + "Error en metodo2";
                throw new Exception(mensaje, ex);
            }
            
        }
        static void metodo3()
        {
            throw new Exception("Excepcion genereada en metodo3");
        }*/
    }
}