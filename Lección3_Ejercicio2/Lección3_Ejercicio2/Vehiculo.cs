using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lección3_Ejercicio2
{
    public class Vehiculo : IConducible
    {
        private string marca;
        private string modelo;

        public Vehiculo(string marca, string modelo)
        {
            this.marca = marca;
            this.modelo = modelo;
        }

        public virtual void Conducir()
        {
            Console.WriteLine($"Conduciendo un {marca} {modelo}.");
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Marca: {marca}, Modelo: {modelo}");
        }
    }
}
