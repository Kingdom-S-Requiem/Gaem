using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalPlay
{
    using static System.Console;
    class Classes
    {
        public static void displayClasses()
        {
            Write("Welcome to hell, population: me. I really gotta get outta here. I guess I'll take some of this equipment with me.");
            WriteLine("In front of the girl lay armor and weapons, a plentiful amount. She could not take them all, and would have to settle on one set.");
            WriteLine("Lost Paladin: Comes with a broadsword (2-6 damage) and an old set of armor." +
                "\nForgotten Mage: Comes with a tome (3-9 damage) and enchanted robes." +
                "\nWandering Archer: Comes with a wooden bow and some basic arrows (2-4 damage)." +
                "\nBanished Brawler: Comes with a set of CCC gear (2-14 damage) and some basic armor.");
            String userChoice = ReadLine();

        }
    }
}
