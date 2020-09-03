using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootingDice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear ();

            Console.WriteLine("Shall we play a game");
            Console.WriteLine("====================");

            Player player1 = new Player();
            player1.Name = "Jason";

            Player player2 = new Player();
            player2.Name = "Tamara";

            player2.Play(player1);

            Console.WriteLine("-------------------");

            Player player3 = new Player();
            player3.Name = "Oliver";

            player3.Play(player2);

            Console.WriteLine("-------------------");

            HumanPlayer cheatmaster = new HumanPlayer () 
            {
                Name = "Chad"
            };

            SmackTalkingPlayer jimmy = new SmackTalkingPlayer () {
                Name = "Jimmy",
                Taunt = "\"You are more disappointing than an unsalted pretzel.\""
            };

            CreativeSmackTalkingPlayer smackster = new CreativeSmackTalkingPlayer () {
                Name = "Smackster",
                Taunts = new List<string> () {
                "\"Your abilities are too infant-like for doing much alone.\"",
                "\"More of your conversation would infect my brain.\"",
                "\"Your brain is as dry as the remainder biscuit after voyage.\""
                }
            };

            SoreLoserPlayer verucaSalt = new SoreLoserPlayer () {
                Name = "Veruca Salt"
            };

            OneHigherPlayer OneUpOnYou = new OneHigherPlayer () {
                Name = "John Onuponyou"
            };

            UpperHalfPlayer upperHalf = new UpperHalfPlayer () {
                Name = "Upper Half"
            };

            SoreLoserUpperHalfPlayer soreLoserUpperHalf = new SoreLoserUpperHalfPlayer () {
                Name = "Sore Loser Upper Half"
            };


            Player large = new LargeDicePlayer();
            large.Name = "Big Shot";

            player1.Play(large);

            Console.WriteLine("-------------------");

            List<Player> players = new List<Player>() {
                player1, 
                player2, 
                player3, 
                large, 
                jimmy, 
                OneUpOnYou,
                cheatmaster, 
                smackster, 
                verucaSalt,
                upperHalf,
                soreLoserUpperHalf
            };

            try { 
                PlayMany(players); 
            } catch {
                Console.WriteLine("\"I do not like you green eggs and ham!\"");
            }
        }

        static void PlayMany(List<Player> players)
        {
            Console.WriteLine();
            Console.WriteLine("Let's play a bunch of times, shall we?");

            // We "order" the players by a random number
            // This has the effect of shuffling them randomly
            Random randomNumberGenerator = new Random();
            List<Player> shuffledPlayers = players.OrderBy(p => randomNumberGenerator.Next()).ToList();

            // We are going to match players against each other
            // This means we need an even number of players
            int maxIndex = shuffledPlayers.Count;
            if (maxIndex % 2 != 0)
            {
                maxIndex = maxIndex - 1;
            }

            // Loop over the players 2 at a time
            for (int i = 0; i < maxIndex; i += 2)
            {
                Console.WriteLine("-------------------");

                // Make adjacent players play noe another
                Player player1 = shuffledPlayers[i];
                Player player2 = shuffledPlayers[i + 1];
                player1.Play(player2);
            }
        }
    }
}