using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFL
{
    public class Team : IRead, IWrite
    {
        public Roster roster;
        private string _name;
        private int _points;
        private double _pointsAllowed;
        private int _touchdowns;
        private int _interceptions;
        private int _sacks;

        public Team()
        {

        }
        public Team(string name, int points, double pointsAllowed, int touchdowns, int interceptions, int sacks)
        {
            roster = new Roster();
            this.Name = name;
            this.Points = points;
            this.PointsAllowed = pointsAllowed;
            this.Touchdowns = touchdowns;
            this.Interceptions = interceptions;
            this.Sacks = sacks;
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public int Points
        {
            get
            {
                return _points;
            }
            set
            {
                _points = value;
            }
        }
        public double PointsAllowed
        {
            get
            {
                return _pointsAllowed;
            }
            set
            {
                _pointsAllowed = value;
            }
        }
        public int Touchdowns
        {
            get
            {
                return _touchdowns;
            }
            set
            {
                _touchdowns = value;
            }
        }
        public int Interceptions
        {
            get
            {
                return _interceptions;
            }
            set
            {
                _interceptions = value;
            }
        }
        public int Sacks
        {
            get
            {
                return _sacks;
            }
            set
            {
                _sacks = value;
            }
        }
        public void ReadFile(string path)
        {
            string line;
            int counter = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    counter++;
                }
            }
        }

        public void WriteToFile(string path)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine(Name);
                foreach (Player player in roster.playerList)
                {
                    writer.WriteLine("#{0} - {1}",player.JerseyNumber, player.Name);
                }
            }
        }
    }
    
}