using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFL
{
    public class League
    {
        public static List<Team> teamList = new List<Team>();

        public static void AddToLeague(Team team)
        {
            teamList.Add(team);
        }
    }
}
