using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ClickCounter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            timer1.Start();
            Clicks.Text = (Int32.Parse(Clicks.Text)+1).ToString() ;
           
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            this.reset();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblRealTime.Text = (Int32.Parse(lblRealTime.Text.Split(' ')[0]) + 1).ToString() + " s";
            if (Int32.Parse(lblRealTime.Text.Split(' ')[0]) > 5)
            {
                timer1.Stop();
                button1.Enabled = false;
                this.showTimeOut();
            }
        }

        private void lblRealTime_Click(object sender, EventArgs e)
        {

        }


        private void reset()
        {
            if (Int32.Parse(Clicks.Text) > Int32.Parse(lblNumBestScore.Text))
            {
                lblNumBestScore.Text = Clicks.Text;
            }
            Clicks.Text = "0";
            timer1.Stop();
            lblRealTime.Text = "0";
            button1.Enabled = true;
            lblFinish.Enabled = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void showTimeOut()
        {
            lblRealTime.Text = "5 s";
            for (int i = 0; i < 5; i++)
            {
                lblFinish.Enabled = true;
                Thread.Sleep(150);
                lblFinish.Enabled = false;
                Thread.Sleep(150);
            }
            lblFinish.Enabled = true;

        }
    }
}
