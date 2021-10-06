using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RekurzijaVaja
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2 na 10 je "+PotencaIterativno(10));
            Console.WriteLine("2 na 10 je " + PotencaRekurzivno(10));
            Console.WriteLine("7 Fibonaccijevo stevilo je " + Fib(7));
            Console.WriteLine("5 stevilo je " + Vaja3(5));
            Console.ReadLine();
        }
        //Primer Iterativno
        static int PotencaIterativno(int n)
        {
            int potenca = 1;
            for (int c = 1; c <= n; c++)
            {
                potenca = 2 * potenca;
            }
            return potenca;
        }
        //Primer Rekurzija
        static int PotencaRekurzivno(int n)
        {
            if (n == 0)
                return 1;
            return 2 * PotencaRekurzivno(n - 1);
        }
        //Primer Fibonacci
        static int Fib(int n)
        {
            if (n == 1 || n == 2)
                return 1;
            return Fib(n - 1) + Fib(n - 2);
        }
        //Vaja 3
        static int Vaja3(int n)
        {
            if (n == 1 || n == 2)
                return 2;
            return Vaja3(n - 2) * Vaja3(n - 1) - 1;
        }
    }
}
