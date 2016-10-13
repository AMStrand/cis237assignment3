// Alyssa Strand
// The AddDroid class obtains information from the user and sends that to the DroidCollection class to create Droid objects.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class AddDroid
    {
            // Class-level variables for the common utility functions:
        bool toolbox;
        bool computerConnection;
        bool arm;

            // Constructor for the AddDroid class:
        public AddDroid(DroidCollection droidCollection)
        {
                // Declare variables and set blank for error checking purposes:
            string model = "";
            string materialType = "";
            string colorChoice = "";
            
                // While the model is still blank:
            while (model == "")
            {
                    // Prompt for model type:
                Console.WriteLine();
                Console.WriteLine("Current options for model are Protocol, Utility, Janitor and Astromech.");
                Console.Write("Please enter the model type: ");
                    // Save model type:
                model = Console.ReadLine();
                    // Check for correct spelling - allows for any casing and extra spacing:
                if (!model.ToUpper().Equals("PROTOCOL") && !model.ToUpper().Equals("UTILITY") && 
                    !model.ToUpper().Equals("JANITOR") && !model.ToUpper().Equals("ASTROMECH"))
                {
                        // If spelled wrong, output error message and reset model to blank so the process loops again:
                    Console.WriteLine();
                    Console.WriteLine("That model was not valid.  Please spell the model the same as the option listed.");
                    model = "";
                }
            }

                // While the material is still blank:
            while (materialType == "")
            {
                    // Prompt for material type:
                Console.WriteLine();
                Console.WriteLine("Current options for material are Steel, Aluminum, and Plastic.");
                Console.Write("Please enter the material type: ");
                    // Save material type:
                materialType = Console.ReadLine();
                    // Check for correct spelling - allows for any casing and extra spacing:
                if (!materialType.ToUpper().Equals("STEEL") && !materialType.ToUpper().Equals("ALUMINUM") &&
                    !materialType.ToUpper().Equals("PLASTIC"))
                {
                        // If spelled wrong, output error message and reset material to blank so the process loops again:
                    Console.WriteLine();
                    Console.WriteLine("That material type was not valid.  Please spell the material the same as the option listed.");
                    materialType = "";
                }
            }

                // While the model is still blank:
            while (colorChoice == "")
            {
                    // Prompt for color:
                Console.WriteLine();
                Console.WriteLine("Current options for color are Red, Blue, and Gray.");
                Console.Write("Please enter the color choice (case sensitive): ");
                    // Save color:
                colorChoice = Console.ReadLine();
                    // Check for correct spelling - allows for any casing and extra spacing:
                if (!colorChoice.ToUpper().Equals("RED") && !colorChoice.ToUpper().Equals("BLUE") &&
                    !colorChoice.ToUpper().Equals("GRAY"))
                {
                        // If spelled wrong, output error message and reset color to blank so the process loops again:
                    Console.WriteLine();
                    Console.WriteLine("That color was not valid.  Please spell the color name the same as the option listed.");
                    colorChoice = "";
                }
            }

                // Enter switch statement to check the model type and continue questions by group:
            switch (model.ToUpper())
            {
                    // If the model type is Protocol:
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

                    // If the model type is Utility:
                case "UTILITY":
                        // Call the common utility questions method:
                    UtilityQuestions();
                        // Call the add method of the DroidCollection class:
                    droidCollection.add("Utility", materialType.Trim().ToLower(), colorChoice.Trim().ToLower(), 
                        toolbox, computerConnection, arm);
                    Console.WriteLine();
                    Console.WriteLine("Droid successfully entered!");
                    Console.WriteLine();
                    break;

                    // If the model type is Janitor:
                case "JANITOR":
                        // Call the common utility questions method:
                    UtilityQuestions();

                        // Janitor specific questions - prompt user for input, if y or Y, save the
                        // corresponding variable as true, else false:
                    Console.WriteLine();
                    Console.Write("Does the droid have a trash compactor (Y for yes) ? ");
                    bool trash;
                    if (Console.ReadLine().ToUpper() == "Y")
                    {
                        trash = true;
                    }
                    else
                    {
                        trash = false;
                    }

                    Console.WriteLine();
                    Console.Write("Does the droid have a vacuum (Y for yes) ? ");
                    bool vacuum;
                    if (Console.ReadLine().ToUpper() == "Y")
                    {
                        vacuum = true;
                    }
                    else
                    {
                        vacuum = false;
                    }

                        // Call the add method of the DroidCollection class:
                    droidCollection.add("Janitor", materialType.Trim().ToLower(), colorChoice.Trim().ToLower(),
                        toolbox, computerConnection, arm, trash, vacuum);
                    Console.WriteLine();
                    Console.WriteLine("Droid successfully entered!");
                    Console.WriteLine();
                    break;

                    // If the model type is Astromech:
                case "ASTROMECH":
                        // Call the common utility questions method:
                    UtilityQuestions();

                        // Astromech-specific questions - prompt for user input, y or Y to save as true, else false:
                    Console.WriteLine();
                    Console.Write("Does the droid have a fire extinguisher (Y for yes) ? ");
                    bool fire;
                    if (Console.ReadLine().ToUpper() == "Y")
                    {
                        fire = true;
                    }
                    else
                    {
                        fire = false;
                    }
                        // Variable for number of ships, set to -1 for error checking:
                    int ships = -1;
                        // While the number of ships is >= 0:
                    while (ships < 0)
                    {
                            // Prompt for input:
                        Console.WriteLine();
                        Console.Write("Please enter the number of ships: ");

                            // Attempt to parse to int and save to the variable:
                        if (Int32.TryParse(Console.ReadLine(), out ships))
                        {
                                // If it works, call the add method of the DroidCollection class:
                            droidCollection.add("Astromech", materialType.Trim().ToLower(), colorChoice.Trim().ToLower(),
                        toolbox, computerConnection, arm, fire, ships);
                            Console.WriteLine();
                            Console.WriteLine("Droid successfully entered!");
                            Console.WriteLine();
                        }
                        else
                        {
                                // If the input is not an int, output error to user and reset ships to -1 so loop continues:
                            Console.WriteLine();
                            Console.WriteLine("The number of ships must be an integer.");
                            ships = -1;
                        }
                    }
                    break;
                default:
                        // Error message for invalid model:
                    Console.WriteLine("You did not enter a valid model.");
                    break;
            }
        }

            // Method to hold all the common questions for utility droids:
        private void UtilityQuestions()
        {
                // Prompt for each accessory item - read user input, if y or Y, set that variable to true, else false:
            Console.WriteLine();
            Console.Write("Does the droid have a toolbox (Y for yes) ? ");
            if (Console.ReadLine().ToUpper() == "Y")
            {
                toolbox = true;
            }
            else
            {
                toolbox = false;
            }

            Console.WriteLine();
            Console.Write("Does the droid have a computer connection (Y for yes) ? ");
            if (Console.ReadLine().ToUpper() == "Y")
            {
                computerConnection = true;
            }
            else
            {
                computerConnection = false;
            }

            Console.WriteLine();
            Console.Write("Does the droid have an arm (Y for yes) ? ");
            if (Console.ReadLine().ToUpper() == "Y")
            {
                arm = true;
            }
            else
            {
                arm = false;
            }
        }
    }
}
