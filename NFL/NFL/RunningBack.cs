using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace NFL
{
    public class RunningBack : Player
    {
        #region member variables and getsetters
        Random r;
        private int _rushingAttempts;
        private int _rushingYards;
        private int _rushingTDs;
        public int RushingAttempts
        {
            get
            {
                return _rushingAttempts;
            }
            set
            {
                _rushingAttempts = value;
            }
        }
        public int RushingYards
        {
            get
            {
                return _rushingYards;
            }
            set
            {
                _rushingYards = value;
            }
        }
        public int RushingTouchdowns
        {
            get
            {
                return _rushingTDs;
            }
            set
            {
                _rushingTDs = value;
            }
        }
        #endregion
        public RunningBack(string name, int jerseyNumber, Grouping group, int age, float weight, double rating, int rushingAttempts, int rushingYards, int rushingTouchdowns) : base(name, jerseyNumber, group, age, weight, rating)
        {
            this.RushingAttempts = rushingAttempts;
            this.RushingYards = rushingYards;
            this.RushingTouchdowns = rushingTouchdowns;
        }

        public override void Rush()
        {
            r = new Random();
            int result = r.Next(1, 3);
            if (result == 1)
            {
                Console.WriteLine("He breaks through the defense!");
                _rushingAttempts++;
                _rushingYards++;

                Thread.Sleep(2000);
                int forTD = r.Next(1, 4);
                if (forTD == 4)
                {
                    Score();
                }
            }

            else if (result == 2)
            {
                Console.WriteLine("Ooo, brought down by the other teams defense!");
                _rushingAttempts++;
            }

            else if (result == 3)
            {
                Console.WriteLine("Ball is loose! Fumble, fumble!");
                _rushingAttempts++;
            }
            
        }

        public void Score()
        {
            Console.WriteLine("Touchdown!");
            _rushingTDs++;
        }
        public static List<Player> operator +(RunningBack player, Team team)
        {
            if (!team.roster.playerList.Contains(player))
            {
                team.roster.playerList.Add(player);
            }

            team.WriteToFile("../../GreenBayPackersRoster.txt");
            return team.roster.playerList;

        }
        public static List<Player> operator -(RunningBack player, Team team)
        {
            if (team.roster.playerList.Contains(player))
            {
                team.roster.playerList.Remove(player);
            }
            Console.WriteLine(player.Name + " removed from " + team.Name);
            team.WriteToFile("../../GreenBayPackersRoster.txt");
            return team.roster.playerList;
        }
    }
}
