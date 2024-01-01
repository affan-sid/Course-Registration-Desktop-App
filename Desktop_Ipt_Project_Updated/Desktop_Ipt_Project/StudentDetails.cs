using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_Ipt_Project
{
    public partial class StudentDetails : Form
    {
        public StudentDetails()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        public void GetStudentId(string id)
        {
            HttpClient client = new HttpClient();
            studentmodel s = null;
            client.BaseAddress = new Uri("https://localhost:44379/api/StudentApi");
            var response = client.GetAsync("StudentApi?id=" + id);
            response.Wait();

            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                string data = test.Content.ReadAsStringAsync().Result;
                s = JsonConvert.DeserializeObject<studentmodel>(data);
            }
            id_label.Text = s.id;
            fn_label.Text = s.fname;
            dep_lbl.Text = s.depart;
            batch1_lbl.Text = s.student_batch;
            seme_lbl.Text = s.current_sem;
            gen_lbl.Text = s.gender;
            em_lbl.Text = s.email;
            no_lbl.Text = s.contact_number;
            cgpa1_lbl.Text = s.cgpa;
        }

            private void StudentDetails_Load(object sender, EventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
