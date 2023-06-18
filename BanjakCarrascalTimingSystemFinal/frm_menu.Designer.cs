
namespace BanjakCarrascalTimingSystemFinal
{
    partial class frm_menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStagesNamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEventNameAndDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRacerNameAndEventAttendedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.officialTallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblusername = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblusertype = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SaddleBrown;
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.recordTimeToolStripMenuItem,
            this.officialTallyToolStripMenuItem,
            this.logsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(952, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerAdminToolStripMenuItem,
            this.addCategoryToolStripMenuItem,
            this.addStagesNamesToolStripMenuItem,
            this.addEventNameAndDateToolStripMenuItem,
            this.addRacerNameAndEventAttendedToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.optionsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // registerAdminToolStripMenuItem
            // 
            this.registerAdminToolStripMenuItem.Name = "registerAdminToolStripMenuItem";
            this.registerAdminToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.registerAdminToolStripMenuItem.Text = "Register";
            this.registerAdminToolStripMenuItem.Click += new System.EventHandler(this.registerAdminToolStripMenuItem_Click);
            // 
            // addCategoryToolStripMenuItem
            // 
            this.addCategoryToolStripMenuItem.Name = "addCategoryToolStripMenuItem";
            this.addCategoryToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.addCategoryToolStripMenuItem.Text = "Add Categories";
            this.addCategoryToolStripMenuItem.Click += new System.EventHandler(this.addCategoryToolStripMenuItem_Click);
            // 
            // addStagesNamesToolStripMenuItem
            // 
            this.addStagesNamesToolStripMenuItem.Name = "addStagesNamesToolStripMenuItem";
            this.addStagesNamesToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.addStagesNamesToolStripMenuItem.Text = "Add Stages Names";
            this.addStagesNamesToolStripMenuItem.Click += new System.EventHandler(this.addStagesNamesToolStripMenuItem_Click);
            // 
            // addEventNameAndDateToolStripMenuItem
            // 
            this.addEventNameAndDateToolStripMenuItem.Name = "addEventNameAndDateToolStripMenuItem";
            this.addEventNameAndDateToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.addEventNameAndDateToolStripMenuItem.Text = "Add Event Name and Date";
            this.addEventNameAndDateToolStripMenuItem.Click += new System.EventHandler(this.addEventNameAndDateToolStripMenuItem_Click);
            // 
            // addRacerNameAndEventAttendedToolStripMenuItem
            // 
            this.addRacerNameAndEventAttendedToolStripMenuItem.Name = "addRacerNameAndEventAttendedToolStripMenuItem";
            this.addRacerNameAndEventAttendedToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.addRacerNameAndEventAttendedToolStripMenuItem.Text = "Add Racer Details";
            this.addRacerNameAndEventAttendedToolStripMenuItem.Click += new System.EventHandler(this.addRacerNameAndEventAttendedToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // recordTimeToolStripMenuItem
            // 
            this.recordTimeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.recordTimeToolStripMenuItem.Name = "recordTimeToolStripMenuItem";
            this.recordTimeToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.recordTimeToolStripMenuItem.Text = "Record Time";
            this.recordTimeToolStripMenuItem.Click += new System.EventHandler(this.recordTimeToolStripMenuItem_Click);
            // 
            // officialTallyToolStripMenuItem
            // 
            this.officialTallyToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.officialTallyToolStripMenuItem.Name = "officialTallyToolStripMenuItem";
            this.officialTallyToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.officialTallyToolStripMenuItem.Text = "Official Tally";
            this.officialTallyToolStripMenuItem.Click += new System.EventHandler(this.officialTallyToolStripMenuItem_Click);
            // 
            // logsToolStripMenuItem
            // 
            this.logsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.logsToolStripMenuItem.Name = "logsToolStripMenuItem";
            this.logsToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.logsToolStripMenuItem.Text = "Logs";
            this.logsToolStripMenuItem.Click += new System.EventHandler(this.logsToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblusername,
            this.toolStripStatusLabel3,
            this.lblusertype});
            this.statusStrip1.Location = new System.Drawing.Point(0, 534);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(952, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(63, 17);
            this.toolStripStatusLabel1.Text = "Username:";
            // 
            // lblusername
            // 
            this.lblusername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(32, 17);
            this.lblusername.Text = "-----";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(56, 17);
            this.toolStripStatusLabel3.Text = "Usertype:";
            // 
            // lblusertype
            // 
            this.lblusertype.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusertype.Name = "lblusertype";
            this.lblusertype.Size = new System.Drawing.Size(32, 17);
            this.lblusertype.Tag = "";
            this.lblusertype.Text = "-----";
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 556);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_menu_FormClosed);
            this.Load += new System.EventHandler(this.frm_menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStagesNamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem officialTallyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEventNameAndDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRacerNameAndEventAttendedToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem registerAdminToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblusername;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel lblusertype;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem logsToolStripMenuItem;
    }
}