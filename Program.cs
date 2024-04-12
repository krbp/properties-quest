using System;
using System.Collections.Generic;
using System.Linq;

namespace Encapsulation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            House house = new House();
            Room room = new Room();
            Door houseDoor = new Door();
            Door roomDoor = new Door();
            house.Doors.Add(houseDoor);
            house.Rooms.Add(room);
            room.Doors.Add(roomDoor);
        }
    }

    public class House
    {
        public List<Room> Rooms { get; }
        public List<Door> Doors { get; }
        public House()
        {
            Rooms = new List<Room>();
            Doors = new List<Door>();
        }
    }

    public class Room
    {
        public List<Door> Doors { get; }
        public Room()
        {
            Doors = new List<Door>();
        }
    }

    public class Door
    {
        public bool IsOpen { get; private set; }
        public Door()
        {
            IsOpen = false;
        }
        public void Open()
        {
            if (IsOpen)
            {
                Console.WriteLine("Door already opened. Ain't done anything.");
            }
            else
            {
                IsOpen = true;
            }
        public void Close()
        {
            if (!IsOpen)
            {
                Console.WriteLine("Door already closed. Ain't done anything.");
            }
            else
            {
                IsOpen = false;
            }
        }
    }
}
