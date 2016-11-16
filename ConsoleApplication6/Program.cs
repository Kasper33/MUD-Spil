using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6 { 

    class Program
    {
        static void Main(string[] args)
        {
            World w = new World();
            bool playing = true;
            Console.WriteLine("Hello!! Welcome to India Quest");
            Room start = w.GetRoom("Start");
            Player p = new Player();
            if(start!=null)
            {
                p.CurrentRoom = start;
                Console.WriteLine(p.CurrentRoom);
            }
            while (playing) {
                
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
        }
    }
}
