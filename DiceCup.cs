using System;
using System.Collections.Generic;
using System.Text;

namespace SimulatedDiceRolling
{
    public class DiceCup : List<Die>
    {
        private Random randomNumberGenerator = new Random();
        public int LastDiceRollTotal;

        public DiceCup()
        {
            LastDiceRollTotal = 0;
        }

        /// <summary>
        /// Shake allows for repeated rolls
        /// Creates a new Random Number generator with given seed
        /// </summary>
        /// <param name="randomNumberSeed"></param>
        public void Shake(int randomNumberSeed)
        {
            randomNumberGenerator = new Random(randomNumberSeed);
        }

        /// <summary>
        /// Roll simulates rolling all dice that are contained in the cup
        /// LastDiceRollTotal is affected
        /// </summary>
        /// <returns>An Array of simulated roll for each die</returns>
        public int[] Roll()
        {
            LastDiceRollTotal = 0;
            int[] dieRollResults = new int[this.Count];
            for (int dieNumber = 0; dieNumber < dieRollResults.Length; ++dieNumber)
            {
                dieRollResults[dieNumber] = randomNumberGenerator.Next(1, this[dieNumber].Sides);
                LastDiceRollTotal += dieRollResults[dieNumber];
            }
            return dieRollResults;
        }
    }
}
