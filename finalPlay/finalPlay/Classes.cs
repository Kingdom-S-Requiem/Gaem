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
            Write("'Welcome to hell, population: me. I really gotta get outta here. I guess I'll take some of this equipment with me.'");
            WriteLine("In front of the girl lay armor and weapons, a plentiful amount. She could not take them all, and would have to settle on one set.");
            WriteLine("Lost Paladin: Comes with a broadsword (2-6 damage) and an old set of armor." +
                "\nForgotten Mage: Comes with a tome (3-9 damage) and enchanted robes." +
                "\nWandering Archer: Comes with a wooden bow and some basic arrows (2-4 damage)." +
                "\nBanished Brawler: Comes with a set of CCC gear (2-14 damage) and some basic armor.");
            String userChoice = ReadLine();
            if (userChoice == "Lost Paladin" || userChoice == "lost paladin")
            {
                WriteLine("Picking up the sword and dawning the armor, Elisabeth was as ready as she could be to face the terrors of the dark.");
                BossBattle.displayBossBattle();
            }
            else if (userChoice == "Forgotten Mage")
            {
                WriteLine("Adorning the robes and reading the tome, Elisabeth did her best to remember the simple spells to defend herself from the creatures of the deep.");

            }
            else if (userChoice == "Wandering Archer")
            {
                WriteLine("Snatching up the bow, the girl made use of her own attire and used some of the fabric to make something of an armor.");

            }
            else if (userChoice == "Banished Brawler")
            {
                WriteLine("Tightening the gloves and the botts, the girl was fired up, because it was all she had to keep her going down here.");

            }
            else
            {
                WriteLine("Met with choices leaves some at a disadvantage, and Elisabeth was one such person. She went onward without any of the loot, and suffered a fate worse than death.");
            }
        }
    }
}
