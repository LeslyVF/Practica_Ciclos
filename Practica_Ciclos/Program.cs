using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Ciclos
{
    class Program
    {
        static double exponencial(int a, int b)
        {
            return Math.Pow(a, b);
        }
        static void Main(string[] args)
        {
            
            int exponente, b; 
                int n;

            Console.Write("favor de ingresar el valor de n:");
            n = int.Parse(Console.ReadLine());

            for(int x = 0; x < n; x++)
               {
                Console.Write("Favor de ingresar la base:");
                b = int.Parse(Console.ReadLine());

                Console.Write("Favor de ingresar el exponente:");
                exponente = int.Parse(Console.ReadLine());

                Console.Write(b + "Evelado a:" + exponente + " = " + exponencial(b, exponente));
               }
            Console.ReadKey();
        }
    }
}
