using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop_Ipt_Project
{
    public class studentmodel
    {
        [DisplayName("Student ID")]
        [Required(ErrorMessage = "Student ID is a required Field")]
        public string id { get; set; }

        [DisplayName("First Name")]
        public string fname { get; set; }
        [DisplayName("Department")]
        public string depart { get; set; }
        [DisplayName("Student Batch")]
        public string student_batch { get; set; }
        [DisplayName("Semester No")]
        public string current_sem { get; set; }
        [DisplayName("Gender")]
        public string gender { get; set; }
        [DisplayName("Email")]
        public string email { get; set; }
        [DisplayName("Contact No")]
        public string contact_number { get; set; }
        [DisplayName("Section")]
        public string section { get; set; }
        [DisplayName("CGPA")]
        public string cgpa { get; set; }
    }
}
