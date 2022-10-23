using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_state_project
{
    public partial class Home_page : Form
    {
        public Home_page()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                Admin_login page = new Admin_login();
                page.Show();
            }
            else if (radioButton2.Checked)
            {
                User_login page = new User_login();
                page.Show();
            }
        }
    }
}
