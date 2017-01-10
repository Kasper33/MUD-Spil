using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    public class World
    {
        public List<Room> rooms;
        public Player p = new Player();
        public World()
        {
            rooms = new List<Room>();
            Room r1 = new Room("Start", "Welcome champion, you have accepted the challenge to purge all autism from this world. Continue north and discover a small town, travel west and find an abandoned hut or move east and go to the dark forest.");
            Room r2 = new Room("Abandoned Hut", "");
            Room r3 = new Room("Health fountain", "");
            Room r4 = new Room("Dark forrest", "");
            Room r5 = new Room("Crossing", "");
            Room r6 = new Room("Monster", "");
            Room r7 = new Room("Boss 1", "Niklas the Great will have to be purged");
            Room r8 = new Room("The dark forrest ends", "The trees is clearing up and the area is getting light");
            Room r9 = new Room("Broken Caravan", "Strangers help you to the town");
            Room r10 = new Room("Town", "A lazy town, where nothing ever happens");
            Room r11 = new Room("Dark alley", "It's too quiet here");
            Room r12 = new Room("Town crossing", "");
            Room r13 = new Room("Store", "Closed for now");
            Room r14 = new Room("Old house", "KEEP OUT!");
            Room r15 = new Room("Elderly man", "Go on son, meet Kevin");
			Room r16 = new Room("Kevin the merciful", "Kevin spares your life and sends you home.");

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
			rooms.Add(r16);

            r1.AddNorth(r10);
            r1.AddWest(r2);
            r1.AddEast(r4);
            r2.AddWest(r3);
            r2.AddEast(r1);
            r3.AddNorth(r10);
            r3.AddEast(r2);
            r4.AddEast(r5);
            r4.AddWest(r1);
            r5.AddSouth(r6);
            r5.AddEast(r7);
            r5.AddNorth(r8);
            r6.AddNorth(r5);
            r7.AddWest(r5);
            r8.AddNorth(r9);
            r8.AddSouth(r5);
			r9.AddSouth(r8);
            r10.AddEast(r11);
            r10.AddWest(r3);
            r10.AddNorth(r12);
			r10.AddSouth(r1);
            r11.AddWest(r10);
            r12.AddEast(r13);
            r12.AddWest(r14);
            r12.AddNorth(r15);
            r13.AddWest(r12);
            r14.AddEast(r12);
            r15.AddNorth(r16);
            r15.AddSouth(r12);
            

        }

        public void PrintWorld()
        {
            foreach (Room r in rooms)
            {
                Console.WriteLine(r.ToString());
            }
        }

        public Room GetRoom(string navn)
        {
            foreach (Room r in rooms)
            {
                if(r.navn.Equals(navn))
                {
                    return r;
                }
            }
            return null;
        }
    }
}