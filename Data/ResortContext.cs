using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Morgan_Bay.Models
{
    public class ResortContext
    {
        public List<Booking> bookings { get; set; }

        public ResortContext()
        {
            bookings = new List<Booking>()
            {
                new Booking{BookingID = 1, Booking_Date = "123", Cust_ID = 1, Room_Num = 1},
                new Booking{BookingID = 2, Booking_Date = "154", Cust_ID = 2, Room_Num = 2},
                new Booking{BookingID = 3, Booking_Date = "651", Cust_ID = 3, Room_Num = 3},
            };
        }
    }
}
