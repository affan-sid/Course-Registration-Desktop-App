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
using System.Windows;
using System.Windows.Forms;

namespace Desktop_Ipt_Project
{
    public partial class StudentFunction : Form
    {
        public static string Id = "";
        public static string id2 = "";
        public string id3 = "";
        public StudentFunction()
        {
            InitializeComponent();
        }
        public void GetstudentId(string stid)
        {
            id3 = stid;
        }
        private void StudentFunction_Load(object sender, EventArgs e)
        {
            List<registration> std_list = new List<registration>();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44379/api/St_CourseApi");
            var response = client.GetAsync("St_CourseApi/" + id3);
            response.Wait();

            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                string data = test.Content.ReadAsStringAsync().Result;
                std_list = JsonConvert.DeserializeObject<List<registration>>(data);
            }
            dataGridView2.DataSource = std_list;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView2.Rows[index];
            Id = selectedRow.Cells[0].Value.ToString();
            id2 = selectedRow.Cells[1].Value.ToString();
            label1.Text = Id;
            label2.Text = id2;
        }
        private void Add_btn_Click(object sender, EventArgs e)
        {
            StudentAvailableCourses studentAvailableCourses = new StudentAvailableCourses();
            studentAvailableCourses.GetCoursesList(Id,id3);
            studentAvailableCourses.ShowDialog();
        }
        private void Drop_btn_Click(object sender, EventArgs e)
        {
            MessageBoxResult confirmResult = System.Windows.MessageBox
                    .Show("Are you sure to delete this item ??", "Confirm Delete!!", MessageBoxButton.YesNo);
            if (confirmResult == MessageBoxResult.Yes)
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("https://localhost:44379/api/RegistrationApi");
                var response = client.DeleteAsync("RegistrationApi/" + id2 + "/" + Id);
                response.Wait();

                var test = response.Result;
                if (test.IsSuccessStatusCode)
                {
                    System.Windows.MessageBox.Show("Course Dropped Successfully!");
                }
            }
            else
            {}
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            StudentFunction_Load(sender, e);
        }
    }
}
