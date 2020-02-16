using System;
using SimulatedDiceRolling;

namespace DiceTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rollem' Simulated Dice Rolling App");
            DiceCup cup = new DiceCup
            {
                new Die(10),
                new Die(12),
                new Die(6)
            };

            // cup.GenerateKnownRoll(1);

            int[] dieResults = cup.Roll();
            Console.Write("Die Results: ");
            foreach(int result in dieResults)
            {
                Console.Write(result);
                Console.Write(" ");
            }
            Console.Write(" Total = ");
            Console.WriteLine(cup.LastDiceRollTotal);
        }
    }
}
