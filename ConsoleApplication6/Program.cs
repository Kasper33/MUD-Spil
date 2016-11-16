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
            w.PrintWorld();
            bool playing = false;


            playing = true;
            while (playing) {
                Console.WriteLine();
                Console.WriteLine("");
                Console.ReadLine();
            }
        }
    }
}
