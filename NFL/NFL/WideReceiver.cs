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
        public WideReceiver(string name, int jerseyNumber, Grouping group, int age, float weight, int receptions, int receivingYards, int receivingTouchdowns) : base(name, jerseyNumber, group, age, weight)
        {
            this.Receptions = receptions;
            this.ReceivingYards = receivingYards;
            this.ReceivingTouchdowns = receivingTouchdowns;
        }
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
        
    }
}
