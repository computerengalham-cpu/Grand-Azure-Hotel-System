using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grand_Azure_Hotel_System
{
    public class Room
    {
        private int roomNumber;
        private string roomType;
        private bool isBooked;

        public int RoomNumber {  get { return roomNumber; }}
        public string RoomType {  get { return roomType; }}
        public bool IsBooked {  get { return isBooked; }}

        public Room(int number, string type)
        {
            roomNumber=number;
            roomType=type;
            isBooked = false;
        }

        public bool Book()
        {

            if (isBooked == false)
            {
                Console.WriteLine("successful");
                isBooked = true;
                return true;
            }
            else
            {
                Console.WriteLine("already booked");
                return false;
            }
        }
        public void CancelBooking()
        {
            isBooked = false;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"room number:{RoomNumber},type:{RoomType}, availability status:{IsBooked}");
        }
    }

}
