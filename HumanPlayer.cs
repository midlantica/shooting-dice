using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override int Roll (int opponentRoll) 
        {
            int roll;
            string response;
            do 
            {
                Console.Write($"Enter your roll > ");
                response = Console.ReadLine();
            }
            while (int.TryParse (response, out roll) == false);

            return roll;
        }
    }
}