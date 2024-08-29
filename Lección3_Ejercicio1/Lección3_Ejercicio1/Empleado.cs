using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lección3_Ejercicio1
{
    public class Empleado:ICalculoSalario
    {
        private string nombre;
        private int edad;
        protected double salarioBase;

        public Empleado(string nombre, int edad, double salarioBase)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.salarioBase = salarioBase;
        }

        public virtual double CalcularSalario()
        {
            return salarioBase;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {nombre}, Edad: {edad}, Salario: {CalcularSalario()}");
        }
    }
}
