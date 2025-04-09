using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            int suma;
            //Console.ReadKey();

            Console.Write("Ingrese numero 1: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese numero 2: ");
            numero2 = int.Parse(Console.ReadLine());
            Console.Write("La suma es: ");
            suma = numero1 + numero2;
            Console.WriteLine(suma);


        }
    }
}
