using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a1, a;
            Console.WriteLine("digite um número: ");
            a1= double.Parse(Console.ReadLine());

            a = a1 / 4;
            int a2;
            a2= (int)a;

            if (a == a2) 
            {
                Console.WriteLine("Número válido");
            }else
            {
                Console.WriteLine("Número inválido");
            }

            Console.ReadKey();
        }
    }
}
