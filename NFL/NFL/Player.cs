using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFL
{
    public class Player
    {
        #region member variables
        Team team ;
        private string _name;
        private int _jerseynumber;
        private int _age;
        private float _weight;
        private double _rating;
        private Grouping _group;
        #endregion
        public Player(string name, int jerseyNumber, Grouping group, int age, float weight)
        {
            this.Name = name;
            this.JerseyNumber = jerseyNumber;
            this.Group = group;
            this.Age = age;
            this.Weight = weight;
        }
        #region getsetters
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
        public int JerseyNumber
        {
            get
            {
                return _jerseynumber;
            }
            set
            {
                _jerseynumber = value;
            }
        }
        public Grouping Group
        {
            get
            {
                return _group;
            }
            set
            {
                _group = value;
            }
        }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }
        public float Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                _weight = value;
            }
        }
        public double Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                _rating = value;
            }
        }
        #endregion
        public virtual void Pass()
        {

        }

        public virtual void Rush()
        {

        }

        public virtual void Kick()
        {

        }
        
        public virtual void Block()
        {

        }
        public virtual void Catch()
        {
            Console.WriteLine("");
        }
        public override string ToString()
        {
            return String.Format("{0}: {1} - {2}| ", team.Name, Name, JerseyNumber);
        }
    }
}