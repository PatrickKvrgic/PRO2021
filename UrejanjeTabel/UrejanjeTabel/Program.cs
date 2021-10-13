using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrejanjeTabel
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            string[] a = new string[n];
            DateTime d = DateTime.Now;
            DateTime d1 = DateTime.Now;
            TimeSpan ts = d1 - d;
           
            d = DateTime.Now;
            Quicksort(0, a.Length - 1, a);
            d1 = DateTime.Now;
            ts = d1 - d;
            Console.WriteLine("čas za QuickSort je \t" + ts.TotalMilliseconds + " ms");
            Console.ReadLine();
        }
        static void Izbiranje(int[] a)
        {
            for(int k = 0; k < a.Length; k++)
            {
                //poišči minimum
                int min = a[k];
                int minIndex = k;
                for(int j = k; j < a.Length; j++)
                {
                    if (a[j] < min)
                    {
                        min = a[j];
                        minIndex = j;
                    }
                }
                //zamenjaj k-ti in najmanjši element
                int temp = a[k];
                a[k] = a[minIndex];
                a[minIndex] = temp;
                //Izpis(a);
            }
        }

        static void Vstavljanje(int [] a)
        {
            for(int k = 1; k < a.Length; k++)
            {
                int j = k;
                int temp = a[k];
                while(j > 0 && a[j - 1] > temp)
                {
                    a[j] = a[j - 1];
                    j--;
                }
                a[j] = temp;
                //Izpis(a);
            }
        }

        static void Izpis(string[] a)
        {
            for (int k = 0; k < a.Length; k++)
            {
                Console.Write(a[k] + "\t");
            }
            Console.WriteLine();
        }

        static int Pivot(int zač, int konec, string[] tab)
        {
            string p = tab[zač];
            int m = zač;
            int n = konec + 1;
            //pišči z m prvega, ki je večji od p
            do
            {
                m = m + 1;
            }
            while (tab[n].CompareTo(p) <= 0 && n < m);
            do
            {
                n = n - 1;
            }
            while (tab[m].CompareTo(p) >= 0 && m > n && m >= n);
            //tab[m] je večji od p
            //tab[n] je manjši od p
            //zamenjaj jih
            while (m < n)
            {
                string temp = tab[m];
                tab[m] = tab[n];
                tab[n] = temp;
                do
                {
                    m = m + 1;
                }
                while (tab[m].CompareTo(p) <= 0);
                do
                {
                    n = n - 1;
                }
                while (tab[n].CompareTo(p) > 0);
            }
            //zamenjaj pivotni element, z elementom tab[n]
            string temp2 = tab[n];
            tab[n] = tab[zač];
            tab[zač] = temp2;
            Izpis(tab);
            return n;
        }

        static void Quicksort(int zač, int konec, string[] tab)
        {
            if (zač >= konec)
                return;
            int a = Pivot(zač, konec, tab);
            Quicksort(zač, a - 1, tab);//levi del
            Quicksort(a + 1, konec, tab);//desni del
        }
    }
}
