using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_Model
{
    class Game
    {
        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
        public Referee Referee { get; set; }
        public Person[] AssistantRefs { get; set; }
        public string Winner { get; set; }

        public Game(Team team1, Team team2, Referee referee, Person[] assistantrefs)
        {
            Team1 = team1;
            Team2 = team2;
            Referee = referee;
            AssistantRefs = assistantrefs;
        }


        public void GameResult1(Goal goal1team1, Goal goal2team1)
        {
            Console.WriteLine("Results from the match: ");
            Console.WriteLine($"Goal! {goal1team1.Minute}' - {goal1team1.Player.Name}");
            Console.WriteLine($"Goal! {goal2team1.Minute}' - {goal2team1.Player.Name}");
        }
        //Премахнете коментарите за да има равенство
        public void GameResult2(Goal goal1team2/*, Goal goal2team2*/)
        {
            Console.WriteLine("Results from the match: ");
            Console.WriteLine($"Goal! {goal1team2.Minute}' + {goal1team2.Player.Name}");
            //Console.WriteLine($"Goal! {goal2team2.Minute}' + {goal2team2.Player.Name}");
        }
    }
    class Goal
    {
        public int Minute { get; set; }
        public Footballplayer Player { get; set; }
        public Goal(int minute, Footballplayer player)
        {
            Minute = minute;
            Player = player;
        }
    }
}