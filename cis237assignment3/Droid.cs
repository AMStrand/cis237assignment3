// Alyssa Strand
// The Droid class is built on the IDroid interface, and it is also the class upon which
// all the different droid types are based.  It contains the most basic droid information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Droid : IDroid
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
            get { return _totalCost; }
            set { _totalCost = value; }
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
                    _baseCost += 1000m;
                    break;
            }

                // Add to base cost depending on material:
            switch (_material)
            {
                case "Steel":
                    _baseCost += 500m;
                    break;
                case "Aluminum":
                    _baseCost += 400m;
                    break;
                case "Plastic":
                    _baseCost += 300m;
                    break;
            }

                // Add to base cost depending on color:
            switch (_color)
            {
                case "Red":
                    _baseCost += 150m;
                    break;
                case "Blue":
                    _baseCost += 100m;
                    break;
                case "Gray":
                    _baseCost += 50m;
                    break;
            }
        }

            // Method to calculate the total cost, which at this level is just the base cost:
        public virtual void CalculateTotalCost()
        {
            _totalCost = _baseCost;
        }
    }
}
