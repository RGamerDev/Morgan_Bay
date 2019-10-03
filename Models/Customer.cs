using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Morgan_Bay.Models
{
    public class Customer
    {
        [Display(Name = "Id")]
        public int Cust_ID { get; set; }

        [Display(Name = "Name")]
        public string Cust_Name { get; set; }

        [Display(Name = "Address")]
        public string Cust_Address { get; set; }

        [Display(Name = "E-mail")]
        public string Cust_Email { get; set; }

        [Display(Name = "Cellphone number")]
        public int Cust_Num { get; set; }
    }
}
