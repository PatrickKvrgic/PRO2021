using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pravokotnik
{
    class Pravokotnik
    {
        private double širina;
        private double višina;
        private double ploščina;

        public Pravokotnik()
        {
            Širina = 0;
            Višina = 0;
        }

        public Pravokotnik(double š, double v)
        {
            Širina = š;
            Višina = v;
        }

        public double Širina { get => širina; set => širina = value; }
        public double Višina { get => višina; set => višina = value; }
        public double Ploščina { get => širina * višina; }

        public static bool operator ==(Pravokotnik p1, Pravokotnik p2)
        {
            return p1.Ploščina == p2.Ploščina;
        }
        public static bool operator >(Pravokotnik p1, Pravokotnik p2)
        {
            return p1.Ploščina > p2.Ploščina;
        }
        public static bool operator <(Pravokotnik p1, Pravokotnik p2)
        {
            return p1.Ploščina < p2.Ploščina;
        }
        public static bool operator >=(Pravokotnik p1, Pravokotnik p2)
        {
            return p1.Ploščina >= p2.Ploščina;
        }
        public static bool operator <=(Pravokotnik p1, Pravokotnik p2)
        {
            return p1.Ploščina <= p2.Ploščina;
        }
        public static bool operator !=(Pravokotnik p1, Pravokotnik p2)
        {
            return p1.Ploščina != p2.Ploščina;
        }


        public override string ToString()
        {
            return "Višina= " + višina + "\tŠirina= "+ širina;
        }
    }
}