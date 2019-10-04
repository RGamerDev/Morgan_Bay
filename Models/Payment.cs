using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Morgan_Bay.Models
{
    public class Payment
    {
        [Display(Name = "Id")]
        public int PaymentID { get; set; }

        [Display(Name = "Type")]
        public string Payment_Type {get; set;}

        [Display(Name = "Payment")]
        public string Payment_Date {get; set;}

        [Display(Name = "Amount")]
        public float Payment_Amount {get; set;}

        [Display(Name = "Booking Id")]
        public int Booking_ID {get; set;}
    }
}
