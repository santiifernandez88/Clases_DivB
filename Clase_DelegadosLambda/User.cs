using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_DelegadosLambda
{
    public class User
    {
        string nombre;

        string apellido;

        public User(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }

        public override string ToString()
        {
            return $"{Nombre} - {Apellido})";
        }
    }
}
