// Alyssa Strand
// The UtilityDroid class is built on the Droid class and has two sub-classes:
// JanitorDroid and AstromechDroid.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class UtilityDroid : Droid
    {
        bool _toolbox;
        bool _computerConnection;
        bool _arm;
        decimal _totalCost;

        public decimal TotalCost
        {
            get { return _totalCost; }
            set { _totalCost = value; }
        }

        public override void CalculateTotalCost()
        {
            throw new NotImplementedException();
        }


    }
}
