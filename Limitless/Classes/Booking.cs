using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Limitless.Classes
{
    public class Booking
    {
        public string ID { get; set; }
        public int Guests { get; set; }
        public int Room { get; set; }
        public int NumberOfNights { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public string GuestName { get; set; }
        public Booking() { }

        public Booking(string iD, int guests, int room, int numberOfNights, DateTime checkIn, DateTime checkOut, string guestName)
        {
            ID = iD;
            Guests = guests;
            Room = room;
            NumberOfNights = numberOfNights;
            CheckIn = checkIn;
            CheckOut = checkOut;
            GuestName = guestName;
        }
    }
}
