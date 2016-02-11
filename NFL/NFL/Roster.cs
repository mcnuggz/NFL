using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace NFL
{
    public class Roster : IEnumerable, IRead, IWrite
    {
        public static List<Player> playerList;
        private static List<string> tempList = new List<string>();
        private double _avgOverallRating;
        private double _avgAge;
        private double _avgWeight;
        public double AverageOverallRating
        {
            get
            {
                return _avgOverallRating;
            }
            set
            {
                _avgOverallRating = value;
            }
        }
        public double AverageAge
        {
            get
            {
                return _avgAge;
            }
            set
            {
                _avgAge = value;
            }
        }
        public double AverageWeight
        {
            get
            {
                return _avgWeight;
            }
            set
            {
                _avgWeight = value;
            }
        }
        public Roster()
        {
            playerList = new List<Player>();
        }
        public static List<Player> operator +(Player player, Roster roster)
        {
            if (!playerList.Contains(player))
            {
                playerList.Add(player);
            }
            return playerList;
        }
        public static List<Player> operator -(Player player, Roster roster)
        {
            if (playerList.Contains(player))
            {
                playerList.Remove(player);
            }
            return playerList;
        }

        public IEnumerator GetEnumerator()
        {
            foreach (Player player in playerList)
            {
                yield return player.Rating;
            }
        }

        public void PrintTopFive()
        {
            foreach (Player player in playerList)
            {
                for (int i = 1; i < 5; i++)
                {
                    Console.WriteLine(player.ToString());
                }
            }
        }

        public void ReadFile(string path)
        {
            int counter = 0;
            string line;
            using (StreamReader file = new StreamReader(path))
            {
                while ((line = file.ReadLine()) != null)
                {
                    tempList.Add(line);
                    counter++;
                }
            }
        }

        public  void WriteToFile(string path)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (Player player in playerList)
                {
                    writer.WriteLine(player.ToString());
                }
            }
        }
    }
}