using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp84
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cEmployee t = new cEmployee();
            t.toobig += t_toobig;
            t.FirstName = textBox1.Text;
            t.lastName = textBox2.Text;
            listBox1.Items.Add(t.Concatinate());
        }

        private void t_toobig()
        {
            listBox1.Items.Add("Event Fire");
        }
    }
}
