using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Eventos
{
    public delegate void delegadoAuto(object sender, AutoEventArgs e);
    public class Auto
    {
        private string _marca;
        private double _combustible;
        private double _reserva;

        public event delegadoAuto ReservaCombustible;
        public event delegadoAuto SinCombustible;

        public Auto(string marca)
        {
            this._marca = marca;
            this.LlenarTanque();
        }

        public string Marca { get => _marca; set => _marca = value; }
        public double Combustible { get => _combustible; set => _combustible = value; }
        public double Reserva { get => _reserva; set => _reserva = value; }

        public void LlenarTanque()
        {
            this._combustible = 60;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine();
            sb.AppendLine("--Estado del auto--");
            sb.AppendLine("Marca: " + this.Marca);
            sb.AppendLine("Combustible: " + this.Combustible + " litros");
            sb.AppendLine("Reserva: " + this.Reserva + " litros");
            sb.AppendLine();

            return sb.ToString();
        }

        public void Conducir(int km)
        {
            double consumo = 1;
            int litrosViaje = km / 10;

            for(int i = litrosViaje; i >= 0; i--) 
            {
                this._combustible -= consumo;
                if(this._combustible > 0 && this._combustible <= 10)
                {
                    AutoEventArgs e = new AutoEventArgs();
                    e.CombustibleEnElTanque = this._combustible;
                    ReservaCombustible(this, e);
                }
                
                if(this._combustible >= 0)
                {

                }
            }
        }
    }
}
