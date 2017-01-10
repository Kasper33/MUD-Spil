using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6 { 

    class Program
    {
        static World w;
        static void Main(string[] args)
        {
            w = new World();
            bool playing = true;
            Console.WriteLine("Hello!! Welcome to India Quest");
            Room start = w.GetRoom("Start");

            if(start!=null)
            {
                w.p.CurrentRoom = start;
                Console.WriteLine(w.p.CurrentRoom);
            }
            while (playing) {
                Console.WriteLine("Type Exit to.... tadaaa.. exit");
                string input = Console.ReadLine();
     
                if(input.ToLower().Equals("exit"))
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
            while(isMoving)
            {
                string walk = "";
                walk = Console.ReadLine();
                if (walk.ToLower().Equals("north") || (walk.ToLower().Equals("n")))
                {
                    if (!w.p.CurrentRoom.north.Equals(null))
                    {
                        w.p.CurrentRoom = w.p.CurrentRoom.north;
                        w.p.EnterRoom();
                        Console.WriteLine("You walk north.");
                    }
                }
                if (walk.ToLower().Equals("south") || (walk.ToLower().Equals("s")))
                {
					if (!w.p.CurrentRoom.south.Equals(null))
					{
						w.p.CurrentRoom = w.p.CurrentRoom.south;
						w.p.EnterRoom();
                        Console.WriteLine("You walk south.");
					}
                }
                if (walk.ToLower().Equals("east") || (walk.ToLower().Equals("e")))
                {
					if (!w.p.CurrentRoom.east.Equals(null))
					{
						w.p.CurrentRoom = w.p.CurrentRoom.east;
						w.p.EnterRoom();
                        Console.WriteLine("You walk east.");

					}
				}
                if (walk.ToLower().Equals("west") || (walk.ToLower().Equals("w")))
                {
					if (!w.p.CurrentRoom.west.Equals(null))
					{
						w.p.CurrentRoom = w.p.CurrentRoom.west;
						w.p.EnterRoom();
                        Console.WriteLine("You walk west.");

					}
				}
                if(walk.ToLower().Equals("stop"))
                {
                    isMoving = false;
                }
            }
            
        }
        }
    }

