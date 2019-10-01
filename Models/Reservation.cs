using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Morgan_Bay.Models
{
    public class Reservation
    {
        [Display(Name = "Arrival")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Departure")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Number of guests")]
        public int AmountOfPeople { get; set; }

        [Display(Name = "Room number")]
        public int RoomNumber { get; set; }
    }
}
