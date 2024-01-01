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
    public partial class RegistrationDetails : Form
    {
        public RegistrationDetails()
        {
            InitializeComponent();
        }
        public void GetRegistrationById(string course_id,string stud_id)
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
            id_label.Text = s.stud_id;
            cid_label.Text = s.course_id;
            sec_lbl.Text = s.section;
            pr_lbl.Text = s.pre_requisite;
        }

        private void RegistrationDetails_Load(object sender, EventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
