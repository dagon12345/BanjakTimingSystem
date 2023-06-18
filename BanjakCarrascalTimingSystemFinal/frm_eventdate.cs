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
    public partial class frm_eventdate : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\BanjakDatabase.mdf;Integrated Security=True;User Instance=True");

        public frm_eventdate()
        {
            InitializeComponent();
        }

        private void frm_eventdate_Load(object sender, EventArgs e)
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

        public void display()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from eventname_db";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            this.dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


        }

        public void clear()
        {
            txt_eventname.Clear();
            dt_date.ResetText();
            txt_eventname.Focus();


        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_eventname.Text == "" )
            {
                MessageBox.Show("Please Fill All the Fields!");
            }
            else
            {
                int i = 0;
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from eventname_db where EventName='" + txt_eventname.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                i = Convert.ToInt32(dt.Rows.Count.ToString());
                if (i == 0)
                {

                    SqlCommand cmd1 = con.CreateCommand();
                    cmd1.CommandType = CommandType.Text;
                    cmd1.CommandText = "insert into eventname_db values ('" + txt_eventname.Text + "','" + dt_date.Value.ToString("MM/dd/yyyy") + "')";
                    cmd1.ExecuteNonQuery();


                    SqlCommand cmd2 = con.CreateCommand();
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = "insert into ActivityLogs_db values ('" + DateTime.Now.ToString() + "','" + DateTime.Now.ToString("hh:mm:ss tt") + "' ,'" + lblusername.Text + "','" + " ADDED EVENT NAME into the system with the EVENT NAME " + txt_eventname.Text + " with the DATE " + dt_date.Text + "')";
                    cmd2.ExecuteNonQuery();




                    display();
                    MessageBox.Show(" Event Name Added Successfully!.");
                    clear();


                }
                else
                {
                    MessageBox.Show("Event Name Already Exist Please Enter Another.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_eventname.Text == "")
            {
                MessageBox.Show("Select data you want to update.");
            }
            else
            {


                int i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update eventname_db set EventName = '" + txt_eventname.Text + "',Date = '"+ dt_date.Value.ToString("MM/dd/yyyy") + "' where id='" + i + "'";
                cmd.ExecuteNonQuery();



                SqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "insert into ActivityLogs_db values ('" + DateTime.Now.ToString() + "','" + DateTime.Now.ToString("hh:mm:ss tt") + "' ,'" + lblusername.Text + "','" + " UPDATED EVENT NAME into the system with the EVENT NAME " + txt_eventname.Text + " with the DATE " + dt_date.Text + "')";
                cmd2.ExecuteNonQuery();





                display();
                MessageBox.Show("Successfully Updated");
                clear();

            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (txt_eventname.Text == "")
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
                    cmd.CommandText = "delete from EventName_db where id=" + id + "";
                    cmd.ExecuteNonQuery();

                    SqlCommand cmd2 = con.CreateCommand();
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = "insert into ActivityLogs_db values ('" + DateTime.Now.ToString() + "','" + DateTime.Now.ToString("hh:mm:ss tt") + "' ,'" + lblusername.Text + "','" + " DELETED EVENT NAME into the system with the EVENT NAME " + txt_eventname.Text + " with the DATE " + dt_date.Text + "')";
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
                cmd.CommandText = "select * from eventname_db where id=" + i + "";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    txt_eventname.Text = dr["EventName"].ToString();
                    dt_date.Text = dr["Date"].ToString();

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

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from eventname_db where EventName like '" + txt_search.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                this.dataGridView1.Columns["id"].Visible = false;
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
