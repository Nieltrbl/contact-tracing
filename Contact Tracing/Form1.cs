using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Contact_Tracing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter A = new StreamWriter(Application.StartupPath + "\\form\\" + "custdetails.txt");

            A.WriteLine(label1.Text + " " + textBox1.Text);
            A.WriteLine(label2.Text + " " + textBox2.Text);
            A.WriteLine(label3.Text + " " + textBox3.Text);
            A.WriteLine(label4.Text + " " + textBox4.Text);
            A.WriteLine(label5.Text + " " + textBox5.Text);
            A.WriteLine(label6.Text + " " + textBox6.Text);
            A.WriteLine(label7.Text + " " + textBox7.Text);
            A.WriteLine(label8.Text + " " + textBox8.Text);
            A.WriteLine(label9.Text + " " + textBox9.Text);

            A.Close();


        }
    }
}
