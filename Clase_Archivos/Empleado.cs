using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Clase_Archivos
{
    [Serializable]
    [XmlInclude(typeof(Cadete))] // si o si en la clase padre
    [XmlInclude(typeof(Administrativo))] // esto es pq no registra la herencia como la conocemos
    public abstract class Empleado
    {
        string nombre;
        float salario;

        public Empleado() // si o si para que poder leer un empleado de un archivo xml 
        { 
        
        
        }

        public Empleado(string nombre, float salario)
        {
            this.Nombre = nombre;
            this.Salario = salario;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public float Salario { get => salario; set => salario = value; }

        public override string ToString()
        {
            return $"{this.nombre} -- {this.salario}";
        }



    }
}
