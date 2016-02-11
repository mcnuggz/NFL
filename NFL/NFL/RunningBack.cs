using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFL
{
    public class RunningBack : Player
    {
        Random r;
        private int _rushingAttempts;
        private int _rushingYards;
        private int _rushingTDs;

        public RunningBack(string name, int jerseyNumber, Grouping group, int age, float weight, int rushingAttempts, int rushingYards, int rushingTouchdowns) : base(name, jerseyNumber, group, age, weight)
        {
            this.RushingAttempts = rushingAttempts;
            this.RushingYards = rushingYards;
            this.RushingTouchdowns = rushingTouchdowns;
            r = new Random();
        }
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

        public void Score()
        {
            Console.WriteLine("Touchdown!");
            _rushingTDs++;
        }
    }
}
