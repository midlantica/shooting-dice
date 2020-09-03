using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who always roles one higher than the other player
    public class OneHigherPlayer : Player
    {
        public override int Roll(int opponentRoll)
        {
            return opponentRoll + 1;
        }

        public override void Play(Player other) 
        {
            int myRoll = Roll(1);
            int otherRoll = other.Roll(myRoll);
            Console.WriteLine($"{Name} rolls a {myRoll}");

            Console.WriteLine($"{Name} rolls a {otherRoll}");
            if (myRoll > otherRoll) {
                Console.WriteLine($"> {Name} wins!");
            } else if(myRoll < otherRoll) {
                Console.WriteLine($"> {other.Name} wins!");
            } else {
                Console.WriteLine($"Tie!");
            }
        }
    }
}