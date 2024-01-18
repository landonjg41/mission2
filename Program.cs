using mission2;
using System;
namespace mission2
{
    class DiceSimulator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.Write("How many dice rolls would you like to simulate? ");
            int totalRolls = Convert.ToInt32(Console.ReadLine());

            int[] results = DiceRoller.RollDice(totalRolls);
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine($"Total number of rolls = {totalRolls}.");

            for (int i = 2; i <= 12; i++)
            {
                Console.Write($"{i}: ");
                int percentage = (int)((double)results[i] / totalRolls * 100);
                Console.WriteLine(new String('*', percentage));
            }

            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }
    }

}