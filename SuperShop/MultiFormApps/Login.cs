using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MultiFormApps
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();//auto
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if(e.CloseReason != CloseReason.WindowsShutDown) //auto
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e) //login button click
        {

            if (tbUname.Text !=" " && tbPassword.Text !=" ") //validation
            {
                string uname = tbUname.Text;
                string password = tbPassword.Text;
                var conn = Database.ConnectDB();
                conn.Open();
                string query = string.Format("select * from LOGIN where username='{0}' and password='{1}'", uname, password);
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Login Successful");
                    this.Hide();
                    Members mem = new Members();
                    mem.Show();
                }
             else 
                {
                    MessageBox.Show("Password or username is incorrect!");
                   
                }
            }
          else
            {
                MessageBox.Show("Please provide username and passwrod both");
            }
            

        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            tbUname.Text = null;
            tbPassword.Text = null;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
