using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player whose role will always be in the upper half of their possible rolls
    public class UpperHalfPlayer : Player 
    {
        public override int Roll(int opponentRoll) 
        {
            // Return a random number between 1 and DiceSize
            int myRoll;
            int bestHalf = (DiceSize / 2);
            do {
                myRoll = new Random().Next (DiceSize) + 1;
            }
            while (myRoll < bestHalf);

            return myRoll;
        }
    }
}