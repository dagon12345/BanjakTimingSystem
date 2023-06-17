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
    public partial class frm_stages : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\BanjakDatabase.mdf;Integrated Security=True;User Instance=True");
        public frm_stages()
        {
            InitializeComponent();
        }

        private void frm_stages_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            display();
        }

        public void clear()
        {
            txt_stagename.Clear();
            txt_stagename.Focus();
        }
        public void display()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from stages_db";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            this.dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_stagename.Text == "")
            {
                MessageBox.Show("Please Fill the Field!");
            }

            else
            {
                int i = 0;
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from stages_db where StageName='" + txt_stagename.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                i = Convert.ToInt32(dt.Rows.Count.ToString());
                if (i == 0)
                {
                    SqlCommand cmd1 = con.CreateCommand();
                    cmd1.CommandType = CommandType.Text;
                    cmd1.CommandText = "insert into stages_db values ('" + txt_stagename.Text + "')";
                    cmd1.ExecuteNonQuery();



                    display();
                    MessageBox.Show(" Stage Name added Successfully!.");
                    clear();



                }
                else
                {
                    MessageBox.Show("Stage Name Already Exist Please Enter Another.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_stagename.Focus();
                }
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_stagename.Text == "")
            {
                MessageBox.Show("Select data you want to update.");
            }
            else
            {


                int i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update stage_db set CategoryName = '" + txt_stagename.Text + "' where id='" + i + "'";
                cmd.ExecuteNonQuery();



                display();
                MessageBox.Show("Successfully Updated");
                clear();

            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (txt_stagename.Text == "")
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
                    cmd.CommandText = "delete from stages_db where id=" + id + "";
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
                cmd.CommandText = "select * from stages_db where id=" + i + "";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    txt_stagename.Text = dr["StageName"].ToString();

                }


            }
            catch (Exception)
            {
                MessageBox.Show("Empty Column!");
            }
        }
    }
}
