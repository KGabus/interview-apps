using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterviewProject
{
    public partial class Form1 : Form
    {
        string intTransactionID = "Testing";                //changed data type from int to string

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dateSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateDiff dateForm = new DateDiff();
            dateForm.Show();
        }
    }
}
