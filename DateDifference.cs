using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSearch = DateSearch.DateSearchClass;                         //what?

namespace InterviewProject
{
    public partial class DateDiff : Form
    {
        DateTime date1;
        DateTime date2;
        int daysDifference;

        DSearch dSearch1 = new DSearch();                           //there has got to be a better way

        public DateDiff()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            date1 = dateTimePicker1.Value;
            date2 = dateTimePicker2.Value;
            findDifference();
        }

        private void findDifference()                               //uses DateSearch dll to find the number of days between two dates
        {
            daysDifference = dSearch1.DateDifference(date1, date2);
            textBox1.Text = daysDifference.ToString();
        }
    }
}
