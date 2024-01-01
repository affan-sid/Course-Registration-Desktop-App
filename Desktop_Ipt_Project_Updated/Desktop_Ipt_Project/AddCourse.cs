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
    public partial class AddCourse : Form
    {
        public AddCourse()
        {
            InitializeComponent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            course c = new course();
            c.id = id_txt.Text;
            c.name = course_txt.Text;
            c.credithours = int.Parse(credit_txt.Text);
            c.pre_requisite = pr_txt.Text;

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44379/api/CourseApi");
            string data = JsonConvert.SerializeObject(c);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PostAsync(client.BaseAddress, content).Result;
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Course Added Successfully");
            }
        }
    }
}
