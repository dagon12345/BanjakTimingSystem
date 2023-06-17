
namespace BanjakCarrascalTimingSystemFinal
{
    partial class frm_nameandevent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_nameandevent));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_racername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_category = new System.Windows.Forms.ComboBox();
            this.cmb_stage = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dt_timestart = new System.Windows.Forms.DateTimePicker();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.btn_updateconfirm = new System.Windows.Forms.Button();
            this.panel_1 = new System.Windows.Forms.Panel();
            this.cmb_event = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_date = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_2 = new System.Windows.Forms.Panel();
            this.txt_plate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_data = new System.Windows.Forms.Label();
            this.lbl_data2 = new System.Windows.Forms.Label();
            this.lbl_data3 = new System.Windows.Forms.Label();
            this.btn_print = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_1.SuspendLayout();
            this.panel_2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 30);
            this.panel1.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Racer Name and Event Attended";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(382, 171);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(528, 20);
            this.txt_search.TabIndex = 6;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(379, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "Search";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(382, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(528, 338);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clear.Location = new System.Drawing.Point(15, 462);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(128, 28);
            this.btn_clear.TabIndex = 2;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.Location = new System.Drawing.Point(145, 524);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(108, 30);
            this.btn_update.TabIndex = 4;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(269, 524);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(107, 30);
            this.btn_delete.TabIndex = 5;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(15, 524);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(107, 30);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "SAVE";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_racername
            // 
            this.txt_racername.Location = new System.Drawing.Point(16, 34);
            this.txt_racername.Name = "txt_racername";
            this.txt_racername.Size = new System.Drawing.Size(329, 20);
            this.txt_racername.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 38;
            this.label1.Text = "Racer Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 16);
            this.label6.TabIndex = 43;
            this.label6.Text = "Select Category";
            // 
            // cmb_category
            // 
            this.cmb_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_category.FormattingEnabled = true;
            this.cmb_category.Location = new System.Drawing.Point(28, 156);
            this.cmb_category.Name = "cmb_category";
            this.cmb_category.Size = new System.Drawing.Size(260, 21);
            this.cmb_category.TabIndex = 3;
            // 
            // cmb_stage
            // 
            this.cmb_stage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_stage.FormattingEnabled = true;
            this.cmb_stage.Location = new System.Drawing.Point(28, 111);
            this.cmb_stage.Name = "cmb_stage";
            this.cmb_stage.Size = new System.Drawing.Size(260, 21);
            this.cmb_stage.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 45;
            this.label7.Text = "Select Stage";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 16);
            this.label8.TabIndex = 47;
            this.label8.Text = "Time Start";
            // 
            // dt_timestart
            // 
            this.dt_timestart.CustomFormat = "hh:mm:ss tt";
            this.dt_timestart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_timestart.Location = new System.Drawing.Point(19, 140);
            this.dt_timestart.Name = "dt_timestart";
            this.dt_timestart.Size = new System.Drawing.Size(326, 20);
            this.dt_timestart.TabIndex = 2;
            // 
            // btn_confirm
            // 
            this.btn_confirm.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_confirm.Location = new System.Drawing.Point(14, 240);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(82, 28);
            this.btn_confirm.TabIndex = 0;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // btn_updateconfirm
            // 
            this.btn_updateconfirm.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateconfirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_updateconfirm.Location = new System.Drawing.Point(102, 240);
            this.btn_updateconfirm.Name = "btn_updateconfirm";
            this.btn_updateconfirm.Size = new System.Drawing.Size(82, 28);
            this.btn_updateconfirm.TabIndex = 1;
            this.btn_updateconfirm.Text = "Update";
            this.btn_updateconfirm.UseVisualStyleBackColor = true;
            this.btn_updateconfirm.Click += new System.EventHandler(this.btn_updateconfirm_Click);
            // 
            // panel_1
            // 
            this.panel_1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel_1.Controls.Add(this.cmb_stage);
            this.panel_1.Controls.Add(this.label6);
            this.panel_1.Controls.Add(this.cmb_category);
            this.panel_1.Controls.Add(this.cmb_event);
            this.panel_1.Controls.Add(this.label7);
            this.panel_1.Controls.Add(this.label2);
            this.panel_1.Controls.Add(this.txt_date);
            this.panel_1.Controls.Add(this.label4);
            this.panel_1.Location = new System.Drawing.Point(12, 36);
            this.panel_1.Name = "panel_1";
            this.panel_1.Size = new System.Drawing.Size(364, 198);
            this.panel_1.TabIndex = 50;
            // 
            // cmb_event
            // 
            this.cmb_event.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_event.FormattingEnabled = true;
            this.cmb_event.Location = new System.Drawing.Point(28, 28);
            this.cmb_event.Name = "cmb_event";
            this.cmb_event.Size = new System.Drawing.Size(260, 21);
            this.cmb_event.TabIndex = 0;
            this.cmb_event.SelectedIndexChanged += new System.EventHandler(this.cmb_event_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 40;
            this.label2.Text = "Event Attended";
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(28, 71);
            this.txt_date.Name = "txt_date";
            this.txt_date.ReadOnly = true;
            this.txt_date.Size = new System.Drawing.Size(260, 20);
            this.txt_date.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 42;
            this.label4.Text = "Date of event";
            // 
            // panel_2
            // 
            this.panel_2.BackColor = System.Drawing.Color.SandyBrown;
            this.panel_2.Controls.Add(this.txt_plate);
            this.panel_2.Controls.Add(this.label10);
            this.panel_2.Controls.Add(this.txt_racername);
            this.panel_2.Controls.Add(this.label1);
            this.panel_2.Controls.Add(this.dt_timestart);
            this.panel_2.Controls.Add(this.label8);
            this.panel_2.Enabled = false;
            this.panel_2.Location = new System.Drawing.Point(12, 274);
            this.panel_2.Name = "panel_2";
            this.panel_2.Size = new System.Drawing.Size(364, 182);
            this.panel_2.TabIndex = 51;
            // 
            // txt_plate
            // 
            this.txt_plate.Location = new System.Drawing.Point(16, 85);
            this.txt_plate.Name = "txt_plate";
            this.txt_plate.Size = new System.Drawing.Size(329, 20);
            this.txt_plate.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 16);
            this.label10.TabIndex = 49;
            this.label10.Text = "Race Plate No.";
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_search.Location = new System.Drawing.Point(382, 195);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(82, 28);
            this.btn_search.TabIndex = 7;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_refresh.Location = new System.Drawing.Point(470, 195);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(82, 28);
            this.btn_refresh.TabIndex = 8;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(382, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 16);
            this.label9.TabIndex = 54;
            this.label9.Text = "Data\'s Showing:";
            // 
            // lbl_data
            // 
            this.lbl_data.AutoSize = true;
            this.lbl_data.BackColor = System.Drawing.Color.SeaGreen;
            this.lbl_data.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_data.ForeColor = System.Drawing.Color.White;
            this.lbl_data.Location = new System.Drawing.Point(382, 57);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(58, 16);
            this.lbl_data.TabIndex = 54;
            this.lbl_data.Text = "----------";
            this.lbl_data.Click += new System.EventHandler(this.label10_Click);
            // 
            // lbl_data2
            // 
            this.lbl_data2.AutoSize = true;
            this.lbl_data2.BackColor = System.Drawing.Color.SeaGreen;
            this.lbl_data2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_data2.ForeColor = System.Drawing.Color.White;
            this.lbl_data2.Location = new System.Drawing.Point(382, 91);
            this.lbl_data2.Name = "lbl_data2";
            this.lbl_data2.Size = new System.Drawing.Size(58, 16);
            this.lbl_data2.TabIndex = 55;
            this.lbl_data2.Text = "----------";
            // 
            // lbl_data3
            // 
            this.lbl_data3.AutoSize = true;
            this.lbl_data3.BackColor = System.Drawing.Color.SeaGreen;
            this.lbl_data3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_data3.ForeColor = System.Drawing.Color.White;
            this.lbl_data3.Location = new System.Drawing.Point(382, 128);
            this.lbl_data3.Name = "lbl_data3";
            this.lbl_data3.Size = new System.Drawing.Size(58, 16);
            this.lbl_data3.TabIndex = 56;
            this.lbl_data3.Text = "----------";
            // 
            // btn_print
            // 
            this.btn_print.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_print.Location = new System.Drawing.Point(382, 573);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(156, 26);
            this.btn_print.TabIndex = 57;
            this.btn_print.Text = "Print report";
            this.btn_print.UseVisualStyleBackColor = true;
            // 
            // frm_nameandevent
            // 
            this.AcceptButton = this.btn_save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 611);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.lbl_data3);
            this.Controls.Add(this.lbl_data2);
            this.Controls.Add(this.lbl_data);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.panel_2);
            this.Controls.Add(this.btn_updateconfirm);
            this.Controls.Add(this.panel_1);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_nameandevent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Name and Event Attended";
            this.Load += new System.EventHandler(this.frm_nameandevent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_1.ResumeLayout(false);
            this.panel_1.PerformLayout();
            this.panel_2.ResumeLayout(false);
            this.panel_2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_racername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_category;
        private System.Windows.Forms.ComboBox cmb_stage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dt_timestart;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Button btn_updateconfirm;
        private System.Windows.Forms.Panel panel_1;
        private System.Windows.Forms.Panel panel_2;
        private System.Windows.Forms.ComboBox cmb_event;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_data;
        private System.Windows.Forms.Label lbl_data2;
        private System.Windows.Forms.Label lbl_data3;
        private System.Windows.Forms.TextBox txt_plate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_print;
    }
}