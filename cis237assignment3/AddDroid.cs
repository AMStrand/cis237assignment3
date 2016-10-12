// Alyssa Strand
// The AddDroid class handles the functions of adding a droid and creates objects in the corresponding classes.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class AddDroid
    {
        // Instantiate classes to be used:
        ProtocolDroid protocolDroid;
        UtilityDroid utilityDroid;
        JanitorDroid janitorDroid;
        AstromechDroid astromechDroid;

        public AddDroid()
        {
            Console.WriteLine();
            Console.WriteLine("Current options for model are Protocol, Utility, Janitor and Astromech.");
            Console.Write("Please enter the model type (case sensitive): ");

            string model = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Current options for material are Steel, Aluminum, and Plastic.");
            Console.Write("Please enter the material type (case sensitive): ");

            string materialType = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Current options for color are Red, Blue, and Gray.");
            Console.Write("Please enter the color choice (case sensitive): ");

            string colorChoice = Console.ReadLine();

            switch (model)
            {
                case "Protocol":
                        // Declare a variable to hold the # of languages and initialize to -1 for error checking:
                    int numberOfLanguages = -1;
                        // While the # of languages is less than 0 (an invalid option):
                    while (numberOfLanguages < 0)
                    {
                            // Prompt user for input:
                        Console.WriteLine();
                        Console.Write("Please enter the number of languages known (e.g. 0, 1, 2): ");

                            // Try to parse the input as an integer and save to the variable, must be >= 0:
                            // (setting the numberOfLanguages to a number greater than -1 will also exit the loop)
                        if (Int32.TryParse(Console.ReadLine(), out numberOfLanguages) && numberOfLanguages >= 0)
                        {
                                // Create a new Protocol Droid based on the specifications given:
                            protocolDroid = new ProtocolDroid(model, materialType, colorChoice, numberOfLanguages);
                            Console.WriteLine();
                            Console.WriteLine("Droid successfully entered!");
                            Console.WriteLine();
                        }
                        else
                        {       // Error message if input cannot be parsed as an int:
                            Console.WriteLine("Please enter an integer value only.");
                                // Make sure the loop will continue:
                            numberOfLanguages = -1;
                        }
                    }

                    break;
                case "Utility":
                    break;
                case "Janitor":
                    break;
                case "Astromech":
                    break;
                default:
                    Console.WriteLine("You did not enter a valid model.");
                    break;
            }

        }

    }
}
