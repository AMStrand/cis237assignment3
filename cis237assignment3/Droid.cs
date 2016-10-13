// Alyssa Strand
// The Droid class is built on the IDroid interface, and it is also the class upon which
// all the different droid types are based.  It contains the most basic droid information.
// It is abstract as instances of it cannot be created, as it does not contain enough info.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    abstract class Droid : IDroid
    {
            // Backing field declarations:
        private string _model;
        private string _material;
        private string _color;
        private decimal _baseCost;
        private decimal _totalCost;

            // Properties:
        public decimal TotalCost
        {
            get { return _baseCost; }
            set { _baseCost = value; }
        }

            // Empty constructor:
        public Droid() { }

            // 3 string parameters constructor:
        public Droid(string model, string material, string color)
        {
            _model = model;
            _material = material;
            _color = color;

            CalculateBaseCost();

            CalculateTotalCost();
        }

            // Method to override the default ToString():
        public override string ToString()
        {
            return _model + " " + _material + " " + _color;
        }

            // Method to calculate the base cost based on the model, material, and color costs:
        public void CalculateBaseCost()
        {
                // Set the base cost to 0:
            _baseCost = 0;

                // Add to base cost depending on model:
            switch (_model)
            {
                case "Protocol":
                    _baseCost += 600m;
                    break;
                case "Utility":
                    _baseCost += 700m;
                    break;
                case "Janitor":
                    _baseCost += 850m;
                    break;
                case "Astromech":
                    _baseCost += 1200m;
                    break;
            }

                // Add to base cost depending on material:
            switch (_material)
            {
                case "steel":
                    _baseCost += 500m;
                    break;
                case "aluminum":
                    _baseCost += 400m;
                    break;
                case "plastic":
                    _baseCost += 300m;
                    break;
            }

                // Add to base cost depending on color:
            switch (_color)
            {
                case "red":
                    _baseCost += 150m;
                    break;
                case "blue":
                    _baseCost += 100m;
                    break;
                case "gray":
                    _baseCost += 50m;
                    break;
            }
        }

        // Abstract method for calculating the total cost:
        public abstract void CalculateTotalCost();
    }
}
