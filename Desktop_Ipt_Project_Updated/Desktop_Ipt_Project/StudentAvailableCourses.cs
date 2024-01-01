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
    public partial class StudentAvailableCourses : Form
    {

        public static string Id = "";
        public static string id2 = "";
        protected static string stu_id = "",csu_id="";
        public StudentAvailableCourses()
        {
            InitializeComponent();
        }
        public void GetCoursesList(string cs_id,string st_id)
        {
            csu_id = cs_id; stu_id = st_id;
            List<registration> s = new List<registration>();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44379/api/RegistrationApi");
            var response = client.GetAsync("RegistrationApi?id=" + cs_id);
            response.Wait();
            string data = "";
            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                data = test.Content.ReadAsStringAsync().Result;
                s = JsonConvert.DeserializeObject<List<registration>>(data);
            }

            List<course> std_list = new List<course>();
            client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44379/api/CourseApi");
            var respons = client.GetAsync("CourseApi");
            respons.Wait();
            registration std = new registration();
            test = respons.Result;
            if (test.IsSuccessStatusCode)
            {
                string data1 = test.Content.ReadAsStringAsync().Result;
                std_list = JsonConvert.DeserializeObject<List<course>>(data1);
            }
            foreach (registration reg in s)
            {
                int index = std_list.FindIndex(item => item.id == reg.course_id);
                if (index >= 0)
                {
                    std_list.RemoveAt(index);
                }
            }
            dataGridView3.DataSource = std_list;
        }
        private void add_btn_Click(object sender, EventArgs e)
        {
            registration std = new registration();
            studentmodel s = null;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44379/api/StudentApi");
            var response = client.GetAsync("StudentApi?id=" + stu_id);
            response.Wait();
            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                string dat = test.Content.ReadAsStringAsync().Result;
                s = JsonConvert.DeserializeObject<studentmodel>(dat);
            }
            std.course_id = Id;
            std.stud_id = stu_id;
            std.section = s.section;
            std.c_status = null;
            std.pre_requisite = null;
            client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44379/api/RegistrationApi");
            string data = JsonConvert.SerializeObject(std);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage respons = client.PostAsync(client.BaseAddress, content).Result;

            if (respons.IsSuccessStatusCode)
            {
                MessageBox.Show("Course Added Successfully!");
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView3.Rows[index];
            Id = selectedRow.Cells[0].Value.ToString();
            id2 = selectedRow.Cells[1].Value.ToString();
            label1.Text = Id;
            label2.Text = id2;
        }

        private void StudentAvailableCourses_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            GetCoursesList(csu_id,stu_id);
        }
    }
}
