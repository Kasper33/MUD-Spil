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
            Room rStart = new Room("Start", "Welcome champion, you have been chosen to make new friends in this cruel world. Continue north to start your adventure of friendship.");
            Room r1 = new Room("Crossing1", "You stand in a crossing. You can walk east, north or west.");
            Room r2 = new Room("Abandoned Hut", "You stand at the gate to an what appears like an abandoned house. You can walk east and west, or enter the house.");
            Room r3 = new Room("Health fountain", "You see a fountain spouting water. You can drink some water, go north or east.");
            Room r4 = new Room("Dark forrest", "You're inside a dark forrest. You can go west or east.");
            Room r5 = new Room("Crossing2", "You stand in a crossing. You can go south, east and north.");
            Room r6 = new Room("Monster", "You see a dark figure bent over a white horse on the dirt. You can go back north, or continue towards the dark figure.");
            Room r7 = new Room("Boss 1", "You see a crying man in lederhosen, sitting on a tree stump with a beer in his hand. He hasn't seen you yet. You can go back west, or go talk to the man.");
            Room r8 = new Room("Caravan", "You see an exit out of the forrest. As you leave you get blinded by the sunlight. You see a trading caravan with a broken wheel, and before you know, you see a man walking towards you. You can talk to the man, or run back south into the forrest.");
            Room r10 = new Room("Town", "As you enter the town, it looks very shady. There are only 6 houses in the city. To the east you see a dark alley between 2 of the houses. Go east down the alley, go north, west or south out of the city.");
            Room r11 = new Room("Dark alley", "As you walk down the dark alley you can hear footsteps behind you, as you turn around you see a big man with a club. Go back west.");
            Room r12 = new Room("Town crossing", "You come to a crossing. You can go north, west or south.");
            Room r14 = new Room("Old house", "As you walk down the road you see an old house. You can enter the house, or go back east.");
            Room r15 = new Room("Elderly man", "You see an old man, and he sees you. You can talk to him, go north or south.");
            Room r16 = new Room("Kevin the merciful", "At the end of the road you see a young man leaning up the side of a big tree. You can choose to talk to him or go back south.");

            rooms.Add(rStart);
            rooms.Add(r1);
            rooms.Add(r2);
            rooms.Add(r3);
            rooms.Add(r4);
            rooms.Add(r5);
            rooms.Add(r6);
            rooms.Add(r7);
            rooms.Add(r8);
            rooms.Add(r10);
            rooms.Add(r11);
            rooms.Add(r12);
            rooms.Add(r14);
            rooms.Add(r15);
            rooms.Add(r16);

            rStart.AddNorth(r1);
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
            r8.AddNorth(r10);
            r8.AddSouth(r5);
            r10.AddEast(r11);
            r10.AddWest(r3);
            r10.AddNorth(r12);
            r10.AddSouth(r1);
            r11.AddWest(r10);
            r12.AddWest(r14);
            r12.AddNorth(r15);
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
                if (r.navn.Equals(navn))
                {
                    return r;
                }
            }
            return null;
        }
    }
}