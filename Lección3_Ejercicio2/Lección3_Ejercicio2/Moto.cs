using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lección3_Ejercicio2
{
    public class Moto : Vehiculo
    {
        private int cilindrada;

        public Moto(string marca, string modelo, int cilindrada)
            : base(marca, modelo)
        {
            this.cilindrada = cilindrada;
        }

        public override void Conducir()
        {
            Console.WriteLine($"Conduciendo una moto de {cilindrada} cc.");
        }
    }
}
