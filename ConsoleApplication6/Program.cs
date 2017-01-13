using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{

    class Program
    {
        static World w;
        static void Main(string[] args)
        {
            w = new World();
            bool playing = true;
            Console.WriteLine("Hello! Thank you for playing 100% PC Befriending Simulator 2k17.");
            Console.WriteLine("The game is currently in Alpha, and is not done. At the moment you're only able to walk around.");
            Console.WriteLine("You can't enter houses, nor interact with obejects and npcs.");
            Room start = w.GetRoom("Start");
            if (start != null)
            {
                w.p.CurrentRoom = start;
                Console.WriteLine(w.p.CurrentRoom);
            }
            while (playing)
            {
                Console.WriteLine("Type Exit to exit");
                Console.WriteLine("Press Enter to start walking.");
                Console.WriteLine("When walking type stop to exit");
                string input = Console.ReadLine();

                if (input.ToLower().Equals("exit"))
                {
                    playing = false;
                }
                else
                {
                    HandleGame();
                }
            }
        }
        private static void HandleGame()
        {
            bool isMoving = true;
            while (isMoving)
            {
                string walk = "";
                walk = Console.ReadLine();
                if (walk.ToLower().Equals("north") || (walk.ToLower().Equals("n")))
                {
                    if (!w.p.CurrentRoom.north.Equals(null))
                    {
                        Console.WriteLine("You walk north.");
                        w.p.CurrentRoom = w.p.CurrentRoom.north;
                        w.p.EnterRoom();
                    }
                }
                if (walk.ToLower().Equals("south") || (walk.ToLower().Equals("s")))
                {
                    if (!w.p.CurrentRoom.south.Equals(null))
                    {
                        Console.WriteLine("You walk south.");
                        w.p.CurrentRoom = w.p.CurrentRoom.south;
                        w.p.EnterRoom();
                    }
                }
                if (walk.ToLower().Equals("east") || (walk.ToLower().Equals("e")))
                {
                    if (!w.p.CurrentRoom.east.Equals(null))
                    {
                        Console.WriteLine("You walk east.");
                        w.p.CurrentRoom = w.p.CurrentRoom.east;
                        w.p.EnterRoom();
                    }
                }
                if (walk.ToLower().Equals("west") || (walk.ToLower().Equals("w")))
                {
                    if (!w.p.CurrentRoom.west.Equals(null))
                    {
                        Console.WriteLine("You walk west.");
                        w.p.CurrentRoom = w.p.CurrentRoom.west;
                        w.p.EnterRoom();
                    }
                }
                if (walk.ToLower().Equals("stop"))
                {
                    isMoving = false;
                }
            }

        }
    }
}