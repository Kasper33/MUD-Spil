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
                    }
                }
                if (walk.ToLower().Equals("south") || (walk.ToLower().Equals("s")))
                {
                    Console.WriteLine("Du går mod syd");
                }
                if (walk.ToLower().Equals("east") || (walk.ToLower().Equals("e")))
                {
                    Console.WriteLine("Du går mod øst");
                }
                if (walk.ToLower().Equals("west") || (walk.ToLower().Equals("w")))
                {
                    Console.WriteLine("Du går mod vest");
                }
                if(walk.ToLower().Equals("stop"))
                {
                    isMoving = false;
                }
            }
            
        }
        }
    }

