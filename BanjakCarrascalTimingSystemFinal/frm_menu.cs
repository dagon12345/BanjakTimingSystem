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
    public partial class frm_menu : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\BanjakDatabase.mdf;Integrated Security=True;User Instance=True");


        public frm_menu()
        {
            InitializeComponent();
        }

        private void registerAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_register fr = new frm_register();
            fr.Show();
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
        private void addCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_categories fc = new frm_categories();
            fc.Show();
        }

        private void addStagesNamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_stages fs = new frm_stages();
            fs.Show();
        }

        private void addEventNameAndDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_eventdate fe = new frm_eventdate();
            fe.Show();
        }

        private void frm_menu_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            login();
        }

        private void addRacerNameAndEventAttendedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_nameandevent fn = new frm_nameandevent();
            fn.Show();
        }

        private void recordTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_timeadding ft = new frm_timeadding();
            ft.Show();
        }

        private void officialTallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_reportingtime rt = new frm_reportingtime();
            rt.Show();
        }

        private void frm_menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
             if (MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                frmLogin fl = new frmLogin();
                fl.Show();
            }

            }

        private void logsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_logs fl = new frm_logs();
            fl.Show();
        }
    }
}
