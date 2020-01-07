using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalPlay
{
    using static System.Console;
    class Rooms_and_Movement
    {
        public static void displayRoomAndMovements()
        {
            bool playing = true;
            {
                while (playing)
                {
                    int room1 = 7;
                    int room2 = 12;
                    int room3 = 19;
                    int room4 = 24;
                    int bossRoom1 = 2;

                    Random rnd = new Random();
                    int item = rnd.Next(1, 12);
                    int consumable = rnd.Next(1, 15);
                    int battle = rnd.Next(1, 2);

                    if (item == 1 || item == 3 || item == 5 || item == 7 || item == 9 || item == 11)
                    {
                        
                    }

                    //if (item == 20)
                    //{
                    //    if (item < 16)
                    //    {
                    //    }
                    //}
                }
            }
        }
    }
}