using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing
{
    public partial class Form2 : Form
    {
        DataTable table=new DataTable("table");
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            table.Rows.Add("ID", Type.GetType("System.Int32"));
            table.Rows.Add("ID", Type.GetType("System.Int32"));
            table.Rows.Add("ID", Type.GetType("System.Int32"));
            table.Rows.Add("ID", Type.GetType("System.Int32"));
            table.Rows.Add("ID", Type.GetType("System.Int32"));
            table.Rows.Add("ID", Type.GetType("System.Int32"));
        }
    }
}
