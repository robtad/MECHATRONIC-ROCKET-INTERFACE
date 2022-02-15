using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.ChildForms
{
    public partial class DashboardForm : Form
    {
        int milliSec, sec, min, hour;
        bool isActive;

        private void btnStop_Click(object sender, EventArgs e)
        {
            isActive = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            isActive=false;
            resetTime();
        }

        private void resetTime()
        {
            milliSec = 0;
            sec = 0;
            min = 0;
            hour = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isActive)
            {
                milliSec++;
                if(milliSec >= 100)
                {
                    sec++;
                    milliSec = 0;
                    if(sec >= 60)
                    {
                        min++;
                        sec = 0;
                        if(min >= 60)
                        {
                            hour++;
                            min = 0;
                        }
                    }
                }
            }

            writeTime();

        }

        private void writeTime()
        {
            lblMilliSecond.Text = String.Format("{0:00}", milliSec);
            lblSecond.Text = String.Format("{0:00}", sec);
            lblMinute.Text = String.Format("{0:00}", min);
            lblHour.Text = String.Format("{0:00}", hour);

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            isActive = true;
        }

        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            resetTime();
            isActive = false;

        }
    }
}
