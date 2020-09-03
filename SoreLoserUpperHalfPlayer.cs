using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who always rolls in the upper half of their possible role and
    //  who throws an exception when they lose to the other player
    public class SoreLoserUpperHalfPlayer : Player 
    {
        public override int Roll(int opponentRoll) 
        {
            int myRoll;
            int bestHalf = (DiceSize / 2);

            do {
                myRoll = new Random().Next(DiceSize) + 1;
            } while (myRoll < bestHalf);

            if (opponentRoll >= myRoll) {
                throw new Exception($"What a shame.");
            } else {
                return myRoll;
            }
        }

        public override void Play(Player other)
        {
            int myRoll = Roll(1);
            int otherRoll = other.Roll(myRoll);

            Console.WriteLine($"{Name} rolls a {myRoll}");

            Console.WriteLine($"{other.Name} rolls a {otherRoll}");
            if (myRoll > otherRoll) {
                Console.WriteLine($"> {Name} wins!");
            } else if (myRoll < otherRoll) {
                throw new Exception("This is jolly rotten :(");
            } else {
                Console.WriteLine("Tie :(");
            }
        }
    }
}
