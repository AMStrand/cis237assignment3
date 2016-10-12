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
        public AddDroid(DroidCollection droidCollection)
        {
            string model = "";
            string materialType = "";
            string colorChoice = "";
            
            while (model == "")
            {
                Console.WriteLine();
                Console.WriteLine("Current options for model are Protocol, Utility, Janitor and Astromech.");
                Console.Write("Please enter the model type: ");

                model = Console.ReadLine();

                if (!model.ToUpper().Equals("PROTOCOL") && !model.ToUpper().Equals("UTILITY") && 
                    !model.ToUpper().Equals("JANITOR") && !model.ToUpper().Equals("ASTROMECH"))
                {
                    Console.WriteLine();
                    Console.WriteLine("That model was not valid.  Please spell the model the same as the option listed.");
                    model = "";
                }
            }

            while (materialType == "")
            {
                Console.WriteLine();
                Console.WriteLine("Current options for material are Steel, Aluminum, and Plastic.");
                Console.Write("Please enter the material type: ");

                materialType = Console.ReadLine();

                if (!materialType.ToUpper().Equals("STEEL") && !materialType.ToUpper().Equals("ALUMINUM") &&
                    !materialType.ToUpper().Equals("PLASTIC"))
                {
                    Console.WriteLine();
                    Console.WriteLine("That material type was not valid.  Please spell the material the same as the option listed.");
                    materialType = "";
                }
            }

            while (colorChoice == "")
            {
                Console.WriteLine();
                Console.WriteLine("Current options for color are Red, Blue, and Gray.");
                Console.Write("Please enter the color choice (case sensitive): ");

                colorChoice = Console.ReadLine();

                if (!colorChoice.ToUpper().Equals("RED") && !colorChoice.ToUpper().Equals("BLUE") &&
                    !colorChoice.ToUpper().Equals("GRAY"))
                {
                    Console.WriteLine();
                    Console.WriteLine("That color was not valid.  Please spell the color name the same as the option listed.");
                    colorChoice = "";
                }
            }

            switch (model.ToUpper())
            {
                case "PROTOCOL":
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
                                // To make sure that the pricing is completed correctly, put in the model name directly, 
                                // and make lowercase and remove spacing from the material and color:
                            droidCollection.add("Protocol", materialType.Trim().ToLower(), colorChoice.Trim().ToLower(), numberOfLanguages);
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
                case "UTILITY":
                    break;
                case "JANITOR":
                    break;
                case "ASTROMECH":
                    break;
                default:
                    Console.WriteLine("You did not enter a valid model.");
                    break;
            }

        }

    }
}
