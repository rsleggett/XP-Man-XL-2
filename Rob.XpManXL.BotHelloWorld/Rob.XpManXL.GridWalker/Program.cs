using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rob.XpManXL.GridWalker
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = Console.ReadLine();

            //"A0 - C2";
            Random random = new Random();
            string[] options = {"A0", "A1", "A2", "B0", "B1", "B2", "C0", "C1", "C2"};

            string move = options[random.Next()];

            while(move == value)
            {
                move = options[random.Next()];
            }

            Console.WriteLine(move);
        }
    }
}
