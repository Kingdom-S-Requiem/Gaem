using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalPlay
{
    using static System.Console;
    class BossBattle
    {
        public static void displayBossBattle()
        {
            WriteLine("'You have just entered the last valid location on earth, this wretched land is set to be desecrated by a devil such as I, and you will NOT stand in my way.'");
            WriteLine("'Getting out of this one is impossible, abandon all hope now and make this easier for yourself.'" +
                "\n1)'Ok'" +
                "\n2)'Never!'");
            String userInput = ReadLine();

            if (userInput == "Ok")
            {
                WriteLine("'You mortals are as foolish as I thought!'");
            }
        }
    }
}
