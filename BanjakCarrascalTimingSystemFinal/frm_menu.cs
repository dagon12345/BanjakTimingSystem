using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanjakCarrascalTimingSystemFinal
{
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }

        private void registerAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_register fr = new frm_register();
            fr.Show();
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
    }
}
