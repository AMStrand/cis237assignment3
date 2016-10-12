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

        public DroidCollection()
        {
                // Instantiate the current index at 0 upon class creation:
            currentIndex = 0;
        }

        public void add(string model, string material, string color, int languages)
        {
            droids[currentIndex++] = new ProtocolDroid(model, material, color, languages);
        }

        public void add(string model, string material, string color, bool toolbox, bool computer, bool arm)
        {

        }

        public void add(string model, string material, string color, bool toolbox, bool computer, bool arm, bool trash, bool vacuum)
        {

        }

        public void add(string model, string material, string color, bool toolbox, bool computer, bool arm, bool extinguish, int ships)
        {

        }

        public string GetAllDroidsString()
        {
            string allOutput = "";

            foreach (Droid droid in droids)
            {
                if (droid != null)
                {
                    if (droid.GetType() == typeof(ProtocolDroid))
                    {
                        allOutput += ((ProtocolDroid)droid).ToString() + " " + ((ProtocolDroid)droid).TotalCost.ToString("C2") + Environment.NewLine;
                    }
                    else
                    {
                        if (droid.GetType() == typeof(UtilityDroid))
                        {

                        }
                        else
                        {
                            if (droid.GetType() == typeof(JanitorDroid))
                            {

                            }
                            else
                            {

                            }
                        }
                    }
                }
            }

            return allOutput;
        }

    }
}
