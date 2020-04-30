using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ClickCounter
{
    public partial class Form2 : Form
    {
        private SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
        public static String textName="";
        public Form2()
        {
            InitializeComponent();
        }

        public string txtNameValue
        {
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length > 0)
            {
                insertUser();
                this.Hide();
                textName = txtName.Text;
                Form1 form1 = new Form1();
                form1.Show();
            }
            else
            {
                MessageBox.Show("Please write your user name in the name bar", "Error");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        public void insertUser()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Players values('" + txtName.Text + "','" + 0 + "')";
                cmd.ExecuteNonQuery();

                MessageBox.Show("User name inserted successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured The user exists" + ex.ToString(),"Error");
            }
        }

        private void DeleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from Players where name='" + txtName.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("The User: "+txtName.Text+" is Deleted successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured the user don't exist" + ex.ToString(), "Error");
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from Players";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("All users are deleted successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured There is no user" + ex.ToString(), "Error");
            }
           
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (txtName.Text.Length > 0)
            {
                count = signInUser();
                if(count > 0)
                {
                    this.Hide();
                    textName = txtName.Text;
                    Form1 form1 = new Form1();
                    form1.Show();
                }
            }
            else
            {
                MessageBox.Show("Please write your user name in the name bar or if the user exists", "Error");
            }
            
        }

        public int signInUser()
        {
            Int32 count = 0;
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT COUNT(*) FROM Players where name='"+txtName.Text+"'";
                count = (Int32)cmd.ExecuteScalar();
                con.Close();
                if (count > 0)
                {
                    MessageBox.Show("User exists and the count is: " + count);

                }
                else
                {
                    MessageBox.Show("User doesn't exist and the count is: " + count);
                }
                return count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured There is no user" + ex.ToString(), "Error");
            }
            return count;
        }

        private void btnShowUser_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length > 0)
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Select * from Players where name='" + txtName.Text + "'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occured" + ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Please write your user name in the name bar", "Error");
            }
        }

        private void btnShowUsers_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from Players";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

     
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {

           
        }

        private void btnShowBestScores_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from Players ORDER BY bestScore DESC";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}

 