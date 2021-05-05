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
    public partial class Members : Form
    {
        public Members() //auto
        {
            InitializeComponent();
        }
        public void clsscreen() //clear all input field
        {
            custtext.Text = null;
            emailtxt.Text = null;
            phonetxt.Text = null;
            addresstxt.Text = null;
        }

        private void addmembtn_Click(object sender, EventArgs e)
        {
            string customername = custtext.Text;
            string email = emailtxt.Text;
            string phone = phonetxt.Text;
            string address = addresstxt.Text;
            var conn = Database.ConnectDB();
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            string query = string.Format("insert into MEMBER values ('{0}','{1}','{2}','{3}')", customername, email, address, phone);
            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                int r = cmd.ExecuteNonQuery(); //if run successful retrun 1
                if (r > 0)
                {
                    MessageBox.Show("Member Added");
                    this.mEMBERTableAdapter.Fill(this.shopbdDataSet.MEMBER);
                    clsscreen();

                }
                else
                {
                    MessageBox.Show("Failed to add member");
                    this.mEMBERTableAdapter.Fill(this.shopbdDataSet.MEMBER);
                    clsscreen();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        private void Members_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shopbdDataSet.MEMBER' table. You can move, or remove it, as needed.
            this.mEMBERTableAdapter.Fill(this.shopbdDataSet.MEMBER);

        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            delete del = new delete();
            del.Show();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void membersrch_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
