using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dobos
{
    internal class Program
    {
        static double Osszeadas(double a,double b)
        {
            return a + b;
        }

        static double Kivonas(double a, double b)
        {
            return a - b;
        }

        static double Osztas(double a, double b)
        {
            return a / b;
        }

        static double Szorzas(double a, double b)
        {
            return a * b;
        }

        static double Szazalek(double a, double b)
        {
            return Osztas(a,b)*100;
        }

        static void Indit() 
        {
            Console.WriteLine("Kérem adja meg az első számot: ");
            double a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Kérem adja meg a második számot: ");
            double b = Double.Parse(Console.ReadLine());
            Console.WriteLine("Az elvégzendő művelet jele: ");
            string jel = Console.ReadLine();

            switch (jel) 
            { 
                case "+": Console.WriteLine($"{Osszeadas(a,b)}"); break;
                case "-": Console.WriteLine($"{Kivonas(a,b)}"); break;
                case "/": Console.WriteLine($"{Osztas(a,b)}"); break;
                case "*": Console.WriteLine($"{Szorzas(a,b)}"); break;
                case "%": Console.WriteLine($"{Szazalek(a,b)}%"); break;
                default: Console.WriteLine("huh?"); break;

            } 
        }

        static void Main(string[] args)
        {
            Indit();
            Console.ReadLine();
        }
    }
}
