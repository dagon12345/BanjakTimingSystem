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
using System.Globalization;

namespace BanjakCarrascalTimingSystemFinal
{
    public partial class frm_timeadding : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\BanjakDatabase.mdf;Integrated Security=True;User Instance=True");
        public frm_timeadding()
        {
            InitializeComponent();
        }

        private void frm_timeadding_Load(object sender, EventArgs e)
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
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from racerandevent_db where EventAttended ='" + cmb_event.Text + "' and  Stage ='" + cmb_stage.Text + "' and  Category ='" + cmb_category.Text + "' ORDER BY id ASC ";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dataGridView2.DataSource = dt;
                    this.dataGridView2.Columns["id"].Visible = false;
                    this.dataGridView2.Columns["EventAttended"].Visible = false;
                    this.dataGridView2.Columns["Date"].Visible = false;
                    this.dataGridView2.Columns["Stage"].Visible = false;
                    this.dataGridView2.Columns["Category"].Visible = false;
                      dataGridView2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                      dataGridView2.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                      dataGridView2.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                  //  dataGridView2.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                  //  dataGridView2.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                  //  dataGridView2.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                  //  dataGridView2.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                  //  dataGridView2.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;




                    lbl_data.Text = "Event Name: " + cmb_event.Text;

                    lbl_data2.Text = "Stage: " + cmb_stage.Text;

                    lbl_data3.Text = "Category: " + cmb_category.Text;



                    ///////////
                    ///TIME ADD
                    ///


                    SqlCommand cmd0 = con.CreateCommand();
                    cmd0.CommandType = CommandType.Text;
                    cmd0.CommandText = "select * from timeadd_db where EventName ='" + cmb_event.Text + "' and  Stage ='" + cmb_stage.Text + "' and  Category ='" + cmb_category.Text + "' ORDER BY Time ASC ";
                    //cmd0.CommandText = "select FORMAT(TimeAssigned, 'hh:mm:ss.fff') AS TimeWithMilliseconds from timeadd_db ";
                    cmd0.ExecuteNonQuery();
                    DataTable dt0 = new DataTable();
                    SqlDataAdapter da0 = new SqlDataAdapter(cmd0);
                    da0.Fill(dt0);
                    dataGridView1.DataSource = dt0;
                    this.dataGridView1.Columns["id"].Visible = false;

