using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop_Ipt_Project
{
    public class course
    {
        [DisplayName("Course Id")]
        public string id { get; set; }

        [DisplayName("Course Name")]
        public string name { get; set; }

        [DisplayName("Credit Hours")]
        public Nullable<int> credithours { get; set; }

        [DisplayName("Pre Requisite")]
        public string pre_requisite { get; set; }

    }
}
