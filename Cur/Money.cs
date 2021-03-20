using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cur
{
    class Money
    {
        public const double k = 0.05;
        public int i = 0;
        public double ru;
        public double dol;
        public double how_m;
        public string combo;
        public double rate;

        public void update()
        {
            Random random = new Random();
            if ((combo == "Продать") && (dol > 0) && (dol - how_m > 0))
            {
                ru = ru + how_m * rate;
                
                dol = dol - how_m;
                

            }

            if ((combo == "Купить") && (ru > rate) && (ru - how_m * rate >= 0))
            {
                ru = ru - how_m * rate;
                
                dol = dol + how_m;
                

            }

            rate = rate * (1 + k * (random.NextDouble() - 0.5));
        }
    }
}
