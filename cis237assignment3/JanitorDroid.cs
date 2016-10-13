// Alyssa Strand
// The JanitorDroid class is a sub-class of the UtilityDroid class.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class JanitorDroid : UtilityDroid
    {
            // Backing fields:
        bool _trashCompactor;
        bool _vacuum;
        decimal _totalCost;

        public decimal TotalCost
        {
            get { return _totalCost; }
            set { _totalCost = value; }
        }

            // Empty constructor:
        public JanitorDroid() : base() { }

            // 3 string and 5 bool constructor:
        public JanitorDroid(string model, string material, string color, bool toolbox, bool computer, bool arm, bool trash, bool vacuum) :
            base(model, material, color, toolbox, computer, arm)
        {
            _trashCompactor = trash;
            _vacuum = vacuum;

            CalculateTotalCost();
        }

            // Method to override ToString():
        public override string ToString()
        {
            return base.ToString() + " " + _trashCompactor + " trash compactor " + _vacuum + " vacuum";
        }

            // Method to override CalculateTotalCost():
        public override void CalculateTotalCost()
        {
                // Call the parent method to set its total cost:
            base.CalculateTotalCost();

                // Add the parent's total cost to the current cost:
            this._totalCost = base.TotalCost;

                // Add the following charges if they have the corresponding accessories:
            if (_trashCompactor)
            {
                this._totalCost += 400m;
            }
            if (_vacuum)
            {
                this._totalCost += 300m;
            }
        }

    }
}
