using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_Model
{
    class Program
    {
        static void Main(string[] args)
        {
            Team team1 = new Team();
            team1.Coach= new Coach("Coach1", 61);
            Team team2 = new Team();
            team2.Coach = new Coach("Coach2", 25);

            team1.Players = new Footballplayer[]
      {
            new Striker("P1 Team1", 19, 1, 180),
            new Striker("P2 Team1", 21, 2, 172),
            new Striker("P3 Team1", 22, 3, 171),
            new Midfielder("P4 Team1", 20, 4, 195),
            new Midfielder("P5 Team1", 21, 5, 188),
            new Midfielder("P6 Team1", 22, 6, 184),
            new Defender("P7 Team1", 20, 7, 176),
            new Defender("P8 Team1", 21, 8, 175),
            new Defender("P9 Team1", 22, 9, 170),
            new Defender("P10 Team1", 20, 10, 183),
            new Goalkeeper("P11 Team1", 21, 11, 179),
        };
            team2.Players = new Footballplayer[]
{
            new Striker("P1 Team2", 19, 1, 180),
            new Striker("P2 Team2", 21, 2, 172),
            new Striker("P3 Team2", 22, 3, 171),
            new Midfielder("P4 Team2", 20, 4, 195),
            new Midfielder("P5 Team2", 21, 5, 188),
            new Midfielder("P6 Team2", 22, 6, 184),
            new Defender("P7 Team2", 20, 7, 176),
            new Defender("P8 Team2", 21, 8, 175),
            new Defender("P9 Team2", 22, 9, 170),
            new Defender("P10 Team2", 20, 10, 183),
            new Goalkeeper("P11 Team2", 21, 11, 179),
        };            

            Referee referee = new Referee("Referee 1", 40);
            Referee[] assistantrefs =
                {
                new Referee("Assistant Referee 1", 35),
                new Referee("Assistant Referee 2", 37)
            };
            int team1goals = 0;
            int team2goals = 0;

            //Премахнете коментарите за да има равенство
            Game game = new Game(team1, team2, referee, assistantrefs);

            Goal goal1team1 = new Goal(13, team1.Players[1]);
            team1goals++;
            Goal goal2team1 = new Goal(21, team1.Players[3]);
            team1goals++;
            Goal goal1team2 = new Goal(18, team2.Players[1]);
            team2goals++;
            //Goal goal2team2 = new Goal(26, team2.Players[3]);
            //team2goals++;

            if (team1.Players.Length > 10 && team1.Players.Length < 21 && team2.Players.Length > 10 && team2.Players.Length < 21)
            {
                if (team1goals > team2goals)
                {
                    Console.WriteLine("--------------------------------------");
                    game.Winner = ($"{team1.Coach.Name}'s team is the winner!");
                    Console.WriteLine(game.Winner);
                    Console.WriteLine();
                    Console.WriteLine($"Average Age of Team 1 is: {team1.AverageAge.ToString()}");
                    Console.WriteLine();
                    game.GameResult1(goal1team1, goal2team1);
                    Console.WriteLine("--------------------------------------");
                }
                if (team2goals > team1goals)
                {
                    Console.WriteLine("--------------------------------------");
                    game.Winner = ($"{team2.Coach.Name}'s team is the winner!");
                    Console.WriteLine(game.Winner);
                    Console.WriteLine();
                    Console.WriteLine($"Average Age of Team 2 is: {team2.AverageAge.ToString()}");
                    Console.WriteLine();
                    game.GameResult2(goal1team2/*, goal2team2*/);
                    Console.WriteLine("--------------------------------------");
                }
                if (team2goals == team1goals)
                {
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine("Game ended in a tie!");
                    Console.WriteLine($"Average Age of Team 1 is: {team1.AverageAge.ToString()}");
                    Console.WriteLine($"Average Age of Team 2 is: {team2.AverageAge.ToString()}");
                    game.Winner = null;
                    Console.WriteLine(game.Winner);
                    Console.WriteLine("--------------------------------------");
                }
            }
            else
            {
                Console.WriteLine("Not the right amount of players! (Must be between 11 and 22)");
            }
        }
    }
}