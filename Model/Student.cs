using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRegistration.Model
{
    public class Student
    {
        [Key]
        public int roll_no { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string standard { get; set; }
        public string contact_no { get; set; }
    }
}
