using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalPlay
{
    using static System.Console;
    class BrawlerRoute
    {
        public static void displayBrawlerRoute()
        {
            //In this simple game, I wanted to try and give it some variety. Some of the encounters will be randomly generated, and this is what sets the random modifier to be used later.
            Random rand = new Random();
            WriteLine("Entering the darkness in front of her, she set off in search of anything.");
            WriteLine("You find a set of CQC gear next to you");
            WriteLine("Would you like to move forward?:" +
                "\n1) Yes" +
                "\n2) No ");
            String userInput = ReadLine();
            if (userInput == "Yes" || userInput == "yes")
            {
                WriteLine("You shall now embarce on your journey as a brawler ");
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
                        WriteLine("The path to salvation may lie in front of any one person, at any time. Losing track of such a thing, however, may be a calling to the end. In this instance, fate was not as cruel to our heroine. " +
                            "Tearing at her clothes and legs, the stalagmites seem to get taller and wider. Using all of her energy, she climbs over each one that is encountered, but it seems there is no end." +
                            "\nAs hope is almost lost, a faint noise in the distance reignites her fire. The question is, does she investigate?" +
                            "\n1) Investigate" +
                            "\n2) Don't investigate");
                        userInput = ReadLine();
                        if (userInput == "Investigate")
                        {
                            WriteLine("Going to the noise with a small bit of hope inside of her, she checks it.");
                            //This is an example of one of those random outcomes, generally just going to be a 50/50.
                            int chance1 = rand.Next(1, 3);
                            if (chance1 == 1)
                            {
                                WriteLine("Seeing a small trinket, she follows a trail of what appears colored water. Not being a light enough torch hid her from the fate she was soon to discover, of the now dead adventurer. And next to it, that is the killer.");
                                Battles.displayBattles10();
                                //Some of these random encounters will be battles for our player to enjoy.
                            }
                            else if (chance1 == 2)
                            {
                                //Some of these random encounters will result in the end for our character :(
                                WriteLine("Curiosity is indeed what killed the cat, this is no exception. Investigating led to a trap to go off that sedated Elisabeth. The horrors of the dark dragged her away, never to be seen again.");
                                WriteLine("***************");
                                WriteLine("*   Bad End   *");
                                WriteLine("***************");
                            }
                        }
                        else if (userInput == "Not investigate")
                        {
                            WriteLine("Staying on the trail, she reminds herself that whatever it was could very well have ended her short trip. Keeping a hold onto the torch, she continues on. " +
                                "\nStopping to listen, she hears the faint sound of water, or what sounds like it. She thinks, 'isn't this place underground?' but continues on anyway. " +
                                "\nAcross the ravine appears a figure, humanlike in appearance. Waving hello, the figure waves back and departs. The small body of water creates a lake in the ravine. Will you take the chance and go down?" +
                                "\n1) Descend" +
                                "\n2) Cross");
                            userInput = ReadLine();
                            if (userInput == "Descend")
                            {
                                WriteLine("Descending down into the depths, a challenge is faced right off the bat. A disgusting creature slimes its way up, and gets in a stance that looks very threatening.");
                                Battles.displayBattles11();
                            }
                            else if (userInput == "Cross")
                            {
                                WriteLine("Most likely tainted by impurities, crossing the ravine was the next best idea. A conveniently placed bridge allows travel to more unknown spaecs, but this would be the only familiar feeling down here." +
                                    "\nUpon this road is a trinket, something that looks oddly shiny in nature. What purpose does it have? A question that cannot be answered without examination. Do you take the trinket?" +
                                    "\n1) Take it" +
                                    "\n2) Leave it");
                                userInput = ReadLine();
                                if (userInput == "Take it")
                                {
                                    int chance = rand.Next(1, 3);
                                    if (chance == 1)
                                    {
                                        BossBattle.displayBossBattle4();
                                    }
                                    else if (chance == 2)
                                    {
                                        WriteLine("'In the pocket it goes. Woah, this thing has pockets!' The excitement is short lived, as she remembers where she is.");
                                        WriteLine("The true test in the end is figuring out what was accomplished. Is she going anywhere? Will she ever figure it out? Well, the charm was just about to tell her.");
                                        BrawlerRoute.displayBrawlerRoute2();
                                    }

                                }
                                else if (userInput == "Leave it")
                                {
                                    WriteLine("Continuing onward, the one person group came to face another issue: sleep. Sleeping seems very dangerous, but at a time like this rest is critical." +
                                        "\n1) Rest" +
                                        "\n2) Onward");
                                    userInput = ReadLine();
                                    if (userInput == "Rest")
                                    {
                                        WriteLine("A nap doesn't hurt anyone. Snuffing out the torch, the only thing one can hope for is safety.");
                                        int chance = rand.Next(1, 3);
                                        if (chance == 1)
                                        {
                                            WriteLine("A growl, or whatever you want to call it, is heard. In a panic, the heroine gets up and throws on the equipment, the legion of the dark has ambushed her.");
                                            Battles.displayBattles12();
                                        }
                                        else if (chance == 2)
                                        {
                                            WriteLine("Hours pass, and once fully rested, the girl awakens. From clear skies to stalagmites in the deep, a reality check almost, but to a reality that doesn't seem real.");
                                            WriteLine("Gathering all gear and moving forward, the water led her to a clearing in what appeared to be more cave. There was a seperate path, but it looked tiny and would most definitely be a challenge to get through." +
                                                "\n1) Go into the cave" +
                                                "\n2) Go to the path");
                                            userInput = ReadLine();
                                            if (userInput == "Go into the cave")
                                            {
                                                WriteLine("An endless gray goes on for what feels like miles, the water surrounding seems to become more and more valuable as the time passes. " +
                                                    "\nFaced with the very idea of drought, the young warrior drops to her knees near the river." +
                                                    "\n1) Drink up" +
                                                    "\n2) Keep going");
                                                userInput = ReadLine();
                                                if (userInput == "Drink up")
                                                {
                                                    WriteLine("Water is something of myth, a liquid that not only provides life, but also a source of cleanliness, vital medicinal use, and more. The impurities in this water meant nothing to Elisabeth, as she gulps down more and more." +
                                                        "\nThat may have not been such a good idea, as shortly before she stands up she feels a bit dizzy. Mere seconds after, she drops.");
                                                    BrawlerRoute.displayBrawlerRoute2();
                                                }
                                                else if (userInput == "Keep going")
                                                {
                                                    WriteLine("The time to push oneself to their limits is a time that varies for all. Here and now was that time, but the best was not given. Elisabeth collapses, and stays that way.");
                                                    WriteLine("For a time, but then as if a miracle had happened, she rises.");
                                                    BrawlerRoute.displayBrawlerRoute2();
                                                }
                                            }
                                            else if (userInput == "Go to the path")
                                            {
                                                WriteLine("Doing her best to squeeze through the tight bits of crevice, she presses onward. The only issue in here is that the tight spots make for awkward, and claustrophobic situations. " +
                                                    "\nFear is only a deterrent in these lands. Finally squeezing through, Elisabeth examines her surroundings and makes the same inference about the rest of the place: 'This sucks'.");
                                                BrawlerRoute.displayBrawlerRoute2();
                                            }
                                        }
                                    }
                                    else if (userInput == "Onward")
                                    {
                                        BrawlerRoute.displayBrawlerRoute2();
                                    }
                                }
                            }
                        }

                    }
                    else if (userInput == "Take a left")
                    {
                        WriteLine("'No good, gotta go back. Is every turn in this place a dead end!?'");
                        BrawlerRoute.displayBrawlerRoute();
                    }
                    else if (userInput == "Take a right")
                    {
                        WriteLine("'No good, gotta go back. Is every turn in this place a dead end!?'");
                        BrawlerRoute.displayBrawlerRoute();
                    }
                }
                else if (userInput == "Go downward")
                {
                    WriteLine("Heading down into the darkness is a bold move, but one that someone bold enough can handle. Denizens of the dark lash and gnaw at the living, and portrude horrors beyond imagination." +
                        "\nThis did not stop Elisabeth and her quest for answers, and acceptance. Onward she went, into the fray.");
                    WriteLine(" ");
                    WriteLine("Eventually, the heroine came to a stop in the road, morally. Can she really do this? Making a quick decision, she:" +
                        "\n1) Turned back" +
                        "\n2) Kept on the path");
                    userInput = ReadLine();
                    if (userInput == "Turned back")
                    {
                        WriteLine("Everyone knows the stories, if you get too far in and try to turn back, unforeseen consequences show themselves. A wendigo emerged from the darkness, and snatched Elisabeth from where she stood. The details are nasty, so I will spare you them and say " +
                            "she simply died.");
                        WriteLine("***************");
                        WriteLine("*   Bad End   *");
                        WriteLine("***************");
                    }
                    else if (userInput == "Kept on the path")
                    {
                        WriteLine("Would she be able to make it? Where was she going? What is she looking for?");
                        BrawlerRoute.displayBrawlerRoute2();
                    }

                }
            }
            else if (userInput == "No" || userInput == "no")
            {
                WriteLine("Okay, why did you choose this class to begin with? Bye.");
            }
        }
        //This second paladin route method is what will be the primary way to get into the boss battle. Game is kinda short but it's what we could get done the fastest.
        public static void displayBrawlerRoute2()
        {
            Random rand = new Random();
            WriteLine("An interesting situation, really. One normally doesn't have to think of anything like this back in the safety of home.");
            WriteLine("To stay sane down here is difficult, now is a test of sanity. In a fit of madness, figures appear in the dark, menacing and coming closer." +
                "\n1) Attack" +
                "\n2) Meditate");
            String userInput = ReadLine();
            if (userInput == "Attack")
            {
                WriteLine("Visions in the dark tend to hold consequences of untold level, Swinging rapidly at the phantoms, Elisabeth losses her mind, as she cannot comprehend real from fake anymore.");
                WriteLine("***************");
                WriteLine("*   Bad End   *");
                WriteLine("***************");
            }
            else if (userInput == "Meditate")
            {
                WriteLine("Such phantoms will not deter the young hero, channeling her inner peace to herself she finds the phantoms have disappeared.");
                WriteLine("After meditation, an evil presence was still felt. Almost as if she was in a different location all together...");
                BossBattle.displayBossBattle4();
            }
        }
    }
}
