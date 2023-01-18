using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Limitless
{
    public class Room
    {
        public int RoomNum { get; set; }
        public string RoomName { get; set; }
        public int BedCapacity {get;set;}
        public string Image { get; set; }
        public double Price { get; set;  }
        public string BookedDates { get; set; }

        public Room() { }
        public Room(int roomNum, string roomName, int bedCapacity, string image, double price, string bookedDates)
        {
            RoomNum = roomNum;
            RoomName = roomName;
            BedCapacity = bedCapacity;
            Image = image;
            Price = price;
            BookedDates = bookedDates;
        }
    }
}
