using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    public class Player
    {
        public string navn;
        public Room CurrentRoom;

        public void EnterRoom()
        {
            Console.WriteLine(CurrentRoom.ToString());
        }
    }
}
