using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Morgan_Bay.Models
{
    public class Room
    {
        [Display(Name = "Room number")]
        public int Room_Num { get; set; }

        [Display(Name = "Floor number")]
        public int Floor_Num {get; set;}

        [Display(Name = "Room Description")]
        public string Room_Description {get; set;}
    }
}
