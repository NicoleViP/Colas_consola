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
                if (actual.Estatura == est)
                    actual = actual.Siguiente;
            }
            return true;
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
        public void Eliminar(double est)
        {
            if (pri == null) 
                Console.WriteLine ("La cola está vacía.");
            else pri = pri.Siguiente;
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
            Nodo actual = pri;
            double suma = 0;

            if (actual != null)
            {
                cantidad++;
                suma += actual.Estatura;
            }
            else Console.WriteLine("Cola vacía.");
            return cantidad;
        }

        /* public void Contar()
        {   
            NODO actual = pri;
            double suma = 0;
            int mayor = actual.Dato;

            while (actual != null)
            {
                cantidad++;
                suma += actual.Dato;
                if (actual.Dato > mayor) mayor = actual.Dato;
                actual = actual.Siguiente;
            }
            MessageBox.Show("La cola tiene: " + cantidad + "elementos " + "\nel mayor es: " + mayor);
        }*/

        public double Vistazo()
        {
            if (pri == null)
            {
                Console.WriteLine("Cola vacía");
            }
            else pri.Estatura;
            return pri.Estatura;
        }
        public double Final()
        {
            return ulti.Estatura;
        }
        public void Limpiar()
        {
            pri = null;
            ulti = null;
            cantidad = 0;
        }

    }
}

