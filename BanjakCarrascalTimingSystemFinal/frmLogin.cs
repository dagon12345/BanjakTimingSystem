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
    public partial class frmLogin : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\BanjakDatabase.mdf;Integrated Security=True;User Instance=True");



        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
     
                try
                {
                    //CODE FOR LOGIN FORM

                    string utype = "";
                    int i = 0;


                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from register_db where Usertype='" + txt_usertype.Text + "' and Username='" + txt_username.Text + "' and Password='" + txt_password.Text + "' COLLATE Latin1_General_CS_AS";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);

                    i = Convert.ToInt32(dt.Rows.Count.ToString());
                    if (dt.Rows.Count > 0)
                    {
                        utype = dt.Rows[0][1].ToString();
                        if (utype == "Administrator")
                        {



                        SqlCommand cmd1 = con.CreateCommand();
                        cmd1.CommandType = CommandType.Text;
                        cmd1.CommandText = "update login_db set Usertype='"+txt_usertype.Text+"',Username = '" + txt_username.Text + "'";
                        cmd1.ExecuteNonQuery();



                        SqlCommand cmd2 = con.CreateCommand();
                        cmd2.CommandType = CommandType.Text;
                        cmd2.CommandText = "insert into ActivityLogs_db values ('" + DateTime.Now.ToString() + "','" + DateTime.Now.ToString("hh:mm:ss tt") + "' ,'" + txt_username.Text + "','" + " has logged in into the system " + "')";
                        cmd2.ExecuteNonQuery();

                        this.Hide();
                            frm_menu mf = new frm_menu();
                            mf.Show();


                        
                          
                        

                        }
                        else if (utype == "User")
                        {




                        SqlCommand cmd1 = con.CreateCommand();
                        cmd1.CommandType = CommandType.Text;
                        cmd1.CommandText = "update login_db set Usertype='" + txt_usertype.Text + "',Username = '" + txt_username.Text + "'";
                        cmd1.ExecuteNonQuery();

                        SqlCommand cmd2 = con.CreateCommand();
                        cmd2.CommandType = CommandType.Text;
                        cmd2.CommandText = "insert into ActivityLogs_db values ('" + DateTime.Now.ToString() + "','" + DateTime.Now.ToString("hh:mm:ss tt") + "' ,'" + txt_username.Text + "','" + " has logged in into the system " + "')";
                        cmd2.ExecuteNonQuery();



                        this.Hide();
                        frm_menu mf = new frm_menu();
                        mf.registerAdminToolStripMenuItem.Visible = false;
                        mf.logsToolStripMenuItem.Visible = false;
                        mf.Show();



                     



                    }


                }

                    else
                    {

                        MessageBox.Show("Invalid login details", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
            
         
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM register_db WHERE Username like'" + txt_username.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txt_usertype.Text = dr["Usertype"].ToString();
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
