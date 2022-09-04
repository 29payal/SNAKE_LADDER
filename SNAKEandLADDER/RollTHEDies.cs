using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNAKEandLADDER
{
    internal class RollTHEDies
    {
        public static void RollDie()
        {
            int player1 = 0;
            Random random = new Random();
            player1 = random.Next(1, 6);
            Console.WriteLine("get the number: " +player1);
        }
    }
}