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
using System.Data.SqlClient;


namespace ClickCounter
{
    public partial class Form1 : Form
    {
        private SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
        private String closeWith= "Form2";
        public Form1()
        {
            InitializeComponent();
            txtUserNamef1.Text = Form2.textName;
            getBestScore();

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
                if (Int32.Parse(Clicks.Text) > Int32.Parse(lblNumBestScore.Text))
                {
                    lblNumBestScore.Text = Clicks.Text;
                    insertBestScore();
                }
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
                insertBestScore();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        public void getBestScore()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select bestScore from Players where name='"+Form2.textName+"'";
                //ici
                lblNumBestScore.Text = cmd.ExecuteScalar().ToString();
                con.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured" + ex.ToString(), "Error");
            }
        }
        public void insertBestScore()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                //ici modif
                cmd.CommandText = "update Players set bestScore= '" + Int32.Parse(lblNumBestScore.Text) + "' where name= '" + txtUserNamef1.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();   
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured" + ex.ToString());
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if (closeWith == "Form2" && MessageBox.Show("Are you sure to close the game ?", "Mouse Clicker",
              MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Form2 f2 = (Form2)Application.OpenForms["Form2"];
                f2.Close();
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            Form2 f2 = (Form2)Application.OpenForms["Form2"];
            f2.txtNameValue = "";
            f2.Show();
            closeWith = "";
            this.Close();
        }
    }
}
