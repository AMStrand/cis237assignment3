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
            // Backing fields:
        bool _toolbox;
        bool _computerConnection;
        bool _arm;
        decimal _totalCost;

            // Property:
        public decimal TotalCost
        {
            get { return _totalCost; }
            set { _totalCost = value; }
        }

            // Empty Constructor:
        public UtilityDroid() : base() { }

            // 3 string and 3 bool constructor:
        public UtilityDroid(string model, string material, string color, bool toolbox, bool computer, bool arm) :
            base(model, material, color)
        {
            _toolbox = toolbox;
            _computerConnection = computer;
            _arm = arm;

            CalculateTotalCost();
        }


            // Method to override the ToString method:
        public override string ToString()
        {
            return base.ToString() + " " + _toolbox + " toolbox " + _computerConnection + " computer " + _arm + " arm";
        }

            // Method to calculate the total cost:
        public override void CalculateTotalCost()
        {
                // Add the parent's total cost to the current total:
            this._totalCost = base.TotalCost;

                // Add other charges if they have the various accessories:
            if (_toolbox)
            {
                this._totalCost += 300m;
            }
            if (_computerConnection)
            {
                this._totalCost += 150m;
            }
            if (_arm)
            {
                this._totalCost += 250m;
            }
        }


    }
}
