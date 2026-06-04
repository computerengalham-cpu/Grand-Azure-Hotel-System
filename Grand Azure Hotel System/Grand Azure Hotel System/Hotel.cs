using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grand_Azure_Hotel_System
{
    public class Hotel
    {
        private List<Guest> guests;
        private List<Room> rooms;
        private List<Booking> bookings;
        private string hotelName;

        public string HotelName { get; }
        public Hotel(string name) { }
    }
}
