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

        public void Shake(int randomNumberSeed)
        {
            randomNumberGenerator = new Random(randomNumberSeed);
        }

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
