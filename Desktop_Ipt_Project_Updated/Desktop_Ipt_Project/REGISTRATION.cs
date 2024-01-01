using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop_Ipt_Project
{
    public class registration
    {
        [DisplayName("Student ID")]
        public string stud_id { get; set; }
        [DisplayName("Course ID")]
        public string course_id { get; set; }
        [DisplayName("Section")]
        public string section { get; set; }
        [DisplayName("Status")]
        public string c_status { get; set; }
        [DisplayName("Pre Requisite")]
        public string pre_requisite { get; set; }
    }
}
