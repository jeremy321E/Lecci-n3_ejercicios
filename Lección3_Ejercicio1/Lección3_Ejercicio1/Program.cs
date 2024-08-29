using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lección3_Ejercicio1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado("Juan", 30, 1000);
            Gerente gerente = new Gerente("María", 40, 1500, 500);

            empleado.MostrarInformacion();
            gerente.MostrarInformacion();

            Console.ReadKey();
        }
    }
}
