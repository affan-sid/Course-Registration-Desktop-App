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
    public partial class StudentEdit : Form
    {
        public StudentEdit()
        {
            InitializeComponent();
        }

        private void StudentEdit_Load(object sender, EventArgs e)
        {

        }
        public void ShowStudents(string id)
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
            id_txt.Text = s.id;
            fn_txt.Text = s.fname;
            dep_txt.Text = s.depart;
            batch_txt.Text = s.student_batch;
            sem_txt.Text = s.current_sem;
            cgpa_txt.Text = s.cgpa;
            email_txt.Text = s.email;
            gender_txt.Text = s.gender;
            no_txt.Text = s.contact_number;
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void save_btn_Click(object sender, EventArgs e)
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
            HttpResponseMessage response = client.PutAsync(client.BaseAddress, content).Result;

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Student Editted Successfully!");
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void batch_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void dep_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void fn_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void sem_lbl_Click(object sender, EventArgs e)
        {

        }

        private void gender_lbl_Click(object sender, EventArgs e)
        {

        }

        private void cgpa_lbl_Click(object sender, EventArgs e)
        {

        }

        private void contact_lbl_Click(object sender, EventArgs e)
        {

        }

        private void email_lbl_Click(object sender, EventArgs e)
        {

        }

        private void cgpa_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void stdid_lbl_Click(object sender, EventArgs e)
        {

        }

        private void fname_lbl_Click(object sender, EventArgs e)
        {

        }

        private void batch_lbl_Click(object sender, EventArgs e)
        {

        }

        private void dep1_lbl_Click(object sender, EventArgs e)
        {

        }
    }
}
