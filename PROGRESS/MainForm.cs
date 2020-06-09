using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace PROGRESS
{
    public partial class MainForm : Form
    {
        int num = 0;
        const int MAX = 100;
        const int STEPS = 1;

        public MainForm()
        {
            InitializeComponent();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            this.MyTimer.Start();
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            this.RollingPrb.Increment(STEPS);
            num = num + STEPS;
            PercentageLbl.Text = num.ToString() + "%";
            if (num > MAX)
            {
                this.MyTimer.Stop();
                PercentageLbl.Text = "100%";
            }
        }
    }
}
