// Alyssa Strand
// The DroidCollection class creates the Droid objects based on information sent from the AddDroid class,
// and it contains a public method to create an output string listing all the current droids.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class DroidCollection
    {

            // Instantiate a new array to hold all entered droids:
        IDroid[] droids = new Droid[9999];

            // Create a variable to hold the current index:
        int currentIndex;

            // Empty constructor:
        public DroidCollection()
        {
                // Instantiate the current index at 0 upon class creation:
            currentIndex = 0;
        }

            // Add method has 4 overloads - one for each droid type.  It will instantiate the appropriate droid type
            // and save that droid to the current place in the DroidCollection array:
        public void add(string model, string material, string color, int languages)
        {
            droids[currentIndex++] = new ProtocolDroid(model, material, color, languages);
        }

        public void add(string model, string material, string color, bool toolbox, bool computer, bool arm)
        {
            droids[currentIndex++] = new UtilityDroid(model, material, color, toolbox, computer, arm);
        }

        public void add(string model, string material, string color, bool toolbox, bool computer, bool arm, bool trash, bool vacuum)
        {
            droids[currentIndex++] = new JanitorDroid(model, material, color, toolbox, computer, arm, trash, vacuum);
        }

        public void add(string model, string material, string color, bool toolbox, bool computer, bool arm, bool fire, int ships)
        {
            droids[currentIndex++] = new AstromechDroid(model, material, color, toolbox, computer, arm, fire, ships);
        }

            // Method to put together the list of all the droids and return it as a string:
        public string GetAllDroidsString()
        {
                // Reset the output string to empty:
            string allOutput = "";

                // Enter loop... for each non-null droid:
            foreach (Droid droid in droids)
            {
                if (droid != null)
                {
                        // If it's a ProtocolDroid, call that ToString method and add on the TotalCost:
                    if (droid.GetType() == typeof(ProtocolDroid))
                    {
                        allOutput += ((ProtocolDroid)droid).ToString() + " " + 
                            ((ProtocolDroid)droid).TotalCost.ToString("C2") + Environment.NewLine;
                    }
                    else
                    {
                            // If it's a UtilityDroid, call that ToString method and add on the TotalCost:
                        if (droid.GetType() == typeof(UtilityDroid))
                        {
                            allOutput += ((UtilityDroid)droid).ToString() + " " + 
                                ((UtilityDroid)droid).TotalCost.ToString("C2") + Environment.NewLine;
                        }
                        else
                        {
                                // If it's a JanitorDroid, call that ToString method and add on the TotalCost:
                            if (droid.GetType() == typeof(JanitorDroid))
                            {
                                allOutput += ((JanitorDroid)droid).ToString() + " " + 
                                    ((JanitorDroid)droid).TotalCost.ToString("C2") + Environment.NewLine;
                            }
                            else
                            {
                                    // If it's an AstromechDroid (the only other type), call that ToString method and add on the TotalCost:
                                allOutput += ((AstromechDroid)droid).ToString() + " " +
                                    ((AstromechDroid)droid).TotalCost.ToString("C2") + Environment.NewLine;
                            }
                        }
                    }
                }
            }
                // Return the output string:
            return allOutput;
        }

    }
}
