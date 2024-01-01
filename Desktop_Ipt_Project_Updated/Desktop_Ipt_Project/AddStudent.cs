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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            studentmodel s = new studentmodel();
            s.id = id_txt.Text;
            s.fname = fn_txt.Text;
            s.depart = dep_txt.Text;
            s.student_batch = batch_txt.Text;
            s.current_sem = sem_txt.Text;
            s.cgpa = cgpa_txt.Text;
            s.email = email_txt.Text;
            s.gender = gender_txt.Text;
            s.contact_number = no_txt.Text;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44379/api/StudentApi");
            string data = JsonConvert.SerializeObject(s);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PostAsync(client.BaseAddress, content).Result;
            add_btn.Font = new Font(add_btn.Font, FontStyle.Bold);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Student Added Successfully!");
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
