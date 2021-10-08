using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanojskiStolpi
{
    class Program
    {
        static void Main(string[] args)
        {
            Premakni(3, "a", "c", "b");
            Console.ReadLine();
        }
        static void Premakni (int n, string začetni, string končni, string pomožni)
        {
            if (n == 1)
            {
                Console.WriteLine("Premakni iz " + začetni + " na " + končni + ".");
                return;
            }
            Premakni(n - 1, začetni, pomožni, končni); //1. from a to b, help with c
            Console.WriteLine("Premakni iz " + začetni + " na " + končni + ".");
            Premakni(n - 1, pomožni, končni, začetni);
        }
    }
}
