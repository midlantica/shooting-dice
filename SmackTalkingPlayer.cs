using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer : Player
    {
        public string Taunt { get; set; }

        public override int Roll(int opponentRoll) 
        {
            Console.WriteLine(Taunt);
            return new Random().Next(DiceSize) + 1;
        }
    }
}