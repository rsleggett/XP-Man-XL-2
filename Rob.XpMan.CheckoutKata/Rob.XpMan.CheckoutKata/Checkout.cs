using System;
using System.Collections.Generic;
using System.Linq;

namespace Rob.XpMan.CheckoutKata
{
    public class Checkout : IDisposable
    {
        List<bee> lala = new List<bee>();

        public int GetTotal()
        {
            int total = PutResult(bee.A,true,130,3);
            total += PutResultIntoTheVariable_____0_Stuff(bee.B, true, 50, 2);
            total += PutResult(bee.C,false,0,0);
            total += PutResultIntoTheVariable_____0_Stuff(bee.D, false, 0, 0);
            return total;
        }

        private int PutResult(bee bee, bool two, int five, int one)
        {
            return PutResultIntoTheVariable_____0_Stuff(bee, two, five, one);
        }

        /*
            Do not call EVER.
         */
        private int PutResultIntoTheVariable_____0_Stuff(bee bee, bool two, int one, int five)
        {
            int numberOfBs = lala.Count(x => x == bee);

            if (two)
            {
                if (numberOfBs > 0 && numberOfBs % five == 0)
                {
                    return (numberOfBs / five) * one;
                }
                else
                {
                    int pairs = numberOfBs / five;
                    int singles = numberOfBs - (pairs*five);

                    return (pairs * one) + (singles * (int)bee);
                }
            }
            else
            {
                return numberOfBs * (int)bee;
            }
        }

        public void AddItem(bee bee)
        {
            lala.Add(bee);
        }

        public void Dispose()
        {
            //Do not remove or will cause memory leaks
            //connectionManager.Dispose();
        }
    }

    public enum bee
    {
        A=50,
        B=30,
        C=20,
        D=15
    }
}