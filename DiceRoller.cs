using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mission2
{
    internal class DiceRoller
    {
        public static int[] RollDice(int numberOfRolls)
        {
            int[] frequency = new int[13]; // Frequencies for sums 2-12
            Random random = new Random();

            for (int i = 0; i < numberOfRolls; i++)
            {
                int rollOne = random.Next(1, 7);
                int rollTwo = random.Next(1, 7);
                frequency[rollOne + rollTwo]++;
            }

            return frequency;
        }
    }
}




