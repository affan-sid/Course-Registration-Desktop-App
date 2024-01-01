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
    public partial class Student : Form
    {
        string username = "";
        string password = "";
        public Student()
        {
            InitializeComponent();
        }

        private void username_lbl_Click(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (password != username)
            {
                MessageBox.Show("Enter Password again");
            }
            else
            {
                studentmodel s = new studentmodel();
                s.id = username;
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("https://localhost:44379/api/LoginApi");
                string data = JsonConvert.SerializeObject(s);
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                HttpResponseMessage response = client.PostAsync(client.BaseAddress, content).Result;
                var stud = response.Content.ReadAsStringAsync();
                if (stud != null)
                {
                    StudentFunction studentFunction = new StudentFunction();
                    studentFunction.GetstudentId(username);
                    studentFunction.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid Username!");
                }
            }
        }

       

        private void username_txtbox_TextChanged(object sender, EventArgs e)
        {
            username = username_txtbox.Text;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            password = textBox1.Text;
          
        }

        private void Student_Load(object sender, EventArgs e)
        {

        }
    }
}
