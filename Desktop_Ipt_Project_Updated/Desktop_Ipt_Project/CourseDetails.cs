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
    public partial class CourseDetails : Form
    {
        public CourseDetails()
        {
            InitializeComponent();
        }

        private void std_id_lbl_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        public void GetCourseId(string id)
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
            id_label.Text = s.id;
            cn_label.Text = s.name;
            ch_lbl.Text = s.credithours.ToString();
            pr_lbl.Text = s.pre_requisite;

        }
        private void Details_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
