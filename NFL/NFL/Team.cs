using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFL
{
    public class Team 
    {
        Roster roster;
        private string _name;
        private int _points;
        private int _pointsAllowed;
        private int _touchdowns;
        private int _interceptions;
        private int _sacks;

        public Team()
        {

        }
        public Team(string name)
        {
            roster = new Roster();
            this.Name = name;
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
        public int PointsAllowed
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

    }
    
}