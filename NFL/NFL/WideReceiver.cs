using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFL
{
    public class WideReceiver : Player
    {
        private int _receptions;
        private int _receivingYards;
        private int _receivingTDs;
        public int Receptions
        {
            get
            {
                return _receptions;
            }
            set
            {
                _receptions = value;
            }
        }
        public int ReceivingYards
        {
            get
            {
                return _receivingYards;
            }
            set
            {
                _receivingYards = value;
            }
        }
        public int ReceivingTouchdowns
        {
            get
            {
                return _receivingTDs;
            }
            set
            {
                _receivingTDs = value;
            }
        }
        public WideReceiver(string name, int jerseyNumber, Grouping group, int age, float weight, double rating, int receptions, int receivingYards, int receivingTouchdowns) : base(name, jerseyNumber, group, age, weight, rating)
        {
            this.Receptions = receptions;
            this.ReceivingYards = receivingYards;
            this.ReceivingTouchdowns = receivingTouchdowns;
        }

        public static List<Player> operator +(WideReceiver player, Team team)
        {
            if (!team.roster.playerList.Contains(player))
            {
                team.roster.playerList.Add(player);
            }
            team.WriteToFile("../../GreenBayPackersRoster.txt");
            return team.roster.playerList;

        }
        public static List<Player> operator -(WideReceiver player, Team team)
        {
            if (team.roster.playerList.Contains(player))
            {
                team.roster.playerList.Remove(player);
            }
            team.WriteToFile("../../GreenBayPackersRoster.txt");
            return team.roster.playerList;
        }

    }
}
