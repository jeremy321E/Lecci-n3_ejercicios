using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lección3_Ejercicio3
{
    public class CuentaCorriente : CuentaBancaria
    {
        private double sobregiro;

        public CuentaCorriente(string titular, double saldoInicial, double sobregiro)
            : base(titular, saldoInicial)
        {
            this.sobregiro = sobregiro;
        }

        public override void Retirar(double cantidad)
        {
            if (cantidad <= saldo + sobregiro)
            {
                saldo -= cantidad;
                Console.WriteLine($"Se retiraron {cantidad:C}. Saldo actual: {saldo:C}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente incluso con sobregiro.");
            }
        }
    }
}
