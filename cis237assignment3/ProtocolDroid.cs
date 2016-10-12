// Alyssa Strand
// The ProtocolDroid class is built on the Droid class.
// It has no sub-classes, but it is capable of having sub-classes.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class ProtocolDroid : Droid
    {
            // Declare backing fields:
        int _numberOfLanguages;
        decimal _totalCost;

            // Declare constant for the cost per language:
        const decimal COST_PER_LANGUAGE = 100m;

            // Properties:
        public decimal TotalCost
        {
            get { return _totalCost; }
            set { _totalCost = value; }
        }

            // Empty constructor:
        public ProtocolDroid() : base() { }

            // 3 string and 1 int parameter constructor:
        public ProtocolDroid(string model, string material, string color, int numLanguages) :
            base(model, material, color)
        {
            _numberOfLanguages = numLanguages;

            CalculateTotalCost();
        }

            // Method to override the base ToString():
        public override string ToString()
        {
            return base.ToString() + " " + _numberOfLanguages + " languages " + _totalCost.ToString("C");
        }

            // Method to calculate the total cost, using the parent's total cost plus the new features' costs:
        public override void CalculateTotalCost()
        {
            _totalCost = base.TotalCost + (_numberOfLanguages * COST_PER_LANGUAGE);
        }

    }
}
