using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lección3_Ejercicio3
{
    public class CuentaBancaria : ITransaccion
    {
        private string titular;
        protected double saldo;

        public CuentaBancaria(string titular, double saldoInicial)
        {
            this.titular = titular;
            this.saldo = saldoInicial;
        }

        public virtual void Depositar(double cantidad)
        {
            saldo += cantidad;
            Console.WriteLine($"Se depositaron {cantidad:C}. Saldo actual: {saldo:C}");
        }

        public virtual void Retirar(double cantidad)
        {
            if (cantidad <= saldo)
            {
                saldo -= cantidad;
                Console.WriteLine($"Se retiraron {cantidad:C}. Saldo actual: {saldo:C}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente.");
            }
        }

        public void MostrarSaldo()
        {
            Console.WriteLine($"Saldo de {titular}: {saldo:C}");
        }
    }
}
