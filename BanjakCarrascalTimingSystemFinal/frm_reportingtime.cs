using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BanjakCarrascalTimingSystemFinal
{
    public partial class frm_reportingtime : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\BanjakDatabase.mdf;Integrated Security=True;User Instance=True");
        string query;
        string queryall;


        public frm_reportingtime()
        {
            InitializeComponent();
        }

        private void frm_reportingtime_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            comboevent();
            combocategory();
            combostage();
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


        public void combocategory()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * From category_db";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cmb_category.Items.Add(dr["CategoryName"].ToString());

            }
        }


        public void combostage()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * From stages_db";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cmb_stage.Items.Add(dr["StageName"].ToString());

            }
        }


        public void comboevent()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * From eventname_db";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cmb_event.Items.Add(dr["EventName"].ToString());

            }
        }


        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (cmb_stage.Text == "" || cmb_category.Text == "")
            {
                MessageBox.Show("Please fill all the fields before confirming", "Fill", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmb_stage.Focus();

            }
            else
            {
                try
                {
                    SqlCommand cmd0 = con.CreateCommand();
                    cmd0.CommandType = CommandType.Text;
                    cmd0.CommandText = "select * from timeadd_db where EventName ='" + cmb_event.Text + "' and  Stage ='" + cmb_stage.Text + "' and  Category ='" + cmb_category.Text + "' ORDER BY Time ASC ";
                    cmd0.ExecuteNonQuery();
                    DataTable dt0 = new DataTable();
                    SqlDataAdapter da0 = new SqlDataAdapter(cmd0);
                    da0.Fill(dt0);
                    dataGridView1.DataSource = dt0;
                    this.dataGridView1.Columns["id"].Visible = false;

                    dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


                    lbl_data.Text = "Event Name: " + cmb_event.Text;

                    lbl_data2.Text = "Stage: " + cmb_stage.Text;

                    lbl_data3.Text = "Category: " + cmb_category.Text;


                    query = "select * from timeadd_db where EventName ='" + cmb_event.Text + "' and  Stage ='" + cmb_stage.Text + "' and  Category ='" + cmb_category.Text + "' ORDER BY Time ASC ";

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void cmb_event_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from eventname_db where EventName='" + cmb_event.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {

                cmb_event.Text = dr["EventName"].ToString();
                txt_date.Text = dr["Date"].ToString();



            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_search2.Text == "")
            {
                MessageBox.Show("Please fill all the search field.", "Fill", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_search2.Focus();
            }
            else
            {
                try
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from timeadd_db where RacePlateNo like '" + txt_search2.Text + "%' AND EventName ='" + cmb_event.Text + "' and  Stage ='" + cmb_stage.Text + "' and  Category ='" + cmb_category.Text + "'ORDER BY time ASC";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    this.dataGridView1.Columns["id"].Visible = false;
                    dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
               
                    SqlCommand cmd0 = con.CreateCommand();
                    cmd0.CommandType = CommandType.Text;
                    cmd0.CommandText = "select * from timeadd_db where EventName ='" + cmb_event.Text + "' and  Stage ='" + cmb_stage.Text + "' and  Category ='" + cmb_category.Text + "' ORDER BY Time ASC ";
                    cmd0.ExecuteNonQuery();
                    DataTable dt0 = new DataTable();
                    SqlDataAdapter da0 = new SqlDataAdapter(cmd0);
                    da0.Fill(dt0);
                    dataGridView1.DataSource = dt0;
                    this.dataGridView1.Columns["id"].Visible = false;

                    dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


                    lbl_data.Text = "Event Name: " + cmb_event.Text;

                    lbl_data2.Text = "Stage: " + cmb_stage.Text;

                    lbl_data3.Text = "Category: " + cmb_category.Text;

                    query = "select * from timeadd_db where EventName ='" + cmb_event.Text + "' and  Stage ='" + cmb_stage.Text + "' and  Category ='" + cmb_category.Text + "' ORDER BY Time ASC ";



        }

        private void btn_print1_Click(object sender, EventArgs e)
        {
          if (checkoverall.Checked == false)
            {
                if (cmb_category.Text == "" || cmb_event.Text == "" || cmb_stage.Text == "")
                {
                    MessageBox.Show("Please fill all the fields before printing");
                }
                else  if(dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("Click display first to show data before printing");
                }
                else
                {
                    frm_printpreviewDisplay ppd = new frm_printpreviewDisplay();
                    ppd.get_value(query.ToString());
                    ppd.Show();
                }
            }
            else if(checkoverall.Checked == true)
            {
                if (cmb_event.Text == "")
                {
                    MessageBox.Show("Please enter the name of event.");
                }
                else if (cmb_category.Text == "")
                {
                    MessageBox.Show("Please enter category of event.");
                }
                else
                {
                    if (MessageBox.Show("You are about to print or save overall time depending on event name and age category. Continue?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        displayall();
                        Overallprintpreview opp = new Overallprintpreview();
                        opp.get_value(queryall.ToString());
                        opp.Show();
                    }
                }

            }
        }


        public void displayall()
        {
            SqlCommand cmd0 = con.CreateCommand();
            cmd0.CommandType = CommandType.Text;
            cmd0.CommandText = "select * from timeadd_db where Category ='"+ cmb_category.Text + "' AND  EventName='" + cmb_event.Text + "'";
            cmd0.ExecuteNonQuery();
       
            queryall = "select * from timeadd_db where Category ='" + cmb_category.Text + "' AND  EventName='" + cmb_event.Text + "'";

   

        }
        private void btn_print2_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void checkoverall_CheckedChanged(object sender, EventArgs e)
        {
            if(checkoverall.Checked == true)
            {
                btn_print1.Text = "Print Overall time";
                cmb_stage.Enabled = false;
                btn_confirm.Enabled = false;
            }
            else
            {
                btn_print1.Text = "Print Displayed Only";
                cmb_stage.Enabled = true;
                btn_confirm.Enabled = true;
            }
        }
    }
}
