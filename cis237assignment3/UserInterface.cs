// Alyssa Strand
// The UserInterface class handles all input from and output to the user and calls the AddDroid class when prompted.  

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class UserInterface
    {
            // Instantiate classes to be used:
        AddDroid addDroid;


        public UserInterface()
        {
                // Call the method that handles interactions with the user:
            UserInteraction();
        }

            // Method to cycle the options menu and call corresponding methods depending on the user's choice:
        private void UserInteraction()
        {
                // Declare and initialize a variable to hold the user's choice:
            int userChoice = 0;

                // Continue to loop the options menu while the user's choice is not to exit:
            while (userChoice != 3)
            {
                    // Output options and prompt for choice:
                Console.WriteLine("1. Add a new droid.");
                Console.WriteLine("2. Print the droid list.");
                Console.WriteLine("3. Exit.");
                Console.Write("Pick an option: ");

                    // Attempt to parse the input as an integer and save as userChoice:
                if ((Int32.TryParse(Console.ReadLine(), out userChoice)))
                {
                        // Enter a case statement to call methods / enter other classes accordingly:
                    switch (userChoice) {
                        case 1:
                            // If the user chooses to add a new droid, call that method:
                            addDroid = new AddDroid();
                            break;
                        case 2:
                                // If the user chooses to print the droid list, call that method:
                            PrintDroidList();
                            break;
                        case 3:
                                // If the user chooses to exit, just break; the loop will exit when userChoice = 3
                            break;
                        default:
                                // If the choice is not one of the options, output error message to user:
                            Console.WriteLine();
                            Console.WriteLine("That option was not listed.  Please choose a valid option.");
                            Console.WriteLine();
                            break;
                            }
                }
                else
                {
                        // If the tryParse failed, output error message to user:
                    Console.WriteLine();
                    Console.WriteLine("Please only type the number of the choice.");
                    Console.WriteLine();
                }
            }
        }

            // Method to output the droid list:
        private void PrintDroidList()
        {
            Console.WriteLine();
            Console.WriteLine("Got to choice 2");
            Console.WriteLine();
        }

    }
}
