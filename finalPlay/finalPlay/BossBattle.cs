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
            Random rand = new Random();
            int chanceB = rand.Next(1, 3);
            WriteLine("'You have just entered the last valid location on earth, this wretched land is set to be desecrated by a devil such as I, and you will NOT stand in my way.'");
            WriteLine("'Getting out of this one is impossible, abandon all hope now and make this easier for yourself.'" +
                "\n1)'Ok'" +
                "\n2)'Never!'");
            String userInput = ReadLine();

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
               userInput = ReadLine();
                if (userInput == "Dodges")
                {
                    WriteLine("'Avoiding your fate only gives you more time to realize that it is inevitable, just give up!'");
                    WriteLine("'In your dreams, devil man!'");
                    WriteLine("With a quick, desicive blow the demon fell back, and into the endless abyss below him. With daylight breaking through the now tore open ground, it was time for Elisabeth to travel onto another life.");
                    WriteLine("****************");
                    WriteLine("*   Good End   *");
                    WriteLine("****************");
                }

                else if (userInput == "Blocks" && chanceB == 1)
                {
                        WriteLine("A good stance and grip on the weapon that kills stops the incoming blow. Faced with an action to attack or to reason with the demon. It wasn't going to be simple, " +
                            "but nobody said this gig was going to be. Maybe trying to reason with the devil could work?" +
                            "\n1) Attack");
                       userInput = ReadLine();
                        if (userInput == "Attack")
                        {
                            WriteLine("'Well, that was a lot easier than I expected it to be.'");
                            WriteLine("'I think not! It's going to take more than a simple swipe to kill me!'");
                            int chanceB2 = rand.Next(1, 3);

                            if (chanceB2 == 1)
                            {
                                WriteLine("I see it goes on and on, the madness insuing with each battle. There is a breaking point every person has, and Elisabeth had just found hers.");
                                WriteLine("This hellish reality will no longer bind her here, rage entangling her soul. With her wrath at hand, she dispelled the demon and left the entire area in shambles.");
                                WriteLine("In a matter of seconds, the ground from underneath Elisabeth crumbled, and she fell into an endless abyss. In the end, a soul for sacrifice is simply another happening, a requirement almost.");
                                WriteLine("***********");
                                WriteLine("*   End   *");
                                WriteLine("***********");
                            }
                            else if (chanceB2 == 2)
                            {
                                WriteLine("'Despite your efforts, you won't be making it out of here.'");
                                WriteLine("And with a swift strike, the tale of Elisabeth the accidental hero comes to a sudden end.");
                                WriteLine("***************");
                                WriteLine("*   Bad End   *");
                                WriteLine("***************");
                            }
                        }
                        else if (userInput == "Reason")
                        {
                            WriteLine("You're words are not enough, maybe if you tried again and used more delightful words, things could work out well?");
                            userInput = ReadLine();
                            if (userInput == "Delightful" || userInput == "delightful")
                            {
                                WriteLine("Understanding the proposition, the demon accepts your offer. Elisabeth has made a deal with the devil, safety for the world in turn for a life of 'delightuful living', whatever that means.");
                                WriteLine("******************");
                                WriteLine("*   Secret End   *");
                                WriteLine("******************");
                            }
                            else
                        {
                            WriteLine("It was no use, he did not hear the words intentions, and ended the tale.");
                            WriteLine("***************");
                            WriteLine("*   Bad End   *");
                            WriteLine("***************");
                        }
                        }

                    else if (userInput == "Blocks" && chanceB == 2)
                    {
                        WriteLine("Against a being of his power, your only salvation is luck. This is not the case for this tale.");
                        WriteLine("***************");
                        WriteLine("*   Bad End   *");
                        WriteLine("***************");
                    }
                }

                else if (userInput == "Parry")
                {
                    int chanceP = rand.Next(1, 3);
                    if (chanceP == 1) 
                    {
                        WriteLine("Prodigious size alone does not dissuade the sharpened blade. With the devil exposed, the only viable option is to attack!" +
                            "\n1) Attack" +
                            "\n2) Attack");
                       userInput = ReadLine();
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
        public static void displayBossBattle2()
        {
            Random rand = new Random();
            int chanceB = rand.Next(1, 3);
            WriteLine("'You have just entered the last valid location on earth, this wretched land is set to be desecrated by a devil such as I, and you will NOT stand in my way.'");
            WriteLine("'Getting out of this one is impossible, abandon all hope now and make this easier for yourself.'" +
                "\n1)'Ok'" +
                "\n2)'Never!'");
            String userInput = ReadLine();

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
                userInput = ReadLine();
                if (userInput == "Dodges")
                {
                    WriteLine("'Avoiding your fate only gives you more time to realize that it is inevitable, just give up!'");
                    WriteLine("'In your dreams, devil man!'");
                    WriteLine("With a quick, desicive blow the demon fell back, and into the endless abyss below him. With daylight breaking through the now tore open ground, it was time for Elisabeth to travel onto another life.");
                    WriteLine("****************");
                    WriteLine("*   Good End   *");
                    WriteLine("****************");
                }

                else if (userInput == "Blocks" && chanceB == 1)
                {
                    WriteLine("A good stance and grip on the weapon that kills stops the incoming blow. Faced with an action to attack or to reason with the demon. It wasn't going to be simple, " +
                        "but nobody said this gig was going to be. Maybe trying to reason with the devil could work?" +
                        "\n1) Attack");
                    userInput = ReadLine();
                    if (userInput == "Attack")
                    {
                        WriteLine("'Well, that was a lot easier than I expected it to be.'");
                        WriteLine("'I think not! It's going to take more than a simple swipe to kill me!'");
                        int chanceB2 = rand.Next(1, 3);

                        if (chanceB2 == 1)
                        {
                            WriteLine("I see it goes on and on, the madness insuing with each battle. There is a breaking point every person has, and Elisabeth had just found hers.");
                            WriteLine("This hellish reality will no longer bind her here, rage entangling her soul. With her wrath at hand, she dispelled the demon and left the entire area in shambles.");
                            WriteLine("In a matter of seconds, the ground from underneath Elisabeth crumbled, and she fell into an endless abyss. In the end, a soul for sacrifice is simply another happening, a requirement almost.");
                            WriteLine("***********");
                            WriteLine("*   End   *");
                            WriteLine("***********");
                        }
                        else if (chanceB2 == 2)
                        {
                            WriteLine("'Despite your efforts, you won't be making it out of here.'");
                            WriteLine("And with a swift strike, the tale of Elisabeth the accidental hero comes to a sudden end.");
                            WriteLine("***************");
                            WriteLine("*   Bad End   *");
                            WriteLine("***************");
                        }
                    }
                    else if (userInput == "Reason")
                    {
                        WriteLine("You're words are not enough, maybe if you tried again and used more delightful words, things could work out well?");
                        userInput = ReadLine();
                        if (userInput == "Delightful" || userInput == "delightful")
                        {
                            WriteLine("Understanding the proposition, the demon accepts your offer. Elisabeth has made a deal with the devil, safety for the world in turn for a life of 'delightuful living', whatever that means.");
                            WriteLine("******************");
                            WriteLine("*   Secret End   *");
                            WriteLine("******************");
                        }
                        else
                        {
                            WriteLine("It was no use, he did not hear the words intentions, and ended the tale.");
                            WriteLine("***************");
                            WriteLine("*   Bad End   *");
                            WriteLine("***************");
                        }
                    }

                    else if (userInput == "Blocks" && chanceB == 2)
                    {
                        WriteLine("Against a being of his power, your only salvation is luck. This is not the case for this tale.");
                        WriteLine("***************");
                        WriteLine("*   Bad End   *");
                        WriteLine("***************");
                    }
                }

                else if (userInput == "Parry")
                {
                    int chanceP = rand.Next(1, 3);
                    if (chanceP == 1)
                    {
                        WriteLine("Prodigious size alone does not dissuade the sharpened blade. With the devil exposed, the only viable option is to attack!" +
                            "\n1) Attack" +
                            "\n2) Attack");
                        userInput = ReadLine();
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

        public static void displayBossBattle3()
        {
            Random rand = new Random();
            int chanceB = rand.Next(1, 3);
            WriteLine("'You have just entered the last valid location on earth, this wretched land is set to be desecrated by a devil such as I, and you will NOT stand in my way.'");
            WriteLine("'Getting out of this one is impossible, abandon all hope now and make this easier for yourself.'" +
                "\n1)'Ok'" +
                "\n2)'Never!'");
            String userInput = ReadLine();

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
                userInput = ReadLine();
                if (userInput == "Dodges")
                {
                    WriteLine("'Avoiding your fate only gives you more time to realize that it is inevitable, just give up!'");
                    WriteLine("'In your dreams, devil man!'");
                    WriteLine("With a quick, desicive blow the demon fell back, and into the endless abyss below him. With daylight breaking through the now tore open ground, it was time for Elisabeth to travel onto another life.");
                    WriteLine("****************");
                    WriteLine("*   Good End   *");
                    WriteLine("****************");
                }

                else if (userInput == "Blocks" && chanceB == 1)
                {
                    WriteLine("A good stance and grip on the weapon that kills stops the incoming blow. Faced with an action to attack or to reason with the demon. It wasn't going to be simple, " +
                        "but nobody said this gig was going to be. Maybe trying to reason with the devil could work?" +
                        "\n1) Attack");
                    userInput = ReadLine();
                    if (userInput == "Attack")
                    {
                        WriteLine("'Well, that was a lot easier than I expected it to be.'");
                        WriteLine("'I think not! It's going to take more than a simple swipe to kill me!'");
                        int chanceB2 = rand.Next(1, 3);

                        if (chanceB2 == 1)
                        {
                            WriteLine("I see it goes on and on, the madness insuing with each battle. There is a breaking point every person has, and Elisabeth had just found hers.");
                            WriteLine("This hellish reality will no longer bind her here, rage entangling her soul. With her wrath at hand, she dispelled the demon and left the entire area in shambles.");
                            WriteLine("In a matter of seconds, the ground from underneath Elisabeth crumbled, and she fell into an endless abyss. In the end, a soul for sacrifice is simply another happening, a requirement almost.");
                            WriteLine("***********");
                            WriteLine("*   End   *");
                            WriteLine("***********");
                        }
                        else if (chanceB2 == 2)
                        {
                            WriteLine("'Despite your efforts, you won't be making it out of here.'");
                            WriteLine("And with a swift strike, the tale of Elisabeth the accidental hero comes to a sudden end.");
                            WriteLine("***************");
                            WriteLine("*   Bad End   *");
                            WriteLine("***************");
                        }
                    }
                    else if (userInput == "Reason")
                    {
                        WriteLine("You're words are not enough, maybe if you tried again and used more delightful words, things could work out well?");
                        userInput = ReadLine();
                        if (userInput == "Delightful" || userInput == "delightful")
                        {
                            WriteLine("Understanding the proposition, the demon accepts your offer. Elisabeth has made a deal with the devil, safety for the world in turn for a life of 'delightuful living', whatever that means.");
                            WriteLine("******************");
                            WriteLine("*   Secret End   *");
                            WriteLine("******************");
                        }
                        else
                        {
                            WriteLine("It was no use, he did not hear the words intentions, and ended the tale.");
                            WriteLine("***************");
                            WriteLine("*   Bad End   *");
                            WriteLine("***************");
                        }
                    }

                    else if (userInput == "Blocks" && chanceB == 2)
                    {
                        WriteLine("Against a being of his power, your only salvation is luck. This is not the case for this tale.");
                        WriteLine("***************");
                        WriteLine("*   Bad End   *");
                        WriteLine("***************");
                    }
                }

                else if (userInput == "Parry")
                {
                    int chanceP = rand.Next(1, 3);
                    if (chanceP == 1)
                    {
                        WriteLine("Prodigious size alone does not dissuade the sharpened blade. With the devil exposed, the only viable option is to attack!" +
                            "\n1) Attack" +
                            "\n2) Attack");
                        userInput = ReadLine();
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

        public static void displayBossBattle4()
        {
            Random rand = new Random();
            int chanceB = rand.Next(1, 3);
            WriteLine("'You have just entered the last valid location on earth, this wretched land is set to be desecrated by a devil such as I, and you will NOT stand in my way.'");
            WriteLine("'Getting out of this one is impossible, abandon all hope now and make this easier for yourself.'" +
                "\n1)'Ok'" +
                "\n2)'Never!'");
            String userInput = ReadLine();

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
                userInput = ReadLine();
                if (userInput == "Dodges")
                {
                    WriteLine("'Avoiding your fate only gives you more time to realize that it is inevitable, just give up!'");
                    WriteLine("'In your dreams, devil man!'");
                    WriteLine("With a quick, desicive blow the demon fell back, and into the endless abyss below him. With daylight breaking through the now tore open ground, it was time for Elisabeth to travel onto another life.");
                    WriteLine("****************");
                    WriteLine("*   Good End   *");
                    WriteLine("****************");
                }

                else if (userInput == "Blocks" && chanceB == 1)
                {
                    WriteLine("A good stance and grip on the weapon that kills stops the incoming blow. Faced with an action to attack or to reason with the demon. It wasn't going to be simple, " +
                        "but nobody said this gig was going to be. Maybe trying to reason with the devil could work?" +
                        "\n1) Attack");
                    userInput = ReadLine();
                    if (userInput == "Attack")
                    {
                        WriteLine("'Well, that was a lot easier than I expected it to be.'");
                        WriteLine("'I think not! It's going to take more than a simple swipe to kill me!'");
                        int chanceB2 = rand.Next(1, 3);

                        if (chanceB2 == 1)
                        {
                            WriteLine("I see it goes on and on, the madness insuing with each battle. There is a breaking point every person has, and Elisabeth had just found hers.");
                            WriteLine("This hellish reality will no longer bind her here, rage entangling her soul. With her wrath at hand, she dispelled the demon and left the entire area in shambles.");
                            WriteLine("In a matter of seconds, the ground from underneath Elisabeth crumbled, and she fell into an endless abyss. In the end, a soul for sacrifice is simply another happening, a requirement almost.");
                            WriteLine("***********");
                            WriteLine("*   End   *");
                            WriteLine("***********");
                        }
                        else if (chanceB2 == 2)
                        {
                            WriteLine("'Despite your efforts, you won't be making it out of here.'");
                            WriteLine("And with a swift strike, the tale of Elisabeth the accidental hero comes to a sudden end.");
                            WriteLine("***************");
                            WriteLine("*   Bad End   *");
                            WriteLine("***************");
                        }
                    }
                    else if (userInput == "Reason")
                    {
                        WriteLine("You're words are not enough, maybe if you tried again and used more delightful words, things could work out well?");
                        userInput = ReadLine();
                        if (userInput == "Delightful" || userInput == "delightful")
                        {
                            WriteLine("Understanding the proposition, the demon accepts your offer. Elisabeth has made a deal with the devil, safety for the world in turn for a life of 'delightuful living', whatever that means.");
                            WriteLine("******************");
                            WriteLine("*   Secret End   *");
                            WriteLine("******************");
                        }
                        else
                        {
                            WriteLine("It was no use, he did not hear the words intentions, and ended the tale.");
                            WriteLine("***************");
                            WriteLine("*   Bad End   *");
                            WriteLine("***************");
                        }
                    }

                    else if (userInput == "Blocks" && chanceB == 2)
                    {
                        WriteLine("Against a being of his power, your only salvation is luck. This is not the case for this tale.");
                        WriteLine("***************");
                        WriteLine("*   Bad End   *");
                        WriteLine("***************");
                    }
                }

                else if (userInput == "Parry")
                {
                    int chanceP = rand.Next(1, 3);
                    if (chanceP == 1)
                    {
                        WriteLine("Prodigious size alone does not dissuade the sharpened blade. With the devil exposed, the only viable option is to attack!" +
                            "\n1) Attack" +
                            "\n2) Attack");
                        userInput = ReadLine();
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
