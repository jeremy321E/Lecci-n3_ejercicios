using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lección3_Ejercicio2
{
    public class Auto : Vehiculo
    {
        private int numeroPuertas;

        public Auto(string marca, string modelo, int numeroPuertas)
            : base(marca, modelo)
        {
            this.numeroPuertas = numeroPuertas;
        }

        public override void Conducir()
        {
            Console.WriteLine($"Conduciendo un auto de {numeroPuertas} puertas.");
        }
    }
}
