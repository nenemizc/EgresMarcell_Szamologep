using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dobos
{
    internal class Program
    {
        double Osszeadas(double a,double b)
        {
            return a + b;
        }

        double Kivonas(double a, double b)
        {
            return a - b;
        }

        double Osztas(double a, double b)
        {
            return a / b;
        }

        double Szorzas(double a, double b)
        {
            return a * b;
        }

        double Szazalek(double a, double b)
        {
            return Osztas(a,b)*100;
        }

        static void Main(string[] args)
        {
        }
    }
}
