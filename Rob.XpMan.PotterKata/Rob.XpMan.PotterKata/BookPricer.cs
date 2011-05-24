using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rob.XpMan.PotterKata
{
    public class BookPricer
    {
        public int Price(int[] bookIds)
        {
            return 8*bookIds.Length;
        }
    }
}
