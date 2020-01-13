using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalPlay
{
    //Running this in every class is CRUCIAL, as it gets rid of having to retype "Console." for any of those commands. A short but worth it time saver.
    using static System.Console;
    class Program
    {
        static void Main(string[] args)
        { 
            //This WriteLine here has no actual impact on the choice, as it is just asking you if you would like to play. The real answers are housed in "If" and "If-Else" statements.
            WriteLine("Hello, I notice you ran this program. Does that mean that you want to play a game? (Yes/No)");
            String userInput = ReadLine();
            if (userInput == "Yes" || userInput == "yes")
            {
                WriteLine("Very well then, enjoy a wonderful story provided by the team. Venture on, young soul!");
                WriteLine("Please keep in mind that options displayed must be typed exactly, or else the game will not work, and that isn't cool.");
                WriteLine("This game is also following a more realistic path for enemies, so it will take only 1-3 shots to kill something from the deep depths.");
                //After running through the initial setup, this is where it takes you to the classes class (a class houses all of this beautiful code you're seeing, and this one is for classes!).
                Classes.displayClasses();
            }
            else if (userInput == "No" || userInput == "no")
            {
                WriteLine("No? Well in that case, leave! Some people actually want to play the game!");
                //This is just a joke, so if people get cocky and answer with "no", the game gives them a cocky response.
            }
            else
                WriteLine("You're not very good with these sorts of tasks, are you? Try again, and read carefully.");
            //This is meant as a jab at people who don't like to read, you must type it as it is given in the bar for it to work.
        }
    }
}
