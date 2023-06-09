namespace Clase_Eventos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto miAuto = new Auto("BMW");
            miAuto.ReservaCombustible += ManejadorReserva;

            miAuto.Conducir(500);

            Console.WriteLine(miAuto.Combustible);
        }

        static void ManejadorReserva(object sender, AutoEventArgs e)
        {
            string llenar;
            Console.WriteLine("Soy el " + ((Auto)sender).Marca + " y estoy con la reserva, solo quedan " + ((Auto)sender).Combustible + " litros de combustible");

            Console.WriteLine("Desea llenar el tanque? S/N");
            llenar = Console.ReadLine();
            Console.WriteLine();
            if(string.Compare(llenar, "S") == 0)
            {
                ((Auto)sender).LlenarTanque();
            }

        }

    }
}