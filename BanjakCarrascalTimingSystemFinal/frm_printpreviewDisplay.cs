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
    public partial class frm_printpreviewDisplay : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\BanjakDatabase.mdf;Integrated Security=True;User Instance=True");


        string j;
        string s;
        public void get_value(string i)
        {

            j = i;
        }


        public frm_printpreviewDisplay()
        {
            InitializeComponent();
        }

        private void frm_printpreviewDisplay_Load(object sender, EventArgs e)
        {
        
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            PrintDisplayDataSet ds = new PrintDisplayDataSet();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = j;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds.DataTable1);
            da.Fill(dt);

            PrintDisplayCrystal myreport = new PrintDisplayCrystal();
            myreport.SetDataSource(ds);
            crystalReportViewer1.ReportSource = myreport;

        }
    }
}
