using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Archivos
{
    [Serializable]
    public class Administrativo : Empleado
    {
        bool haceHome;
        int diasVacaciones;

        public Administrativo() 
        {
            
        }

        public Administrativo(string nombre, float salario, bool haceHome, int diasVacaciones) : base(nombre, salario)
        {
            this.HaceHome = haceHome;
            this.DiasVacaciones = diasVacaciones;
        }

        public bool HaceHome { get => haceHome; set => haceHome = value; }
        public int DiasVacaciones { get => diasVacaciones; set => diasVacaciones = value; }

        public override string ToString()
        {
            return base.ToString() + $" -- Home: {this.haceHome} -- Dias: {this.diasVacaciones}";
        }

    }
}
