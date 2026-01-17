using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPlabProject
{
    public partial class Drinks : Form
    {
        public Drinks()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Large")
            {
                l1.Text = "4.99 JD";
                l4.Text = "3.99 JD";
                l5.Text = "4.99 JD";
            }
            else
            {
                l1.Text = "3.99 JD";
                l4.Text = "2.99 JD";
                l5.Text = "3.99 JD";
            }
        }
    }
}
