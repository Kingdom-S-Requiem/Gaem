using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalPlay
{
    using static System.Console;
    class PaladinRoute
    {
        public static void displayPaladinRoute()
        {
            WriteLine("Entering the darkness in front of her, she set off in search of anything.");
            WriteLine("Next to you there is a broadsword along with an old set of armor. The blade is slighty rusty");
            WriteLine("Would you like to move forward?:" +
                "\n1) Yes" +
                "\n2) No ");
            String userInput = ReadLine();
            if (userInput == "Yes" || userInput == "yes")
            {
                WriteLine("You shall now embarce on your journey as a palaidn ");
            }
            else if (userInput == "No" || userInput == "no")
            {
                WriteLine("Okay, why did you choose this class to begin with? Bye.");
            }
        }
    }
}