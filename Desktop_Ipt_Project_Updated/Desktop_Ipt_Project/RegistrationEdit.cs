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
    public partial class RegistrationEdit : Form
    {
        public RegistrationEdit()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        public void ShowRegistrations(string course_id, string stud_id)
        {
            HttpClient client = new HttpClient();
            registration s = null;
            client.BaseAddress = new Uri("https://localhost:44379/api/RegistrationApi");
            var response = client.GetAsync("RegistrationApi/" + course_id + "/" + stud_id);
            response.Wait();
            string data = "";
            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                data = test.Content.ReadAsStringAsync().Result;
                s = JsonConvert.DeserializeObject<registration>(data);
            }
            id_txt.Text = s.stud_id;
            cid_txt.Text = s.course_id;
            section_txt.Text = s.section;
            pr_txt.Text = s.pre_requisite;
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_btn_Click(object sender, EventArgs e)
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
            HttpResponseMessage response = client.PutAsync(client.BaseAddress, content).Result;
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Registrations Editted Successfully!");
            }
        }

        private void RegistrationEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
