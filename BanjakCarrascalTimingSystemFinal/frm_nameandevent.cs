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
    public partial class frm_nameandevent : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\BanjakDatabase.mdf;Integrated Security=True;User Instance=True");
        public frm_nameandevent()
        {
            InitializeComponent();
        }

        private void frm_nameandevent_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            comboevent();
            combocategory();
            //display();
            combostage();
        }

        public void display()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from racerandevent_db where EventAttended ='" + cmb_event.Text + "' and  Stage ='" + cmb_stage.Text + "' and  Category ='" + cmb_category.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            this.dataGridView1.Columns["id"].Visible = false;

            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


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
        public void clear()
        {
            txt_racername.Clear();
            txt_plate.Clear();
           // cmb_event.Text = "";
           // txt_date.Clear();
            txt_racername.Focus();
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

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_racername.Text == "" || cmb_event.Text == "" || txt_plate.Text == "")
            {
                MessageBox.Show("Please Fill All the Fields!");
            }
            else
            {
                int i = 0;
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from racerandevent_db where Name='" + txt_racername.Text + "' and EventAttended='"+ cmb_event.Text +"' and Stage='"+ cmb_stage.Text +"'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                i = Convert.ToInt32(dt.Rows.Count.ToString());
                if (i == 0)
                {

                    SqlCommand cmd1 = con.CreateCommand();
                    cmd1.CommandType = CommandType.Text;
                    cmd1.CommandText = "insert into racerandevent_db values ('" + txt_racername.Text + "','" + txt_plate.Text + "','" + cmb_event.Text + "','"+ txt_date.Text + "','" + cmb_stage.Text + "','" + cmb_category.Text + "','" + dt_timestart.Value.ToString("hh:mm:ss tt") + "')";
                    cmd1.ExecuteNonQuery();



                    display();
                    MessageBox.Show("Data Added Successfully!.","Success");
                    clear();


                }
                else
                {
                    MessageBox.Show("Racer Data Already Exist at this stage and event Please Enter Another.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_racername.Text == "")
            {
                MessageBox.Show("Select data you want to update.");
            }
            else
            {


                int i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update racerandevent_db set Name = '" + txt_racername.Text + "', RacePlateNo = '" + txt_plate.Text + "' ,EventAttended = '" + cmb_event.Text + "',Date = '" + txt_date.Text + "',Stage = '" + cmb_stage.Text + "',Category = '" + cmb_category.Text + "',TimeStart = '" + dt_timestart.Value.ToString("hh:mm:ss tt") + "' where id='" + i + "'";
                cmd.ExecuteNonQuery();



                display();
                MessageBox.Show("Successfully Updated");
                clear();

            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (txt_racername.Text == "")
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
                    cmd.CommandText = "delete from racerandevent_db where id=" + id + "";
                    cmd.ExecuteNonQuery();
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
                cmd.CommandText = "select * from racerandevent_db where id=" + i + "";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    txt_racername.Text = dr["Name"].ToString();
                    cmb_event.Text = dr["EventAttended"].ToString();
                    txt_date.Text = dr["Date"].ToString();
                    dt_timestart.Text = dr["TimeStart"].ToString();
                    txt_plate.Text = dr["RacePlateNo"].ToString();

                }


            }
            catch (Exception)
            {
                MessageBox.Show("Empty Column!");
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            /*
            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from racerandevent_db where Name = '" + txt_search.Text + "' and EventAttended ='" + cmb_event.Text + "' and  Stage ='" + cmb_stage.Text + "' and  Category ='" + cmb_category.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                this.dataGridView1.Columns["id"].Visible = false;
        
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            */
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if(cmb_stage.Text == "" || cmb_category.Text == "")
            {
                MessageBox.Show("Please fill all the fields before confirming","Fill",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                cmb_stage.Focus();

            }
            else
            {

                try
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from racerandevent_db where EventAttended ='" + cmb_event.Text + "' and  Stage ='" + cmb_stage.Text + "' and  Category ='" + cmb_category.Text + "' ORDER BY id  DESC ";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    this.dataGridView1.Columns["id"].Visible = false;

                    dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;




                    lbl_data.Text = "Event Name: " + cmb_event.Text ;

                    lbl_data2.Text = "Stage: " + cmb_stage.Text;

                    lbl_data3.Text = "Category: " + cmb_category.Text;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }



                panel_2.Enabled = true;
                panel_1.Enabled = false;
                btn_confirm.Enabled = false;
                txt_racername.Focus();
            }
        }

        private void btn_updateconfirm_Click(object sender, EventArgs e)
        {
            panel_1.Enabled = true;
            panel_2.Enabled = false;
            btn_confirm.Enabled = true;
            lbl_data.Text = "----------";
            lbl_data2.Text = "----------";
            lbl_data3.Text = "----------";
            cmb_stage.Focus();


        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (txt_search.Text == "")
            {
                MessageBox.Show("Please fill all the search field.", "Fill", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_search.Focus();
            }
            else
            {
                try
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from racerandevent_db where Name like '" + txt_search.Text + "%' AND EventAttended ='" + cmb_event.Text + "' and  Stage ='" + cmb_stage.Text + "' and  Category ='" + cmb_category.Text + "'ORDER BY id  DESC"; 
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    this.dataGridView1.Columns["id"].Visible = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from racerandevent_db where EventAttended ='" + cmb_event.Text + "' and  Stage ='" + cmb_stage.Text + "' and  Category ='" + cmb_category.Text + "'ORDER BY id  DESC";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                this.dataGridView1.Columns["id"].Visible = false;

                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
