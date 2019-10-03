using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Morgan_Bay.Models
{
    public class Booking
    {
        [Display(Name = "Id")]
        public int Booking_ID { get; set; }

        [Display(Name = "Booking Date")]
        public string Booking_Date {get; set;}

        [Display(Name = "Customer Id")]
        public int Cust_ID {get; set;}

        [Display(Name = "Room Id")]
        public int Room_Num {get; set;}
    }
}
