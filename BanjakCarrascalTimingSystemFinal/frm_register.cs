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

namespace BanjakCarrascalTimingSystemFinal
{
    public partial class frm_register : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\banjakdatabase.mdf;Integrated Security=True;User Instance=True");
        public frm_register()
        {
            InitializeComponent();
        }

        private void frm_register_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            display();
            login();
        }
        public void login()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM  login_db";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                lblusertype.Text = dr["Usertype"].ToString();
                lblusername.Text = dr["Usertype"].ToString();
            }
        }
        public void clear()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirmpassword.Clear();
            txtConfirmpassword.Enabled = true;
            btn_save.Enabled = true;
            txtUsername.Focus();
        }
        public void display()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from register_db";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            this.dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || cmbUsertype.Text == "" || txtPassword.Text == "" || txtConfirmpassword.Text == "")
            {
                MessageBox.Show("Please Fill the Fields!");
            }
            else if(txtConfirmpassword.Text == txtPassword.Text)
            {
                int i = 0;
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from register_db where Username='" + txtUsername.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                i = Convert.ToInt32(dt.Rows.Count.ToString());
                if (i == 0)
                {
                    SqlCommand cmd1 = con.CreateCommand();
                    cmd1.CommandType = CommandType.Text;
                    cmd1.CommandText = "insert into register_db values ('" + cmbUsertype.Text + "','" + txtUsername.Text + "','" + txtPassword.Text + "')";
                    cmd1.ExecuteNonQuery();



                    SqlCommand cmd2 = con.CreateCommand();
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = "insert into ActivityLogs_db values ('" + DateTime.Now.ToString() + "','" + DateTime.Now.ToString("hh:mm:ss tt") + "' ,'" + lblusername.Text + "','" + " REGISTERED data into the system with the USERNAME " + txtUsername.Text + " and USERTYPE " + cmbUsertype.Text+ "')";
                    cmd2.ExecuteNonQuery();



                    display();
                    MessageBox.Show(" User added Successfully!.");
                    clear();



                }
                else
                {
                    MessageBox.Show("UsernName Already Exist Please Enter Another.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsername.Focus();
                }
            }
            else
            {
                MessageBox.Show("Password did not match try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Select what data you want to delete.");
            }

            else if (MessageBox.Show("Delete data?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {

                    int id;
                    id = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "delete from register_db where id=" + id + "";
                    cmd.ExecuteNonQuery();


                    SqlCommand cmd2 = con.CreateCommand();
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = "insert into ActivityLogs_db values ('" + DateTime.Now.ToString() + "','" + DateTime.Now.ToString("hh:mm:ss tt") + "' ,'" + lblusername.Text + "','" + " DELETED data into the system with the USERNAME " + txtUsername.Text + " and USERTYPE " + cmbUsertype.Text + "')";
                    cmd2.ExecuteNonQuery();


                    display();
                    MessageBox.Show("Successfully Deleted!");
                    clear();

                }
                catch (Exception)
                {
                    MessageBox.Show("Empty!");
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                int i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from register_db where id=" + i + "";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    cmbUsertype.Text = dr["Usertype"].ToString();
                    txtUsername.Text = dr["Username"].ToString();
                    txtPassword.Text = dr["Password"].ToString();
                    txtConfirmpassword.Enabled = false;
                    btn_save.Enabled = false;

                }


            }
            catch (Exception)
            {
                MessageBox.Show("Empty Column!");
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
