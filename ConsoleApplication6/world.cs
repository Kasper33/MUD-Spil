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
            rooms.Add(r5);
            rooms.Add(r6);
            rooms.Add(r7);
            rooms.Add(r8);
            rooms.Add(r9);
            rooms.Add(r10);
            rooms.Add(r11);
            rooms.Add(r12);
            rooms.Add(r13);
            rooms.Add(r14);
            rooms.Add(r15);

            r1.AddNorth(r10);
            r1.AddWest(r2);
            r1.AddEast(r4);
            r2.AddWest(r3);
            r2.AddEast(r1);
            r3.AddNorth(r10);
            r3.AddEast(r2);
            r4.AddEast(r2);
            r4.AddWest(r1);
            r5.AddSouth(r6);
            r5.AddEast(r7);
            r5.AddNorth(r8);
            r6.AddNorth(r5);
            r7.AddWest(r5);
            r8.AddNorth(r9);
            r8.AddSouth(r5);
            r9.AddWest(r10);
            r10.AddEast(r11);
            r10.AddWest(r3);
            r10.AddNorth(r12);
            r11.AddWest(r10);
            r12.AddEast(r13);
            r12.AddWest(r14);
            r12.AddNorth(r15);
            r13.AddWest(r12);
            r14.AddEast(r12);
            r15.AddNorth(??????);
            r15.AddSouth(r12);
            

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