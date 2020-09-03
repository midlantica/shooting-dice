using System;
using System.Linq.Expressions;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player that throws an exception when they lose to the other player
    // Where might you catch this exception????
    public class SoreLoserPlayer : Player
    {
        public override int Roll(int opponentRoll) 
        {
            int myRoll = new Random().Next(DiceSize) + 1;
            if (opponentRoll >= myRoll) {
                throw new Exception("What a crying shame!");
            } else {
                //Console.WriteLine("sssssssssssssssssss");
                return myRoll;
            }
        }

        public override void Play(Player other)
        {
            int myRoll = Roll(1);
            int otherRoll = other.Roll(myRoll);

            Console.WriteLine ($"{Name} rolls a {myRoll}");

            Console.WriteLine ($"{other.Name} rolls a {otherRoll}");
            if (myRoll > otherRoll) {
                Console.WriteLine ($"> {Name} wins!");
            } else if (myRoll < otherRoll) {
                throw new Exception("Dagnabit");
            } else {
                // if the rolls are equal it's a tie
                Console.WriteLine ("Tie");
            }
        }
    }
}