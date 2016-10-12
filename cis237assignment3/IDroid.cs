// Alyssa Strand
// The interface IDroid is the building block for all instantiated droid classes, and it contains the 
// properties and methods that all classes that implement it must use.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    interface IDroid
    {
        void CalculateTotalCost();

        decimal TotalCost { get; set; }
    }
}
