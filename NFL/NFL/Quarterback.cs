using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace NFL
{
    public class Quarterback : Player
    {
        private int _attemptedPasses;
        private int _completedPasses;
        private decimal _passingPercentage;
        private decimal _passingRate;
        private int _passingTouchdowns;
        public Quarterback(string name, int jerseyNumber, Grouping group, int age, float weight, int attemptedPasses, int completedPasses) : base(name, jerseyNumber, group, age, weight)
        {
            this.AttemptedPasses = attemptedPasses;
            this.CompletedPasses = completedPasses;
            GetPassingPercentage(completedPasses, attemptedPasses);
        }
        public decimal PassingPercentage
        {
            get
            {
                return _passingPercentage;
            }
        }

        public decimal PassingRate
        {
            get
            {
                return _passingRate;
            }
            set
            {
                _passingRate = value;
            }
        }

        public int PassingTouchdowns
        {
            get
            {
                return _passingTouchdowns;
            }
            set
            {
                _passingTouchdowns = value;
            }
        }
        public int AttemptedPasses
        {
            get
            {
                return _completedPasses;
            }
            set
            {
                _completedPasses = value;
            }
        }
        public int CompletedPasses
        {
            get
            {
                return _attemptedPasses;
            }
            set
            {
                _attemptedPasses = value;
            }
        }

        public void StartPlay()
        {
            Console.WriteLine("Hut...hut...hike!");
            Thread.Sleep(3000);
            Pass();
        }
        public override void Pass()
        {
            Random r = new Random();
            int pass = r.Next(1, 3);
            if (pass == 1)
            {
                Console.WriteLine("He throws it deep, HAIL MARY!!");
                _completedPasses++;
                _attemptedPasses++;
                GetPassingRate();
                GetPassingPercentage(_attemptedPasses, _completedPasses);
            }
            else
            {
                Console.WriteLine("Pass incomplete");
                _completedPasses++;
                GetPassingRate();
                GetPassingPercentage(_attemptedPasses, _completedPasses);
            }          
        }

        private decimal GetPassingPercentage(decimal x, decimal y)
        {
            return _passingPercentage = x / y;
        }

        private decimal GetPassingRate()
        {
            //return _passingRate = (_totalCompletedPasses / 100) * _totalPasses;
            return _attemptedPasses / _completedPasses;
        }
    }
}
