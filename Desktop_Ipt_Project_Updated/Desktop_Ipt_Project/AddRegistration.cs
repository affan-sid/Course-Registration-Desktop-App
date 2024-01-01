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
    public partial class AddRegistration : Form
    {
        public AddRegistration()
        {
            InitializeComponent();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            registration r = new registration();
            r.stud_id = id_txt.Text;
            r.course_id = cid_txt.Text;
            r.section = section_txt.Text;
            r.pre_requisite = pr_txt.Text;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44379/api/RegistrationApi");
            string data = JsonConvert.SerializeObject(r);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PostAsync(client.BaseAddress, content).Result;
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Registration Added Successfully!");
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
