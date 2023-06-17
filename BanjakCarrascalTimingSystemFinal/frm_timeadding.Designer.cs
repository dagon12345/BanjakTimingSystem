
namespace BanjakCarrascalTimingSystemFinal
{
    partial class frm_timeadding
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_timeadding));
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.panel_1 = new System.Windows.Forms.Panel();
            this.cmb_stage = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_category = new System.Windows.Forms.ComboBox();
            this.cmb_event = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_date = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel_2 = new System.Windows.Forms.Panel();
            this.txttime = new System.Windows.Forms.MaskedTextBox();
            this.lbl_data3 = new System.Windows.Forms.Label();
            this.txt_plate = new System.Windows.Forms.Label();
            this.lbl_data2 = new System.Windows.Forms.Label();
            this.txt_racername = new System.Windows.Forms.Label();
            this.lbl_data = new System.Windows.Forms.Label();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_updateconfirm = new System.Windows.Forms.Button();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_search2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_1.SuspendLayout();
            this.panel_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clear.Location = new System.Drawing.Point(19, 158);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(79, 28);
            this.btn_clear.TabIndex = 61;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.Location = new System.Drawing.Point(104, 229);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(82, 29);
            this.btn_update.TabIndex = 59;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(192, 229);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(82, 28);
            this.btn_delete.TabIndex = 60;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(16, 228);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(82, 28);
            this.btn_save.TabIndex = 58;
            this.btn_save.Text = "SAVE";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // panel_1
            // 
            this.panel_1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel_1.Controls.Add(this.cmb_stage);
            this.panel_1.Controls.Add(this.label2);
            this.panel_1.Controls.Add(this.cmb_category);
            this.panel_1.Controls.Add(this.cmb_event);
            this.panel_1.Controls.Add(this.label7);
            this.panel_1.Controls.Add(this.label5);
            this.panel_1.Controls.Add(this.txt_date);
            this.panel_1.Controls.Add(this.label8);
            this.panel_1.Location = new System.Drawing.Point(12, 8);
            this.panel_1.Name = "panel_1";
            this.panel_1.Size = new System.Drawing.Size(339, 224);
            this.panel_1.TabIndex = 65;
            // 
            // cmb_stage
            // 
            this.cmb_stage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_stage.FormattingEnabled = true;
            this.cmb_stage.Location = new System.Drawing.Point(28, 122);
            this.cmb_stage.Name = "cmb_stage";
            this.cmb_stage.Size = new System.Drawing.Size(260, 21);
            this.cmb_stage.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 43;
            this.label2.Text = "Select Category";
            // 
            // cmb_category
            // 
            this.cmb_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_category.FormattingEnabled = true;
            this.cmb_category.Location = new System.Drawing.Point(28, 167);
            this.cmb_category.Name = "cmb_category";
            this.cmb_category.Size = new System.Drawing.Size(260, 21);
            this.cmb_category.TabIndex = 3;
            // 
            // cmb_event
            // 
            this.cmb_event.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_event.FormattingEnabled = true;
            this.cmb_event.Location = new System.Drawing.Point(28, 39);
            this.cmb_event.Name = "cmb_event";
            this.cmb_event.Size = new System.Drawing.Size(260, 21);
            this.cmb_event.TabIndex = 0;
            this.cmb_event.SelectedIndexChanged += new System.EventHandler(this.cmb_event_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 45;
            this.label7.Text = "Select Stage";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 40;
            this.label5.Text = "Event Attended";
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(28, 82);
            this.txt_date.Name = "txt_date";
            this.txt_date.ReadOnly = true;
            this.txt_date.Size = new System.Drawing.Size(260, 20);
            this.txt_date.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 16);
            this.label8.TabIndex = 42;
            this.label8.Text = "Date of event";
            // 
            // panel_2
            // 
            this.panel_2.BackColor = System.Drawing.Color.SandyBrown;
            this.panel_2.Controls.Add(this.txttime);
            this.panel_2.Controls.Add(this.lbl_data3);
            this.panel_2.Controls.Add(this.txt_plate);
            this.panel_2.Controls.Add(this.lbl_data2);
            this.panel_2.Controls.Add(this.txt_racername);
            this.panel_2.Controls.Add(this.lbl_data);
            this.panel_2.Controls.Add(this.btn_refresh);
            this.panel_2.Controls.Add(this.label9);
            this.panel_2.Controls.Add(this.btn_search);
            this.panel_2.Controls.Add(this.label10);
            this.panel_2.Controls.Add(this.btn_clear);
            this.panel_2.Controls.Add(this.txt_search);
            this.panel_2.Controls.Add(this.label6);
            this.panel_2.Controls.Add(this.dataGridView2);
            this.panel_2.Controls.Add(this.label1);
            this.panel_2.Controls.Add(this.label4);
            this.panel_2.Controls.Add(this.btn_save);
            this.panel_2.Controls.Add(this.btn_delete);
            this.panel_2.Controls.Add(this.btn_update);
            this.panel_2.Enabled = false;
            this.panel_2.Location = new System.Drawing.Point(357, 8);
            this.panel_2.Name = "panel_2";
            this.panel_2.Size = new System.Drawing.Size(704, 271);
            this.panel_2.TabIndex = 52;
            // 
            // txttime
            // 
            this.txttime.Location = new System.Drawing.Point(18, 132);
            this.txttime.Mask = "00:00:00.000";
            this.txttime.Name = "txttime";
            this.txttime.Size = new System.Drawing.Size(216, 20);
            this.txttime.TabIndex = 87;
            this.txttime.ValidatingType = typeof(System.DateTime);
            // 
            // lbl_data3
            // 
            this.lbl_data3.AutoSize = true;
            this.lbl_data3.BackColor = System.Drawing.Color.Black;
            this.lbl_data3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_data3.ForeColor = System.Drawing.Color.White;
            this.lbl_data3.Location = new System.Drawing.Point(331, 245);
            this.lbl_data3.Name = "lbl_data3";
            this.lbl_data3.Size = new System.Drawing.Size(58, 16);
            this.lbl_data3.TabIndex = 84;
            this.lbl_data3.Text = "----------";
            this.lbl_data3.Click += new System.EventHandler(this.lbl_data3_Click);
            // 
            // txt_plate
            // 
            this.txt_plate.AutoSize = true;
            this.txt_plate.BackColor = System.Drawing.Color.SaddleBrown;
            this.txt_plate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_plate.ForeColor = System.Drawing.Color.White;
            this.txt_plate.Location = new System.Drawing.Point(19, 85);
            this.txt_plate.Name = "txt_plate";
            this.txt_plate.Size = new System.Drawing.Size(58, 16);
            this.txt_plate.TabIndex = 85;
            this.txt_plate.Text = "----------";
            // 
            // lbl_data2
            // 
            this.lbl_data2.AutoSize = true;
            this.lbl_data2.BackColor = System.Drawing.Color.Black;
            this.lbl_data2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_data2.ForeColor = System.Drawing.Color.White;
            this.lbl_data2.Location = new System.Drawing.Point(331, 219);
            this.lbl_data2.Name = "lbl_data2";
            this.lbl_data2.Size = new System.Drawing.Size(58, 16);
            this.lbl_data2.TabIndex = 83;
            this.lbl_data2.Text = "----------";
            this.lbl_data2.Click += new System.EventHandler(this.lbl_data2_Click);
            // 
            // txt_racername
            // 
            this.txt_racername.AutoSize = true;
            this.txt_racername.BackColor = System.Drawing.Color.SaddleBrown;
            this.txt_racername.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_racername.ForeColor = System.Drawing.Color.White;
            this.txt_racername.Location = new System.Drawing.Point(19, 30);
            this.txt_racername.Name = "txt_racername";
            this.txt_racername.Size = new System.Drawing.Size(58, 16);
            this.txt_racername.TabIndex = 85;
            this.txt_racername.Text = "----------";
            // 
            // lbl_data
            // 
            this.lbl_data.AutoSize = true;
            this.lbl_data.BackColor = System.Drawing.Color.Black;
            this.lbl_data.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_data.ForeColor = System.Drawing.Color.White;
            this.lbl_data.Location = new System.Drawing.Point(331, 195);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(58, 16);
            this.lbl_data.TabIndex = 81;
            this.lbl_data.Text = "----------";
            this.lbl_data.Click += new System.EventHandler(this.lbl_data_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_refresh.Location = new System.Drawing.Point(619, 22);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(82, 28);
            this.btn_refresh.TabIndex = 70;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(328, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 16);
            this.label9.TabIndex = 82;
            this.label9.Text = "Data\'s Showing:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_search.Location = new System.Drawing.Point(534, 22);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(82, 28);
            this.btn_search.TabIndex = 69;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 16);
            this.label10.TabIndex = 49;
            this.label10.Text = "Race Plate No.";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(329, 26);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(190, 20);
            this.txt_search.TabIndex = 68;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(326, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 16);
            this.label6.TabIndex = 72;
            this.label6.Text = "Search Racer Plate and Select";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(329, 53);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(372, 111);
            this.dataGridView2.TabIndex = 71;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 38;
            this.label1.Text = "Racer Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(253, 16);
            this.label4.TabIndex = 47;
            this.label4.Text = "Time(Hours:Minutes.Seconds.Milliseconds)";
            // 
            // btn_updateconfirm
            // 
            this.btn_updateconfirm.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateconfirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_updateconfirm.Location = new System.Drawing.Point(99, 238);
            this.btn_updateconfirm.Name = "btn_updateconfirm";
            this.btn_updateconfirm.Size = new System.Drawing.Size(82, 28);
            this.btn_updateconfirm.TabIndex = 67;
            this.btn_updateconfirm.Text = "Update";
            this.btn_updateconfirm.UseVisualStyleBackColor = true;
            this.btn_updateconfirm.Click += new System.EventHandler(this.btn_updateconfirm_Click);
            // 
            // btn_confirm
            // 
            this.btn_confirm.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_confirm.Location = new System.Drawing.Point(11, 238);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(82, 28);
            this.btn_confirm.TabIndex = 66;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 355);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1049, 232);
            this.dataGridView1.TabIndex = 73;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(481, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 28);
            this.button1.TabIndex = 75;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(393, 287);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 28);
            this.button2.TabIndex = 74;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_search2
            // 
            this.txt_search2.Location = new System.Drawing.Point(15, 295);
            this.txt_search2.Name = "txt_search2";
            this.txt_search2.Size = new System.Drawing.Size(372, 20);
            this.txt_search2.TabIndex = 73;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 16);
            this.label3.TabIndex = 76;
            this.label3.Text = "Search and Select Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.SeaGreen;
            this.label11.Location = new System.Drawing.Point(41, 334);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 16);
            this.label11.TabIndex = 77;
            this.label11.Text = "Data sorted by fastest time.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BanjakCarrascalTimingSystemFinal.Properties.Resources.icons8_information_48;
            this.pictureBox1.Location = new System.Drawing.Point(15, 332);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 78;
            this.pictureBox1.TabStop = false;
            // 
            // frm_timeadding
            // 
            this.AcceptButton = this.btn_save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 599);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_updateconfirm);
            this.Controls.Add(this.txt_search2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.panel_2);
            this.Controls.Add(this.panel_1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_timeadding";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time Adding";
            this.Load += new System.EventHandler(this.frm_timeadding_Load);
            this.panel_1.ResumeLayout(false);
            this.panel_1.PerformLayout();
            this.panel_2.ResumeLayout(false);
            this.panel_2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Panel panel_1;
        private System.Windows.Forms.ComboBox cmb_stage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_category;
        private System.Windows.Forms.ComboBox cmb_event;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_date;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel_2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_updateconfirm;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_search2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_data3;
        private System.Windows.Forms.Label lbl_data2;
        private System.Windows.Forms.Label lbl_data;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label txt_plate;
        private System.Windows.Forms.Label txt_racername;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox txttime;
    }
}