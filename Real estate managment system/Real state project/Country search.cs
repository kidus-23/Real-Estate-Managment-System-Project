using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Real_state_project
{
    public partial class Country_search : Form
    {
        public Country_search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.SelectedItems.Clear();
            for (int i = listBox1.Items.Count - 1; i >= 0; i--)
                if (listBox1.Items[i].ToString().ToLower().Contains(textBox1.Text.ToLower()))
                {
                    listBox1.SetSelected(i, true);
                }
            //label_status.Text = listBox1.SelectedItems.Count.ToString() + " items found";
        }
    }
}