                    dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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
            dataGridView2.DataSource = null;
            dataGridView1.DataSource = null;
            clear();
            cmb_stage.Focus();
        }
        public void clear()
        {
            txt_racername.Text = "----------";
            txt_plate.Text = "----------";
            // cmb_event.Text = "";
            // txt_date.Clear();
            txtoveralltime.ResetText();
            txt_finished.ResetText();
            txt_timestart.ResetText();
            btn_update.Enabled = true;
            btn_delete.Enabled = true;

            txt_racername.Focus();
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
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
        public void timeadddisplay()
        {   

            SqlCommand cmd0 = con.CreateCommand();
            cmd0.CommandType = CommandType.Text;
            cmd0.CommandText = "select *  FROM timeadd_db where EventName ='" + cmb_event.Text + "' and  Stage ='" + cmb_stage.Text + "' and  Category ='" + cmb_category.Text + "' ORDER BY time ASC ";
            cmd0.ExecuteNonQuery();
            DataTable dt0 = new DataTable();
            SqlDataAdapter da0 = new SqlDataAdapter(cmd0);
            da0.Fill(dt0);
            dataGridView1.DataSource = dt0;
            this.dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; 
        }

        private void btn_save_Click(object sender, EventArgs e)

        {
            try
            {
                if (txt_racername.Text == "----------" || cmb_event.Text == "----------" || txt_plate.Text == "----------")
                {
                    MessageBox.Show("Please Fill All the Fields!");
                }
                else
                {
                    int i = 0;
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from timeadd_db where RacerName='" + txt_racername.Text + "' and EventName='" + cmb_event.Text + "' and Stage='" + cmb_stage.Text + "'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    i = Convert.ToInt32(dt.Rows.Count.ToString());
                    if (i == 0)
                    {



                        //dt_time.Value.ToString("HH:mm:ss.fff")

                        string input = txtoveralltime.Text;
                        DateTime time;

                        // Parse the input time value into a DateTime variable
                        if (DateTime.TryParse(input, out time))
                        {
                            // Add minutes to the time value
                            int millisecondstoAdd = 000;
                            time = time.AddMilliseconds(millisecondstoAdd);

                            // Update the TextBox with the new time value
                            txtoveralltime.Text = time.ToString("HH:mm:ss.fff");
                        }




                        SqlCommand cmd1 = con.CreateCommand();
                        cmd1.CommandType = CommandType.Text;
                        cmd1.CommandText = "insert into timeadd_db values ('" + txt_racername.Text + "','" + txt_plate.Text + "','" + txt_timestart.Text + "','" + txt_finished.Text + "','" + txtoveralltime.Text + "','" + cmb_stage.Text + "','" + cmb_category.Text + "','" + cmb_event.Text + "','" + txt_date.Text + "')";
                        cmd1.ExecuteNonQuery();


                        


                        timeadddisplay();
                        MessageBox.Show("Data Added Successfully!.", "Success");
                        clear();


                    }
                    else
                    {
                        MessageBox.Show("Racer Data Already Exist at this stage and event Please Enter Another.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

            
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                int i = Convert.ToInt32(dataGridView2.SelectedCells[0].Value.ToString());




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
                    txt_plate.Text = dr["RacePlateNo"].ToString();
                    txt_timestart.Text = dr["TimeStart"].ToString();
                    txt_finished.Text = dr["TimeStart"].ToString();


                    string timeString1 = txt_timestart.Text;
                    string timeString2 = txt_finished.Text;

                    TimeSpan timeSpan1, timeSpan2;

                    // Parse the input time values with milliseconds
                    if (TimeSpan.TryParseExact(timeString1, @"hh\:mm\:ss\.fff", CultureInfo.InvariantCulture, out timeSpan1) &&
                        TimeSpan.TryParseExact(timeString2, @"hh\:mm\:ss\.fff", CultureInfo.InvariantCulture, out timeSpan2))
                    {
                        // Perform the addition
                        TimeSpan sum = timeSpan1 - timeSpan2;

                        // Display the result with the desired precision
                        string sumString = sum.ToString(@"hh\:mm\:ss\.fff");
                        txtoveralltime.Text = sum.ToString();
                    }



                    txt_finished.Focus();
                }

                btn_update.Enabled = false;

                btn_delete.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                    cmd.CommandText = "select * from racerandevent_db where Name like '"+txt_search.Text+"%' OR RacePlateNo like '" + txt_search.Text + "%' AND EventAttended ='" + cmb_event.Text + "' and  Stage ='" + cmb_stage.Text + "' and  Category ='" + cmb_category.Text + "'ORDER BY id  DESC";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dataGridView2.DataSource = dt;
                    this.dataGridView2.Columns["id"].Visible = false;

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
                cmd.CommandText = "select * from racerandevent_db where EventAttended ='" + cmb_event.Text + "' and  Stage ='" + cmb_stage.Text + "' and  Category ='" + cmb_category.Text + "' ORDER BY id ASC ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView2.DataSource = dt;
                this.dataGridView2.Columns["id"].Visible = false;
                this.dataGridView2.Columns["EventAttended"].Visible = false;
                this.dataGridView2.Columns["Date"].Visible = false;
                this.dataGridView2.Columns["Stage"].Visible = false;
                this.dataGridView2.Columns["Category"].Visible = false;
                dataGridView2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView2.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView2.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                //  dataGridView2.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                //  dataGridView2.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                //  dataGridView2.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                //  dataGridView2.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                //  dataGridView2.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;




                lbl_data.Text = "Event Name: " + cmb_event.Text;

                lbl_data2.Text = "Stage: " + cmb_stage.Text;

                lbl_data3.Text = "Category: " + cmb_category.Text;



                ///////////
                ///TIME ADD
                ///


                SqlCommand cmd0 = con.CreateCommand();
                cmd0.CommandType = CommandType.Text;
                cmd0.CommandText = "select * from timeadd_db where EventName ='" + cmb_event.Text + "' and  Stage ='" + cmb_stage.Text + "' and  Category ='" + cmb_category.Text + "' ORDER BY Time ASC ";
                //cmd0.CommandText = "select FORMAT(TimeAssigned, 'hh:mm:ss.fff') AS TimeWithMilliseconds from timeadd_db ";
                cmd0.ExecuteNonQuery();
                DataTable dt0 = new DataTable();
                SqlDataAdapter da0 = new SqlDataAdapter(cmd0);
                da0.Fill(dt0);
                dataGridView1.DataSource = dt0;
                this.dataGridView1.Columns["id"].Visible = false;

                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                txt_search.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void lbl_data2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_data_Click(object sender, EventArgs e)
        {

        }

        private void lbl_data3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                    dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (txt_plate.Text == "----------")
            {
                MessageBox.Show("Select what data you want to delete.");
            }

            else if (MessageBox.Show("Delete data?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {

                    //int id;
                   // id = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "delete from timeadd_db WHERE RacePlateNo=" + txt_plate.Text + "";
                    cmd.ExecuteNonQuery();
                    timeadddisplay();
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
                cmd.CommandText = "select * from timeadd_db where id=" + i + "";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    txt_racername.Text = dr["RacerName"].ToString();
                    txt_timestart.Text = dr["TimeAssigned"].ToString();
                    txt_finished.Text = dr["TimeFinished"].ToString();
                    txt_plate.Text = dr["RacePlateNo"].ToString();
                    txtoveralltime.Text = dr["Time"].ToString();

                    txt_finished.Focus();

                    btn_update.Enabled = true;
                    btn_delete.Enabled = true;


                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_racername.Text == "----------")
            {
                MessageBox.Show("Select data you want to update.");
            }
            else if (MessageBox.Show("Are you sure you want to update this data?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string input = txtoveralltime.Text;
                DateTime time;

                // Parse the input time value into a DateTime variable
                if (DateTime.TryParse(input, out time))
                {
                    // Add minutes to the time value
                    int millisecondstoAdd = 000;
                    time = time.AddMilliseconds(millisecondstoAdd);

                    // Update the TextBox with the new time value
                    txtoveralltime.Text = time.ToString("HH:mm:ss.fff");
                }


                int i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update timeadd_db set TimeFinished='"+ txt_finished.Text +"', Time='"+ txtoveralltime.Text +"' WHERE id='" + i + "'";
                cmd.ExecuteNonQuery();



                timeadddisplay();
                MessageBox.Show("Successfully Updated");
                clear();

            }
        }

        private void txt_time_KeyPress(object sender, KeyPressEventArgs e)
        {
      
        }

        private void txt_finished_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
        }

        private void txt_finished_KeyUp(object sender, KeyEventArgs e)
        {
            /*

            string input1 = txt_timestart.Text;
            string input2 = txt_finished.Text;

   


            // Parse the input time values into TimeSpan variables
            if (TimeSpan.TryParse(input1, out TimeSpan time1) && TimeSpan.TryParse(input2, out TimeSpan time2))
            {
                TimeSpan sum = time1 - time2;
               
                txtoveralltime.Text = sum.ToString();

                

            }
            */

            string timeString1 = txt_timestart.Text;
            string timeString2 = txt_finished.Text;

            TimeSpan timeSpan1, timeSpan2;

            // Parse the input time values with milliseconds
            if (TimeSpan.TryParseExact(timeString1, @"hh\:mm\:ss\.fff", CultureInfo.InvariantCulture, out timeSpan1) &&
                TimeSpan.TryParseExact(timeString2, @"hh\:mm\:ss\.fff", CultureInfo.InvariantCulture, out timeSpan2))
            {
                // Perform the addition
                TimeSpan sum = timeSpan1 - timeSpan2;

                // Display the result with the desired precision
                string sumString = sum.ToString(@"hh\:mm\:ss\.fff");
                txtoveralltime.Text = sum.ToString();
            }


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
