namespace ThuctapCSDL.GUI
{
    partial class frmDeviceProviding
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSelectProvider = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ckbModeProvider = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbListProvider = new System.Windows.Forms.ComboBox();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsAdd = new System.Windows.Forms.ToolStripButton();
            this.tsUpdate = new System.Windows.Forms.ToolStripButton();
            this.tsDelete = new System.Windows.Forms.ToolStripButton();
            this.tsSave = new System.Windows.Forms.ToolStripButton();
            this.tsRefresh = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpNgayCap = new System.Windows.Forms.DateTimePicker();
            this.rtbChatLuong = new System.Windows.Forms.RichTextBox();
            this.txtThoiHanBH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtSelectDevice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ckbModeDevice = new System.Windows.Forms.CheckBox();
            this.dtgListDevice = new System.Windows.Forms.DataGridView();
            this.SelectRow = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNameDevice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvListDeviceProvided = new System.Windows.Forms.DataGridView();
            this.tsPrint = new System.Windows.Forms.ToolStripButton();
            this.groupBox3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListDevice)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDeviceProvided)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSelectProvider);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.ckbModeProvider);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cbListProvider);
            this.groupBox3.Controls.Add(this.txtTenNCC);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(733, 102);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nhập thông tin nhà cung cấp";
            // 
            // txtSelectProvider
            // 
            this.txtSelectProvider.Enabled = false;
            this.txtSelectProvider.Location = new System.Drawing.Point(158, 71);
            this.txtSelectProvider.Name = "txtSelectProvider";
            this.txtSelectProvider.Size = new System.Drawing.Size(189, 20);
            this.txtSelectProvider.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Tên nhà cung cấp cập nhật";
            // 
            // ckbModeProvider
            // 
            this.ckbModeProvider.AutoSize = true;
            this.ckbModeProvider.Enabled = false;
            this.ckbModeProvider.Location = new System.Drawing.Point(280, 19);
            this.ckbModeProvider.Name = "ckbModeProvider";
            this.ckbModeProvider.Size = new System.Drawing.Size(116, 17);
            this.ckbModeProvider.TabIndex = 13;
            this.ckbModeProvider.Text = "Chọn từ danh sách";
            this.ckbModeProvider.UseVisualStyleBackColor = true;
            this.ckbModeProvider.CheckedChanged += new System.EventHandler(this.ckbModeProvider_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(422, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Chọn từ danh sách";
            // 
            // cbListProvider
            // 
            this.cbListProvider.Enabled = false;
            this.cbListProvider.FormattingEnabled = true;
            this.cbListProvider.Location = new System.Drawing.Point(525, 44);
            this.cbListProvider.Name = "cbListProvider";
            this.cbListProvider.Size = new System.Drawing.Size(189, 21);
            this.cbListProvider.TabIndex = 11;
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Enabled = false;
            this.txtTenNCC.Location = new System.Drawing.Point(158, 42);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(189, 20);
            this.txtTenNCC.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nhập tên nhà cung cấp";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAdd,
            this.tsUpdate,
            this.tsDelete,
            this.tsSave,
            this.tsRefresh,
            this.tsPrint});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(757, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsAdd
            // 
            this.tsAdd.Image = global::ThuctapCSDL.Properties.Resources._1473536478_Add;
            this.tsAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAdd.Name = "tsAdd";
            this.tsAdd.Size = new System.Drawing.Size(58, 22);
            this.tsAdd.Text = "Thêm";
            this.tsAdd.Click += new System.EventHandler(this.tsAdd_Click);
            // 
            // tsUpdate
            // 
            this.tsUpdate.Image = global::ThuctapCSDL.Properties.Resources._1473536520_Edit;
            this.tsUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsUpdate.Name = "tsUpdate";
            this.tsUpdate.Size = new System.Drawing.Size(46, 22);
            this.tsUpdate.Text = "Sửa";
            this.tsUpdate.Click += new System.EventHandler(this.tsUpdate_Click);
            // 
            // tsDelete
            // 
            this.tsDelete.Image = global::ThuctapCSDL.Properties.Resources.trash_delete_16x16;
            this.tsDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDelete.Name = "tsDelete";
            this.tsDelete.Size = new System.Drawing.Size(47, 22);
            this.tsDelete.Text = "Xóa";
            this.tsDelete.Click += new System.EventHandler(this.tsDelete_Click);
            // 
            // tsSave
            // 
            this.tsSave.Image = global::ThuctapCSDL.Properties.Resources._1473536499_Save;
            this.tsSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSave.Name = "tsSave";
            this.tsSave.Size = new System.Drawing.Size(47, 22);
            this.tsSave.Text = "Lưu";
            this.tsSave.Click += new System.EventHandler(this.tsSave_Click);
            // 
            // tsRefresh
            // 
            this.tsRefresh.Image = global::ThuctapCSDL.Properties.Resources.ẽit;
            this.tsRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsRefresh.Name = "tsRefresh";
            this.tsRefresh.Size = new System.Drawing.Size(66, 22);
            this.tsRefresh.Text = "Refresh";
            this.tsRefresh.Click += new System.EventHandler(this.tsRefresh_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpNgayCap);
            this.groupBox2.Controls.Add(this.rtbChatLuong);
            this.groupBox2.Controls.Add(this.txtThoiHanBH);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(18, 386);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(724, 92);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập các thông tin khác";
            // 
            // dtpNgayCap
            // 
            this.dtpNgayCap.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayCap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayCap.Location = new System.Drawing.Point(129, 28);
            this.dtpNgayCap.Name = "dtpNgayCap";
            this.dtpNgayCap.Size = new System.Drawing.Size(200, 20);
            this.dtpNgayCap.TabIndex = 5;
            this.dtpNgayCap.Value = new System.DateTime(2016, 12, 13, 21, 37, 42, 0);
            // 
            // rtbChatLuong
            // 
            this.rtbChatLuong.Location = new System.Drawing.Point(420, 28);
            this.rtbChatLuong.Name = "rtbChatLuong";
            this.rtbChatLuong.Size = new System.Drawing.Size(204, 48);
            this.rtbChatLuong.TabIndex = 4;
            this.rtbChatLuong.Text = "";
            // 
            // txtThoiHanBH
            // 
            this.txtThoiHanBH.Location = new System.Drawing.Point(129, 56);
            this.txtThoiHanBH.Name = "txtThoiHanBH";
            this.txtThoiHanBH.Size = new System.Drawing.Size(200, 20);
            this.txtThoiHanBH.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(356, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Chất lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Thời hạn bảo hành";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày cấp";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtSelectDevice);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.ckbModeDevice);
            this.groupBox5.Controls.Add(this.dtgListDevice);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.txtNameDevice);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Location = new System.Drawing.Point(12, 136);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(733, 244);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Nhập thông tin thiết bị";
            // 
            // txtSelectDevice
            // 
            this.txtSelectDevice.Enabled = false;
            this.txtSelectDevice.Location = new System.Drawing.Point(525, 34);
            this.txtSelectDevice.Name = "txtSelectDevice";
            this.txtSelectDevice.Size = new System.Drawing.Size(189, 20);
            this.txtSelectDevice.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(410, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Tên thiết bị cập nhật";
            // 
            // ckbModeDevice
            // 
            this.ckbModeDevice.AutoSize = true;
            this.ckbModeDevice.Enabled = false;
            this.ckbModeDevice.Location = new System.Drawing.Point(280, 8);
            this.ckbModeDevice.Name = "ckbModeDevice";
            this.ckbModeDevice.Size = new System.Drawing.Size(116, 17);
            this.ckbModeDevice.TabIndex = 14;
            this.ckbModeDevice.Text = "Chọn từ danh sách";
            this.ckbModeDevice.UseVisualStyleBackColor = true;
            this.ckbModeDevice.CheckedChanged += new System.EventHandler(this.ckbModeDevice_CheckedChanged);
            // 
            // dtgListDevice
            // 
            this.dtgListDevice.AllowUserToDeleteRows = false;
            this.dtgListDevice.AllowUserToResizeColumns = false;
            this.dtgListDevice.AllowUserToResizeRows = false;
            this.dtgListDevice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgListDevice.BackgroundColor = System.Drawing.Color.White;
            this.dtgListDevice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListDevice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelectRow});
            this.dtgListDevice.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgListDevice.Enabled = false;
            this.dtgListDevice.Location = new System.Drawing.Point(3, 88);
            this.dtgListDevice.Name = "dtgListDevice";
            this.dtgListDevice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgListDevice.Size = new System.Drawing.Size(727, 153);
            this.dtgListDevice.TabIndex = 13;
            // 
            // SelectRow
            // 
            this.SelectRow.DataPropertyName = "Chon";
            this.SelectRow.FalseValue = "0";
            this.SelectRow.HeaderText = "Chọn";
            this.SelectRow.Name = "SelectRow";
            this.SelectRow.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.SelectRow.TrueValue = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Chọn thiết bị từ danh sách";
            // 
            // txtNameDevice
            // 
            this.txtNameDevice.Enabled = false;
            this.txtNameDevice.Location = new System.Drawing.Point(146, 31);
            this.txtNameDevice.Name = "txtNameDevice";
            this.txtNameDevice.Size = new System.Drawing.Size(189, 20);
            this.txtNameDevice.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Nhập tên thiết bị mới";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtSearch);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.dgvListDeviceProvided);
            this.groupBox4.Location = new System.Drawing.Point(12, 484);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(730, 245);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách cung cấp thiết bị";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(524, 32);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 20);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(453, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tìm kiếm";
            // 
            // dgvListDeviceProvided
            // 
            this.dgvListDeviceProvided.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListDeviceProvided.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListDeviceProvided.Location = new System.Drawing.Point(6, 69);
            this.dgvListDeviceProvided.Name = "dgvListDeviceProvided";
            this.dgvListDeviceProvided.Size = new System.Drawing.Size(718, 176);
            this.dgvListDeviceProvided.TabIndex = 0;
            this.dgvListDeviceProvided.SelectionChanged += new System.EventHandler(this.dgvListDeviceProvided_SelectionChanged);
            // 
            // tsPrint
            // 
            this.tsPrint.Image = global::ThuctapCSDL.Properties.Resources.Printer;
            this.tsPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsPrint.Name = "tsPrint";
            this.tsPrint.Size = new System.Drawing.Size(40, 22);
            this.tsPrint.Text = "In ";
            this.tsPrint.Click += new System.EventHandler(this.tsPrint_Click);
            // 
            // frmDeviceProviding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 741);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmDeviceProviding";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cung cấp thiết bị";
            this.Load += new System.EventHandler(this.frmDeviceProviding_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListDevice)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDeviceProvided)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsAdd;
        private System.Windows.Forms.ToolStripButton tsUpdate;
        private System.Windows.Forms.ToolStripButton tsDelete;
        private System.Windows.Forms.ToolStripButton tsSave;
        public System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtbChatLuong;
        private System.Windows.Forms.TextBox txtThoiHanBH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgayCap;
        private System.Windows.Forms.ToolStripButton tsRefresh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbListProvider;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtNameDevice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvListDeviceProvided;
        private System.Windows.Forms.DataGridView dtgListDevice;
        private System.Windows.Forms.CheckBox ckbModeProvider;
        private System.Windows.Forms.CheckBox ckbModeDevice;
        public System.Windows.Forms.TextBox txtSelectProvider;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtSelectDevice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SelectRow;
        private System.Windows.Forms.ToolStripButton tsPrint;
    }
}