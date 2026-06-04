using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grand_Azure_Hotel_System
{
    public class Booking
    {
        private static int nextBookingID = 1001;
        private int bookingID;
        private Guest guest;
        private Room room;

        public int BookingID {  get { return bookingID; } }
        public Guest Guest { get { return guest; } }
        public Room Room {  get { return room; } }

        public Booking(Guest guest, Room room)
        {
            bookingID = nextBookingID;
            nextBookingID++;
            guest = guest;
            room = room;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"booking ID:{BookingID},guest name:{Guest.FullName},room number:{Room.RoomNumber},room type:{Room.RoomType}");
        }
    }
}
