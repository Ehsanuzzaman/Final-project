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
    public partial class delete : Form
    {
        public delete()
        {
            InitializeComponent();
        }

        private void delconfbtn_Click(object sender, EventArgs e)
        {
            int ID = Int32.Parse(deltext.Text);
            var conn = Database.ConnectDB();
            conn.Open();
            string query = String.Format("delete from MEMBER where memberid='{0}'", ID);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0)
            {
                MessageBox.Show("Member Deleted");
                this.Close(); //close the delete confrimation window

               
            }
            else
            {
                MessageBox.Show("Member not Deleted");
            }
            Members m = new Members();
            m.Show();

        }

        private void delete_Load(object sender, EventArgs e)
        {

        }
    }
}
