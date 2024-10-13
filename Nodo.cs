using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas_consola
{
    internal class Nodo
    {
        private double estatura;
        private Nodo siguiente;

        public double Estatura { get => estatura; set => estatura = value; }
        internal Nodo Siguiente { get => siguiente; set => siguiente = value; }
    }
}
