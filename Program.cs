using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas_consola
{
    internal class Program
    {
        public static Cola lacola = new Cola();
        static void Main(string[] args)
        {
            int op;

            do
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("Estatura de estudiantes");
                Console.WriteLine("-----------------------");
                Console.WriteLine("1. Insertar");
                Console.WriteLine("2. Buscar");
                Console.WriteLine("3. Modificar");
                Console.WriteLine("4. Eliminar");
                Console.WriteLine("5. Listar");
                Console.WriteLine("6. Contar");
                Console.WriteLine("7. Vistazo");
                Console.WriteLine("8. Final");
                Console.WriteLine("9. Limpiar");
                Console.WriteLine("10. Salir del programa");
                Console.WriteLine("-----------------------");
                Console.Write("Ingrese una opcion: ");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1: InsertarEdad(); Console.ReadKey(); Console.Clear(); break;
                    case 2: BuscarEdad(); Console.ReadKey(); Console.Clear(); break;                   
                    case 3: ModificarEdad(); Console.ReadKey(); Console.Clear(); break;
                    case 4: EliminarEdad(); Console.ReadKey(); Console.Clear(); break;
                    case 5: ListarEdad(); Console.ReadKey(); Console.Clear(); break;
                    case 6: ContarEdad(); Console.ReadKey(); Console.Clear(); break;
                    case 7: VistazoEdad(); Console.ReadKey(); Console.Clear(); break;
                    case 8: FinalEdad(); Console.ReadKey(); Console.Clear(); break;
                    case 9: LimpiarEdad(); Console.ReadKey(); Console.Clear(); break;
                    case 10: Console.WriteLine("Saliendo del programa."); break;
                    default: Console.WriteLine("Ingrese una opcion valida."); return;
                }
            } while (op != 10);
        }
        public static void InsertarEdad()
        {
            Console.Write("Ingrese la estatura: ");
            double esta = double.Parse(Console.ReadLine());
            lacola.Insertar(esta);
        }
        public static void BuscarEdad()
        {
            Console.Write("Ingrese la estatura a buscar: ");
            double esta = double.Parse(Console.ReadLine());
            if (lacola.Buscar(esta)) 
            {
                Console.Write("Estatura encontrada.");
            }
            else 
            { 
                Console.Write("Estatura no encontrada."); 
            }   
        }
        public static void ModificarEdad()
        {
                Console.Write("Ingrese estatura a modificar: ");
                double esta = double.Parse(Console.ReadLine());
            if (lacola.Buscar(esta))
            {
                Console.Write("Ingrese nueva estatura: ");
                double nuevaesta = double.Parse(Console.ReadLine());
                lacola.Modificar(esta, nuevaesta);
            }
            else Console.WriteLine("La estatura ingresada es incorrecta o no existe. Ingrese nuevamente.");        
        }
        public static void EliminarEdad()
        {
            Console.Write("Ingrese estatura a eliminar: ");
            double esta = double.Parse(Console.ReadLine());
            lacola.Eliminar(esta);
            Console.WriteLine("Estatura eliminada.");
        }
        public static void ListarEdad()
        {
            lacola.Listar();
        }
        public static void ContarEdad()
        {
            Console.WriteLine("La cola tiene " + lacola.Contar() + " elementos.");
        }
        public static void VistazoEdad()
        {
            lacola.Vistazo();
        }
        public static void FinalEdad()
        {
            lacola.Final();
        }
        public static void LimpiarEdad()
        {
            lacola.Limpiar();
        }
    }
}
