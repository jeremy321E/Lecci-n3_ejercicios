using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lección3_Ejercicio2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto("Toyota", "Corolla", 4);
            Moto moto = new Moto("Yamaha", "R3", 300);

            auto.MostrarInformacion();
            auto.Conducir();

            moto.MostrarInformacion();
            moto.Conducir();

            Console.ReadKey();
        }
    }
}
