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
    public partial class ContactTracingApp : Form
    {
        public ContactTracingApp()
        {
            InitializeComponent();
            dataGVRecords.ColumnCount = 3;
            dataGVRecords.Columns[0].Name = "Full Name";
            dataGVRecords.Columns[1].Name = "Vaccinated since";
            dataGVRecords.Columns[2].Name = "Age";
        }
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (toyear.Text == "2022")
                year2022();
            else if (toyear.Text == "2023")
                year2023();
            dataGVRecords.Rows.Add(fullname.Text, month.Text + "/" + day.Text + "/" + toyear.Text, age.Text);
        }

        private void year2022()
        {
            string nameOfText = fullname.Text;
            StreamWriter file = new StreamWriter(@"C:\Users\D'Aviador\Desktop\Daniel\CONTACTTRACING\2022\" + fullname.Text + ".txt");
            file.Write("");
            file.WriteLine("Your Name :" + fullname.Text);
            file.WriteLine("Your Gender :" + gender.Text);
            file.WriteLine("Your Age :" + age.Text);
            file.WriteLine("Contact Number :" + contactnumber.Text);
            file.WriteLine("Email Address :" + emailaddress.Text);
            file.WriteLine("Your Address :" + address.Text);
            file.WriteLine("Since When?:" + month.Text + "/" + day.Text + "/" + toyear.Text);
            file.WriteLine("Are you vaccinated? :" + vaccinated.Text);
            file.WriteLine("Date Today :" + today1.Text + "/" + tomonth.Text + "/" + toyear.Text);
            file.WriteLine("Birtday :" + hbd.Text);
            file.Close();
        }
        private void year2023()
        {
            string nameOfText = fullname.Text;
            StreamWriter file = new StreamWriter(@"C:\Users\D'Aviador\Desktop\Daniel\CONTACTTRACING\2023\" + fullname.Text + ".txt");
            file.Write("");
            file.WriteLine("Your Name :" + fullname.Text);
            file.WriteLine("Your Gender :" + gender.Text);
            file.WriteLine("Your Age :" + age.Text);
            file.WriteLine("Contact Number :" + contactnumber.Text);
            file.WriteLine("Email Address :" + emailaddress.Text);
            file.WriteLine("Your Address :" + address.Text);
            file.WriteLine("Since When? :" + month.Text + "/" + day.Text + "/" + year.Text);
            file.WriteLine("Are you vaccinated? :" + vaccinated.Text);
            file.WriteLine("Date Today :" + today1.Text + "/" + tomonth.Text + "/" + toyear.Text);
            file.WriteLine("Birthday :" + hbd.Text);
            file.Close();

        }
    }
}
