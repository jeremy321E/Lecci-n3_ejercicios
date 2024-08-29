using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lección3_Ejercicio1
{
    public class Gerente : Empleado
    {
        private double bono;

        public Gerente(string nombre, int edad, double salarioBase, double bono)
            : base(nombre, edad, salarioBase)
        {
            this.bono = bono;
        }

        public override double CalcularSalario()
        {
            return salarioBase + bono;
        }
    }
}
