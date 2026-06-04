using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grand_Azure_Hotel_System
{
    public class Guest
    {
        private static int totalGuestsCreated = 0;
        private string nationalID;
        private string fullName;

        public string NationalID { get { return nationalID; } }
        public string FullName { get { return fullName; }
            set{  if (fullName == " " || fullName == null)
             { Console.WriteLine("enter full name please"); }
            else
            { fullName = fullName; }
                    }
        }
        public Guest ( string name, string id)
        {
            fullName=name;
            nationalID=id;
            totalGuestsCreated++;
        }
           public static int GetTotalGuestsCreated() {  return totalGuestsCreated; }
        public void DisplayInfo()
        {
            Console.WriteLine($"guest name:{FullName} ,National ID: {NationalID}");
        }
    }
}
