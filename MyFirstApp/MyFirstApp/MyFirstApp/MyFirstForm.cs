using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstApp
{
    public partial class MyFirstForm : Form
    {
        int interval = 1000;
        public MyFirstForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hi");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("dandi is gay");

        }

      



        private void tmr_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            tmr.Interval=interval;
            tmr.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tmr.Stop();
        }
    }
}
