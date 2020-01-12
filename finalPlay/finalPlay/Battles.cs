using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalPlay
{
    using static System.Console;
    class Battles
    {
        public static void displayBattles()
        {
            //There is one independant battle for each path that does not immediately lead to the final boss confrontation. This will hold the rest of that respective path's story.
            WriteLine("An enemy! A mixture of excitement and fear is thrown together to create the fuel for the flame: adrenaline. So what first hero? What will be the first move?" +
                "\n1) Attack" +
                "\n2) Block" +
                "\n3) Wait");
            String userInput = ReadLine();
            if (userInput == "Attack")
            {
                WriteLine("A straight forward attack, connects, and lands a killing blow." +
                    "\n'Well, that was a lot easier than I thought it would be.'");

            }
            else if (userInput == "Block")
            {
                WriteLine("A block...to what? Confusion sets in as the beast calls back up. It's better to just lay your weapon down at this point.");
                WriteLine("***************");
                WriteLine("*   Bad End   *");
                WriteLine("***************");
            }
            else if (userInput == "Wait")
            {
                WriteLine("Open, ready for a blow, the creature lunges towards Elisabeth. With precise thinking, she:" +
                    "\n1) Attacks" +
                    "\n2) Blocks");
                if (userInput == "Attacks" || userInput == "Blocks")
                {
                    WriteLine("Great! A defensive move pulled off perfectly. A dying creature now lay in place of a living one. It may be time to get on with the journey. But where to? Two trails to follow, two possible outcomes. What shall our heroine do?" +
                        "\n1) Follow the blood trail" +
                        "\n2) Follow the slime trail");
                    userInput = ReadLine();
                    if (userInput == "Follow the blood trail")
                    {
                        WriteLine("Surprisingly, this was the right way...sort of. Upon reaching the room a small circle lay on the ground. Touching it, Elisabeth was sedated, and stayed that way for a while. Until eventually, she woke up.");
                        BossBattle.displayBossBattle();
                    }
                    else if (userInput == "Follow the slime trail")
                    {
                        WriteLine("A slimy creature ended, only to follow it's path back to the rest. No mercy was shown by these creatures, and Elisabeth was no more.");
                        WriteLine("***************");
                        WriteLine("*   Bad End   *");
                        WriteLine("***************");
                    }
                }
                else
                {
                    WriteLine("Indecisiveness is a cruel reminder that quick thinking and lack of decision making skills can and will get you killed.");
                    WriteLine("***************");
                    WriteLine("*   Bad End   *");
                    WriteLine("***************");
                }
            }

        }
        public static void displayBattles2()
        {
            WriteLine("");
            PaladinRoute.displayPaladinRoute2();
        }
        public static void displayBattles3()
        {
            //This entire battle is meant to simulate a dazed and confused scenario, so things will be a little difficult to handle.
            WriteLine("'Foul creatures, had I not been ambushed this would have been so much easier!' Hope is but a faint glimmer in these difficult times. Will hope shine upon our hero once more?" +
                "\nThe foe comes in for an attack, what's the plan?" +
                "\n1) tAactk" +
                "\n2) ");
            PaladinRoute.displayPaladinRoute2();
        }
    }
}
