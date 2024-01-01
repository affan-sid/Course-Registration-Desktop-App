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
    public partial class AdminFunction : Form
    {
        public static string Id = "";
        public static string id2 = "";
        HttpClient client = new HttpClient();
        static int counter = 0;
        public AdminFunction()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            Id = selectedRow.Cells[0].Value.ToString();
            id2 = selectedRow.Cells[1].Value.ToString();
            id_lbl.Text = Id;
            label1.Text = id2;
        }

        private void crs_btn_Click(object sender, EventArgs e)
        {
            List<course> std_list = new List<course>();
            client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44379/api/CourseApi");
            var response = client.GetAsync("CourseApi");
            response.Wait();

            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                string data = test.Content.ReadAsStringAsync().Result;
                std_list = JsonConvert.DeserializeObject<List<course>>(data);
            }
            dataGridView1.DataSource = std_list;
            counter = 1;
        }

        private void std_btn_Click(object sender, EventArgs e)
        {
            List<studentmodel> std_list = new List<studentmodel>();
            client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44379/api/StudentApi");
            var response = client.GetAsync("StudentApi");
            response.Wait();

            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                string data = test.Content.ReadAsStringAsync().Result;
                std_list = JsonConvert.DeserializeObject<List<studentmodel>>(data);
            }
            dataGridView1.DataSource = std_list;
            counter = 2;
        }

        private void reg_btn_Click(object sender, EventArgs e)
        {
            List<registration> std_list = new List<registration>();
            client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44379/api/RegistrationApi");
            var response = client.GetAsync("RegistrationApi");
            response.Wait();

            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                string data = test.Content.ReadAsStringAsync().Result;
                std_list = JsonConvert.DeserializeObject<List<registration>>(data);
            }
            dataGridView1.DataSource = std_list;
            counter = 3;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if(counter == 1)
            {
                AddCourse addCourse = new AddCourse();
                addCourse.ShowDialog();
            }
            else if(counter == 2)
            {
                AddStudent addStudent = new AddStudent();
                addStudent.ShowDialog();
            }
            else
            {
                AddRegistration addRegistration = new AddRegistration();
                addRegistration.ShowDialog();
            }
        }

        private void details_btn_Click(object sender, EventArgs e)
        {
            if (counter == 1)
            {
                
                CourseDetails details = new CourseDetails();
                 details.GetCourseId(Id);
                 details.ShowDialog();
                 //this.Close();
               // MessageBox.Show(Course_Id);
            }
            else if (counter == 2)
            {
                StudentDetails details = new StudentDetails();
                details.GetStudentId(Id);
                details.ShowDialog();
            }
            else
            {
                RegistrationDetails details = new RegistrationDetails();
                details.GetRegistrationById(id2, Id);
                details.ShowDialog();
            }
        }

        private void AdminFunction_Load(object sender, EventArgs e)
        {

        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            if (counter == 1)
            {
                CourseEdit courseedit = new CourseEdit();
                courseedit.ShowCourse(Id);
                courseedit.ShowDialog();
            }
            else if (counter == 2)
            {
                StudentEdit studentedit = new StudentEdit();
                studentedit.ShowStudents(Id);
                studentedit.ShowDialog();
            }
            else
            {
                RegistrationEdit registrationedit = new RegistrationEdit();
                registrationedit.ShowRegistrations(id2, Id);
                registrationedit.ShowDialog();
            }
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            if (counter == 1)
            {
                MessageBoxResult confirmResult = System.Windows.MessageBox
                    .Show("Are you sure to delete this item ??", "Confirm Delete!!", MessageBoxButton.YesNo);
                if (confirmResult == MessageBoxResult.Yes)
                {
                    HttpClient client = new HttpClient();
                    List<registration> s = new List<registration>();
                    client.BaseAddress = new Uri("https://localhost:44379/api/RegistrationApi");
                    var response = client.GetAsync("RegistrationApi?id=" + Id);
                    response.Wait();
                    string data = "";
                    var test = response.Result;
                    if (test.IsSuccessStatusCode)
                    {
                        data = test.Content.ReadAsStringAsync().Result;
                        s = JsonConvert.DeserializeObject<List<registration>>(data);
                    }
                    foreach (registration reg in s)
                    {
                        if (reg.course_id == Id)
                        {
                            client = new HttpClient();
                            client.BaseAddress = new Uri("https://localhost:44379/api/RegistrationApi");
                            response = client.DeleteAsync("RegistrationApi/" + reg.course_id + "/" + reg.stud_id);
                            response.Wait();
                            test = response.Result;
                        }
                    }
                    client = new HttpClient();
                    client.BaseAddress = new Uri("https://localhost:44379/api/CourseApi");
                    response = client.DeleteAsync("CourseApi?id=" + Id);
                    response.Wait();

                    test = response.Result;
                    if (test.IsSuccessStatusCode)
                    {
                        System.Windows.MessageBox.Show("Course Deleted Successfully!");
                    }
                }
                else
                {
                }
            }
            else if (counter == 2)
            {
                MessageBoxResult confirmResult = System.Windows.MessageBox
                    .Show("Are you sure to delete this item ??", "Confirm Delete!!", MessageBoxButton.YesNo);

                if (confirmResult == MessageBoxResult.Yes)
                {
                    HttpClient client = new HttpClient();
                    List<registration> s = new List<registration>();
                    client.BaseAddress = new Uri("https://localhost:44379/api/RegistrationApi");
                    var response = client.GetAsync("RegistrationApi?id=" + Id);
                    response.Wait();
                    string data = "";
                    var test = response.Result;
                    if (test.IsSuccessStatusCode)
                    {
                        data = test.Content.ReadAsStringAsync().Result;
                        s = JsonConvert.DeserializeObject<List<registration>>(data);
                    }
                    foreach (registration reg in s)
                    {
                        if (reg.stud_id == Id)
                        {
                            client = new HttpClient();
                            client.BaseAddress = new Uri("https://localhost:44379/api/RegistrationApi");
                            response = client.DeleteAsync("RegistrationApi/" + reg.course_id + "/" + reg.stud_id);
                            response.Wait();
                            test = response.Result;
                        }
                    }
                    client = new HttpClient();
                    client.BaseAddress = new Uri("https://localhost:44379/api/StudentApi");
                    response = client.DeleteAsync("StudentApi?id=" + Id);
                    response.Wait();
                    test = response.Result;
                    if (test.IsSuccessStatusCode)
                    {
                        System.Windows.MessageBox.Show("Student Deleted Successfully!");
                    }
                }
                else
                {
                }
            }
            else
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
                        System.Windows.MessageBox.Show("Registration Deleted Successfully!");
                    }
                }
                else
                {
                }
            }
        }
    }       
}
