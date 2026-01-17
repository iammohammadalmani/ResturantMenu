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
    public partial class Main_Course : Form
    {
        public Main_Course()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "AUM26")
            {
                apr1.Text = "15.99 JD";
                apr2.Text = "14.39 JD";
                apr3.Text = "12.79 JD";
                apr4.Text = "17.50 JD";
                apr5.Text = "19.19 JD";
                label2.Visible = true;
                label3.Visible = false;


            }
            else
            {
                label3.Visible = true;
                label2.Visible = false;
                apr1.Text = "19.99 JD";
                apr2.Text = "17.99 JD";
                apr3.Text = "15.99 JD";
                apr4.Text = "21.99 JD";
                apr5.Text = "23.99 JD";
            }
        }
    }
}
