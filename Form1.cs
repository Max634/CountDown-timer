using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountDown_Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }
        //Set a date below and timer will count untill a date entered
        DateTime endTime = new DateTime(2022,12,14,00,00,00 ); //Retirement date
        //Timer method and Engine of the program
        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan time = endTime.Subtract(DateTime.Now);

            //months.Text = time.Days.ToString();
            days.Text = time.Days.ToString();
            hours.Text = time.Hours.ToString();
            minutes.Text = time.Minutes.ToString();
            seconds.Text = time.Seconds.ToString();
        }
        //Picture box to close the form
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
