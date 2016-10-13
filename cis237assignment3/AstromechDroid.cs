// Alyssa Strand
// The AstromechDroid class is a sub-class of the UtilityDroid class.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class AstromechDroid : UtilityDroid
    {
            // Backing fields:
        bool _fireExtinguisher;
        int _numberOfShips;
        decimal _totalCost;

            // Property:
        public decimal TotalCost
        {
            get { return _totalCost; }
            set { _totalCost = value; }
        }

            // Empty constructor:
        public AstromechDroid() : base() { }

            // 3 string, 4 bool, 1 int constructor
        public AstromechDroid(string model, string material, string color, bool toolbox, bool computer, bool arm, bool fire, int ships) :
            base(model, material, color, toolbox, computer, arm)
        {
            _fireExtinguisher = fire;
            _numberOfShips = ships;

            CalculateTotalCost();
        }

            // Method to override the ToString():
        public override string ToString()
        {
            return base.ToString();
        }

            // Method to override the CalculateTotalCost():
        public override void CalculateTotalCost()
        {
                // Call the parent's total cost calculation method:
            base.CalculateTotalCost();
                // Set the current cost to the parent's total cost:
            this._totalCost = base.TotalCost;
                // If the droid has a fire extinguisher, add another charge:
            if (_fireExtinguisher)
            {
                this._totalCost += 400m;
            }
                // Add charges based on the number of ships:
            this._totalCost += (_numberOfShips * 200m);
        }
    }
}
