using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // s means short, l means long
            int s = Convert.ToInt32(textBox1.Text);
            int l = Convert.ToInt32(textBox2.Text);

            Rectangle r = new Rectangle(s, l);

            label3.Text = "Area: " + r.Area();
            label4.Text = "Perimeter: " + r.Perimeter();
        }
    }
}
