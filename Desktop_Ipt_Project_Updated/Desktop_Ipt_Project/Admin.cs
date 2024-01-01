using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_Ipt_Project
{
    public partial class Admin : Form
    {
        string username = "";
        string password = "";
        public Admin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void username_txtbox_TextChanged(object sender, EventArgs e)
        {
            username = username_txtbox.Text;
        }

        private void password_txtbox_TextChanged(object sender, EventArgs e)
        {
            password = password_txtbox.Text;
        }

        private void Admin_Load(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {

            if (username == "admin" && password == "admin")
            {
                AdminFunction adminfunction = new AdminFunction();
                adminfunction.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Username Or Password!");
            }
        }

    }
}
