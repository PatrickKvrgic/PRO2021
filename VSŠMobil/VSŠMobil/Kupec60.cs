using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSŠMobil
{
    class Kupec60:Kupec
    {
        private int višjaTarifaPorebljeno; //koliko od 60min je že porabljeno
        public new void BeležiKlic(int minute, int tip)
        {
            switch (tip)
            {
                case 1:
                    stanje += minute * 0.2m;
                    break;
                case 2:
                    //prvih 60min po 0.05
                    //vse ostale po 0.01
                    int vMinute, nMinute;
                    int šeVMinute = (višjaTarifaPorebljeno < 60) ? 60 - višjaTarifaPorebljeno : 0;
                    if (minute > šeVMinute)
                    {
                        vMinute = šeVMinute;
                        nMinute = minute - vMinute;
                    }
                    else
                    {
                        vMinute = minute;
                        nMinute = 0;
                    }
                    stanje += vMinute * 0.05m + nMinute * 0.01m;
                    višjaTarifaPorebljeno += vMinute;
                    break;
            }
        }
    }
}
