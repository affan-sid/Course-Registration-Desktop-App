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
    public partial class CourseEdit : Form
    {
        public CourseEdit()
        {
            InitializeComponent();
        }
        public void ShowCourse(string id)
        {
            HttpClient client = new HttpClient();
            course s = null;
            client.BaseAddress = new Uri("https://localhost:44379/api/CourseApi");
            var response = client.GetAsync("CourseApi?id=" + id);
            response.Wait();

            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                string data = test.Content.ReadAsStringAsync().Result;
                s = JsonConvert.DeserializeObject<course>(data);
            }
            id_txt.Text = s.id;
            course_txt.Text = s.name;
            credit_txt.Text = s.credithours.ToString();
            pr_txt.Text = s.pre_requisite;
        }
        public void EditCourse()
        {
           
        }
        private void CourseEdit_Load(object sender, EventArgs e)
        {

        }

        private void save_btn_Click(object sender, EventArgs e)
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
            HttpResponseMessage response = client.PutAsync(client.BaseAddress, content).Result;
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Course Editted Successfully");
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
