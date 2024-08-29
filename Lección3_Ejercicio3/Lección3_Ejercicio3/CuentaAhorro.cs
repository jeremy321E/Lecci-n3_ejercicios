using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lección3_Ejercicio3
{
    public class CuentaAhorro : CuentaBancaria
    {
        private double interes;

        public CuentaAhorro(string titular, double saldoInicial, double interes)
            : base(titular, saldoInicial)
        {
            this.interes = interes;
        }

        public void AplicarInteres()
        {
            saldo += saldo * interes;
            Console.WriteLine($"Interés aplicado. Saldo actual: {saldo:C}");
        }
    }
}
