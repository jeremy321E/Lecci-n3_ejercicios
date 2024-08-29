using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lección3_Ejercicio3
{
    public class Program
    {
        static void Main(string[] args)
        {
            CuentaAhorro cuentaAhorro = new CuentaAhorro("Luis", 2000, 0.03);
            CuentaCorriente cuentaCorriente = new CuentaCorriente("Ana", 1000, 500);

            cuentaAhorro.MostrarSaldo();
            cuentaAhorro.Depositar(500);
            cuentaAhorro.AplicarInteres();

            cuentaCorriente.MostrarSaldo();
            cuentaCorriente.Retirar(1200);
            cuentaCorriente.Retirar(500);

            Console.ReadKey();
        }
    }
}
