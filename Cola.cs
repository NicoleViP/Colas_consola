using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Colas_consola
{
    internal class Cola
    {

        Nodo pri, ulti = null;
        int cantidad = 0;

        public Cola()
        {
            pri = null;
            ulti = null;
        }
        public void Insertar(double estat)
        {
            Nodo nuevo = new Nodo();
            nuevo.Estatura = estat;

            if (pri == null)
            {
                pri = nuevo;
                ulti = nuevo;
                ulti.Siguiente = null;
            }
            else
            {
                ulti.Siguiente = nuevo;
                ulti = nuevo;
                ulti.Siguiente = null;
            }
            cantidad++;
        }


        public bool Buscar(double est)
        {
            Nodo actual = pri;
            while (actual != null)
            {
                if (actual.Estatura == est) return true;

                    actual = actual.Siguiente;
            } 
            return false;
        }
        public void Modificar(double estact, double estanue)
        {
            Nodo actual = pri;

            while (actual != null)
            {
                if (actual.Estatura == estact)
                {
                    actual.Estatura = estanue;
                }
                actual = actual.Siguiente;
            }
        }
        public void Eliminar()
        {
            if (pri == null)
                Console.WriteLine("La cola está vacía.");
            else
            {
                pri = pri.Siguiente;
                Console.WriteLine("Número desencolado.");
            }
                cantidad--;
        }
        public void Listar()
        {
            Nodo actual = pri;

            if (pri != null)
            {
                while (actual != null)
                {
                    Console.WriteLine("{0}", actual.Estatura);
                    actual = actual.Siguiente;
                }
            }
            else
            {
                Console.WriteLine("Cola vacía");
            }
        }
        public int Contar()
        {
            if (pri == null)
            {
                Console.WriteLine("Cola vacía");
            }
            return cantidad;
        }
        public double Vistazo()
        {
            if (pri == null)
            {
                Console.WriteLine("Cola vacía");
                return -1; //devuelve un valor indicativo de que la cola está vacía;
            }
            else
            {
                Console.WriteLine("Primer elemento: {0} ", pri.Estatura);
            }
            return pri.Estatura;
        }
        public double Final()
        {
            if (pri == null)
            {
                Console.WriteLine("Cola vacía");
                return -1; //devuelve un valor indicativo de que la cola está vacía;
            }
            else
            {
                Console.WriteLine("Ultimo elemento: {0}", ulti.Estatura);
            }
            return ulti.Estatura;
        }
        public void Limpiar()
        {
            if (pri != null)
            {
                pri = null;
                ulti = null;
                cantidad = 0;
                Console.WriteLine("La cola se limpió.");
            }
            else Console.WriteLine("Cola vacía.");
        }

    }
}

