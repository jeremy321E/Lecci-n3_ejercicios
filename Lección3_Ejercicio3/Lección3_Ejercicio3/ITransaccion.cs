using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lección3_Ejercicio3
{
    public interface ITransaccion
    {
        void Depositar(double cantidad);
        void Retirar(double cantidad);
    }
}
