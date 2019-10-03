using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Morgan_Bay.Models
{
    public class Employee
    {
        [Display(Name = "Id")]
        public int Emp_ID { get; set; }

        [Display(Name = "Name")]
        public string Emp_Name { get; set; }

        [Display(Name = "Address")]
        public string Emp_Address { get; set; }

        [Display(Name = "E-mail")]
        public string Emp_Email { get; set; }

        [Display(Name = "Cellphone Number")]
        public int Emp_Num { get; set; }
    }
}
