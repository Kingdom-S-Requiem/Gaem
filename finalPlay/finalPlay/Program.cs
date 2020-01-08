using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalPlay
{
    using static System.Console;
    class Program
    {
        static void Main(string[] args)
        { 
            WriteLine("Hello, I notice you ran this program. Does that mean that you want to play a game? (Yes/No)");
            String userInput = ReadLine();
            if (userInput == "Yes" || userInput == "yes")
            {
                WriteLine("Very well then, enjoy a wonderful story provided by the team. Venture on, young soul!");
                Classes.displayClasses();
            }
            else if (userInput == "No" || userInput == "no")
            {
                WriteLine("No? Well in that case, leave! Some people actually want to play the game!");
            }
            else
                WriteLine("You're not very good with these sorts of tasks, are you? Try again, and read carefully.");
        }
    }
}
