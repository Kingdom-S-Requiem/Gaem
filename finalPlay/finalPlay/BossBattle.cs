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
            Random rand = new Random();

            if (userInput == "Ok")
            {
                WriteLine("'You mortals are as foolish as I thought!'");
                WriteLine("The demon swiftly ends the tale of the venturous young girl, without a second thought. Maybe in another life, the girl would have persevered and went against the demon, " +
                    "she would still be here to fight him.");
                WriteLine("***************");
                WriteLine("*   Bad End   *");
                WriteLine("***************");
            }
            else if (userInput == "Never!")
            {
                WriteLine("'Then suffer mortal!' He swings his sword down to hit the girl, and she:" +
                    "\n1) Dodges" +
                    "\n2) Blocks" +
                    "\n3) Parry");
                if (userInput == "Dodges")
                {

                }
                else if (userInput == "Blocks")
                {
                    int chanceB = rand.Next(1, 2);
                    if (chanceB == 1)
                    {
                        WriteLine("A good stance and grip on the weapon that kills stops the incoming blow. Faced with an action to attack or to reason with the demon. It wasn't going to be simple," +
                            "but nobody said this gig was going to be." +
                            "\n1) Attack" +
                            "\n2) Reason");
                        if (userInput == "Attack")
                        {

                        }
                        else if (userInput == "Reason")
                        {

                        }
                    }
                    else if (chanceB == 2)
                    {
                        WriteLine("Against a being of his power, your only salvation is luck. This is not the case for this tale.");
                        WriteLine("***************");
                        WriteLine("*   Bad End   *");
                        WriteLine("***************");
                    }
                }
                else if (userInput == "Parry")
                {
                    int chanceP = rand.Next(1, 2);
                    if (chanceP == 1) 
                    {
                        WriteLine("Prodigious size alone does not dissuade the sharpened blade. With the devil exposed, the only viable option is to attack!" +
                            "\n1) Attack" +
                            "\n2) Attack");
                        ReadLine();
                        WriteLine("And with that, the demon falls. His hellish creations everywhere are evaporating into nothing, and the notion of fear is no longer." +
                            "A ray of light shines down from the now exposed sky, as if a hole tore open to return Elisabeth to the surface. Stepping into it, she takes one last look at the place." +
                            "'That was one hell of a night.'");
                        WriteLine("****************");
                        WriteLine("*   Good End   *");
                        WriteLine("****************");
                    }
                    else if (chanceP == 2)
                    {
                        WriteLine("Unfortunately, the steel of the hero is not enough to smite the monsters under the bed. Elisabeth is gone from this world, and the evil continues to live.");
                        WriteLine("***************");
                        WriteLine("*   Bad End   *");
                        WriteLine("***************");
                    }
                }
            }
            else
            {
                WriteLine("Your silence served as an answer for the devil, swiftly he erases you from the ground you stand on.");
                WriteLine("***************");
                WriteLine("*   Bad End   *");
                WriteLine("***************");
            }
        }
    }
}
