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
            Random rand = new Random();
            WriteLine("Entering the darkness in front of her, she set off in search of anything.");
            WriteLine("Next to you there is a broadsword along with an old set of armor. The blade is slighty rusty");
            WriteLine("Would you like to move forward?:" +
                "\n1) Yes" +
                "\n2) No ");
            String userInput = ReadLine();
            if (userInput == "Yes" || userInput == "yes")
            {
                WriteLine("You shall now embarce on your journey as a palaidn ");
                WriteLine("Taking a step into the endless black, an unlit, and surprisingly dry torch is available to our heroine. Lighting up the torch, she is faced with a cave system, stalagmites and the likes surround her and the area." +
                    "\nTaking a step forward, Elisabeth is faced with a choice. Head into the deep, dark system ahead of her, or enter the downward spiral that beckons." +
                    "\n1) Go forward" +
                    "\n2) Go downward");
                userInput = ReadLine();
                if (userInput == "Go forward")
                {
                    WriteLine("Onward she travels, into an unknown setting. Where to go? Twists and turns at every available opening. Getting lost is an easy task in this never ending black.");
                    WriteLine("Seeing a 3 way opening only leaves more to the imaginable. The only question now would be 'which way'?" +
                        "\n1) Continue forward" +
                        "\n2) Take a left" +
                        "\n3) Take a right");
                    userInput = ReadLine();
                    if (userInput == "Continue forward")
                    {
                        WriteLine("The path to salvation may lie in front of any one person, at any time. Losing track of such a thing, however, may be a calling to the end. In this instance, fate was not as cruel to our heroine." +
                            "Tearing at her clothes and legs, the stalagmites seem to get taller and wider. Using all of her energy, she climbs over each one that is encountered, but it seems there is no end." +
                            "\nAs hope is almost lost, a faint noise in the distance reignites her fire. The question is, does she investigate?" +
                            "\n1) Investigate" +
                            "\n2) Don't investigate");
                        userInput = ReadLine();
                        if (userInput == "Investigate")
                        {
                            WriteLine("Going to the noise with a small bit of hope inside of her, she checks it.");
                            int chance1 = rand.Next(1, 3);
                            if (chance1 == 1)
                            {
                                WriteLine("Seeing a small trinket, she follows a trail of what appears colored water. Not being a light enough torch hid her from the fate she was soon to discover, of the now dead adventurer. And next to it, that is the killer.");
                                Battles.displayBattles();
                            }
                            else if (chance1 == 2)
                            {
                                WriteLine("Curiosity is indeed what killed the cat, this is no exception. Investigating led to a trap to go off that sedated Elisabeth. The horrors of the dark dragged her away, never to be seen again.");
                                WriteLine("***************");
                                WriteLine("*   Bad End   *");
                                WriteLine("***************");
                            }
                        }
                        else if (userInput == "Not investigate")
                        {
                            WriteLine("Staying on the trail, she reminds herself that whatever it was could very well have ended her short trip. Keeping a hold onto the torch, she continues on. " +
                                "\nStopping to listen, she hears the faint sound of water, or what sounds like it. She thinks, 'isn't this place underground?' but continues on anyway." +
                                "\nAcross the ravine appears a figure, humanlike in appearance. Waving hello, the figure waves back and departs. The small body of water creates a lake in the ravine. Should one go down");
                        }

                    }
                    else if (userInput == "Take a left")
                    {
                        WriteLine("");
                    }
                    else if (userInput == "Take a right")
                    {
                        WriteLine("");
                    }
                }
                else if (userInput == "Go downward")
                {
                    WriteLine("");
                }
            }
            else if (userInput == "No" || userInput == "no")
            {
                WriteLine("Okay, why did you choose this class to begin with? Bye.");
            }
        }
    }
}