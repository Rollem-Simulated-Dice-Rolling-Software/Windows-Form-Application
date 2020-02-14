using System;

namespace SimulatedDiceRolling
{
    public class Die
    {
        public Die(int sides)
        {
            Sides = sides;
        }

        public int Sides 
        { 
            get;
            private set; 
        }
    }
}
