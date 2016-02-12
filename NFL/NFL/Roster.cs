using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace NFL
{
    public class Roster : IEnumerable
    {
        #region member variables and getsetters
        Team team;
        public List<Player> playerList;
        private static List<string> tempList = new List<string>();
        private double _avgOverallRating;
        private double _avgAge;
        private double _avgWeight;
        private float _totalWeight;
        private int _totalAge;
        private double _totalRating;
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
        #endregion
        public Roster()
        {
            playerList = new List<Player>();
        }

        public void UpdateList()
        {
            UpdateAvgAge();
            UpdateAvgWeight();
            UpdateOverallRating();
        }
        private double UpdateOverallRating()
        {
            foreach (Player player in playerList)
            {
                _totalRating += player.Rating;
            }
            return _avgOverallRating = _totalRating / playerList.Count;
        }
        private double UpdateAvgAge()
        {           
            foreach (Player player in playerList)
            {
                _totalAge += player.Age;
            }
            return _avgAge = _totalAge / playerList.Count;

        }
        private double UpdateAvgWeight()
        {
            foreach (Player player in playerList)
            {
                _totalWeight += player.Weight;
            }
            return _avgWeight = _totalWeight / playerList.Count;
        }
        public IEnumerator GetEnumerator()
        {
            foreach (Player player in playerList)
            {
                yield return player;
            }
        }
        public void PrintTopFive()
        {
            playerList.Sort(delegate (Player x, Player y)
            {
                return y.Rating.CompareTo(x.Rating);
            });

            List<Player> temp = playerList.OrderByDescending(i => i.Rating).Take(5).ToList();

            Console.WriteLine("Top Five" + Environment.NewLine);
            foreach (Player player in temp)
            {
                Console.WriteLine("{0} - #{1} | Rating: {2}", player.Name, player.JerseyNumber, player.Rating);
            }
            Console.WriteLine("Count: " + temp.Count);
        }


    }
}