using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
                //convert day to int
                string d = cboDay.Text;
                int day = Convert.ToInt32(d);

                //convert month to integer representation
                string m = cboMonth.Text;
                int month = DateTime.ParseExact(m, "MMMM", System.Globalization.CultureInfo.InvariantCulture).Month;

                //convert year to int
                string y = cboYear.Text;
                int year = Convert.ToInt32(y);

            MessageBox.Show("These are the days your birthday will fall on for the next ten years");
            //loop to print out days of week birthday in susequent years falls on
            for (int i = 1; i <= 10; i++)
            {
                ///create datetime birthday from input
                DateTime birthday = new DateTime(year, month, day);
                //add year on each iteration
                birthday = birthday.AddYears(i);

               
                //output the day of the week
                string output= Convert.ToString(birthday.DayOfWeek);
                //output the year 
                string outputYear = Convert.ToString(birthday.Year);
                
                txtBox.Text += outputYear + " " + output + "\n";
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
