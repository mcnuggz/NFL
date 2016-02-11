using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace NFL
{
    public class Quarterback : Player
    {
        #region member variables
        Random r;
        private bool _passCaught = false;
        private int _attemptedPasses;
        private int _completedPasses;
        private decimal _passingPercentage;
        private double _passingRate;
        private int _touchdowns;
        private int _interceptions;
        private int _passingYards;
        #endregion
        public Quarterback(string name, int jerseyNumber, Grouping group, int age, float weight, int attemptedPasses, int completedPasses, int touchdowns, int interceptions, int passingYards) : base(name, jerseyNumber, group, age, weight)
        {
            this.AttemptedPasses = attemptedPasses;
            this.CompletedPasses = completedPasses;
            this.TouchdownPasses = touchdowns;
            this.Interceptions = interceptions;
            this.PassingYards = passingYards;
            GetPassingPercentage(completedPasses, attemptedPasses);
            GetPassingRate(completedPasses, attemptedPasses, touchdowns, passingYards, interceptions);
        }
        #region getsetters
        public decimal PassingPercentage
        {
            get
            {
                return _passingPercentage;
            }
        }
        public double PassingRate
        {
            get
            {
                return _passingRate;
            }
        }
        public int PassingYards
        {
            get
            {
                return _passingYards;
            }
            set
            {
                _passingYards = value;
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
        public int TouchdownPasses
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
        public int AttemptedPasses
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
        public int CompletedPasses
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
        #endregion
        public void StartPlay()
        {
            Console.WriteLine("Hut...hut...hike!");
            Thread.Sleep(2000);
            Pass();
        }
        public override void Pass()
        {
            r = new Random();
            int pass = r.Next(1, 4);
            if (pass == 1)
            {
                Console.WriteLine("Looking for someone open...");
                Thread.Sleep(2000);
                Console.WriteLine("He throws it deep, HAIL MARY!!");
                _passCaught = true;
                _completedPasses++;
                _attemptedPasses++;
                GetPassingRate(_completedPasses, _attemptedPasses, _touchdowns, _passingYards, _interceptions);
                GetPassingPercentage(_attemptedPasses, _completedPasses);
            }
            else if (pass == 4)
            {
                Rush();
            }
            else
            {
                Console.WriteLine("Looking for someone open...");
                Thread.Sleep(2000);
                Console.WriteLine("Pass incomplete");
                _completedPasses++;
                GetPassingRate(_completedPasses, _attemptedPasses, _touchdowns, _passingYards, _interceptions);
                GetPassingPercentage(_attemptedPasses, _completedPasses);
            }          
        }

        public override void Rush()
        {
            Console.WriteLine("He dodges the blitz and heads up!");
        }
        private decimal GetPassingPercentage(decimal x, decimal y)
        {
            return _passingPercentage = x / y;
        }
        private double GetPassingRate(int value1, int value2, int value3, int value4, int value5)
        {
            double a = (value1 / value2 - 0.3) * 5;
            double b = (value4 / value2 - 3) * .25;
            double c = (value3 / value2) * 20;
            double d = 2.375 - (value5 / value2 * 25);
            _passingRate = (a + b + c + d / 6) * 100;
            return _passingRate;
        }
    }
}
