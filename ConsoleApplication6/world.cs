using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    public class World
    {
        List<Room> rooms;
        public World()
        {
            rooms = new List<Room>();
            Room r1 = new Room("Start", "En stor og grøn mark med masser af smukke planter og dyr");
            Room r2 = new Room("Forladt Hus", "");
            Room r3 = new Room("Helbredelses fontæne", "");
            Room r4 = new Room("Mørk Skov", "");
            Room r5 = new Room("Monster og kryds", "");
            Room r6 = new Room("Monster", "");
            Room r7 = new Room("Boss 1", "");
            Room r8 = new Room("Mørk skov slut", "");
            Room r9 = new Room("Ødelagt Karavane", "");
            Room r10 = new Room("By", "");
            Room r11 = new Room("Sort gyde", "");
            Room r12 = new Room("By Kryds", "");
            Room r13 = new Room("Butik", "");
            Room r14 = new Room("Gammelt ødelagt hus", "");
            Room r15 = new Room("Gammel Mand", "");

            rooms.Add(r1);
            rooms.Add(r2);
            rooms.Add(r3);
            rooms.Add(r4);

            r1.AddEast(r2);
            r2.AddWest(r1);
            r2.AddNorth(r3);
            r3.AddSouth(r2);
            r3.AddEast(r4);

        }

        public void PrintWorld()
        {
            foreach (Room r in rooms)
            {
                Console.WriteLine(r.ToString());
            }
        }


    }
}