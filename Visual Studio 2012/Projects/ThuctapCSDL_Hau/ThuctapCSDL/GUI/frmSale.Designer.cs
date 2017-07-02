namespace ThuctapCSDL
{
    partial class frmDeviceSaling
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
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTien = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMacb = new System.Windows.Forms.ComboBox();
            this.txtNgay = new System.Windows.Forms.DateTimePicker();
            this.txtMatb = new System.Windows.Forms.TextBox();
            this.txtMamay = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbThem = new System.Windows.Forms.ToolStripButton();
            this.tsbSua = new System.Windows.Forms.ToolStripButton();
            this.tsbXoa = new System.Windows.Forms.ToolStripButton();
            this.tsbLuu = new System.Windows.Forms.ToolStripButton();
            this.tsbThoat = new System.Windows.Forms.ToolStripButton();
            this.tsbHome = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvList
            // 
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvList.Location = new System.Drawing.Point(3, 33);
            this.dgvList.Name = "dgvList";
            this.dgvList.Size = new System.Drawing.Size(749, 188);
            this.dgvList.TabIndex = 0;
            this.dgvList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTL_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvList);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(755, 224);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hiển thị thông tin";
            // 
            // txtTien
            // 
            this.txtTien.Location = new System.Drawing.Point(145, 102);
            this.txtTien.Name = "txtTien";
            this.txtTien.Size = new System.Drawing.Size(218, 22);
            this.txtTien.TabIndex = 7;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(145, 25);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(218, 22);
            this.txtMa.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(373, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã cán bộ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày thanh lí";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số tiền thanh lí";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu thanh lí";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMacb);
            this.groupBox1.Controls.Add(this.txtNgay);
            this.groupBox1.Controls.Add(this.txtMatb);
            this.groupBox1.Controls.Add(this.txtMamay);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTien);
            this.groupBox1.Controls.Add(this.txtMa);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(730, 142);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin";
            // 
            // txtMacb
            // 
            this.txtMacb.FormattingEnabled = true;
            this.txtMacb.Location = new System.Drawing.Point(443, 25);
            this.txtMacb.Name = "txtMacb";
            this.txtMacb.Size = new System.Drawing.Size(231, 23);
            this.txtMacb.TabIndex = 15;
            // 
            // txtNgay
            // 
            this.txtNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtNgay.Location = new System.Drawing.Point(145, 65);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Size = new System.Drawing.Size(218, 22);
            this.txtNgay.TabIndex = 14;
            // 
            // txtMatb
            // 
            this.txtMatb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtMatb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtMatb.Location = new System.Drawing.Point(443, 65);
            this.txtMatb.Name = "txtMatb";
            this.txtMatb.Size = new System.Drawing.Size(231, 22);
            this.txtMatb.TabIndex = 13;
            // 
            // txtMamay
            // 
            this.txtMamay.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtMamay.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtMamay.Location = new System.Drawing.Point(443, 102);
            this.txtMamay.Name = "txtMamay";
            this.txtMamay.Size = new System.Drawing.Size(231, 22);
            this.txtMamay.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(373, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Mã thiết bị";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(373, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Mã máy";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbThem,
            this.tsbSua,
            this.tsbXoa,
            this.tsbLuu,
            this.tsbThoat,
            this.tsbHome});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(755, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbThem
            // 
            this.tsbThem.Image = global::ThuctapCSDL.Properties.Resources._1473536478_Add;
            this.tsbThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbThem.Name = "tsbThem";
            this.tsbThem.Size = new System.Drawing.Size(58, 22);
            this.tsbThem.Text = "Thêm";
            this.tsbThem.Click += new System.EventHandler(this.tsbThem_Click);
            // 
            // tsbSua
            // 
            this.tsbSua.Image = global::ThuctapCSDL.Properties.Resources._1473536520_Edit;
            this.tsbSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSua.Name = "tsbSua";
            this.tsbSua.Size = new System.Drawing.Size(46, 22);
            this.tsbSua.Text = "Sửa";
            this.tsbSua.Click += new System.EventHandler(this.tsbSua_Click);
            // 
            // tsbXoa
            // 
            this.tsbXoa.Image = global::ThuctapCSDL.Properties.Resources.trash_delete_16x16;
            this.tsbXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbXoa.Name = "tsbXoa";
            this.tsbXoa.Size = new System.Drawing.Size(47, 22);
            this.tsbXoa.Text = "Xóa";
            this.tsbXoa.Click += new System.EventHandler(this.tsbXoa_Click);
            // 
            // tsbLuu
            // 
            this.tsbLuu.Image = global::ThuctapCSDL.Properties.Resources._1473536499_Save;
            this.tsbLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLuu.Name = "tsbLuu";
            this.tsbLuu.Size = new System.Drawing.Size(75, 22);
            this.tsbLuu.Text = "Cập nhật";
            this.tsbLuu.Click += new System.EventHandler(this.tsbLuu_Click);
            // 
            // tsbThoat
            // 
            this.tsbThoat.Image = global::ThuctapCSDL.Properties.Resources.ẽit;
            this.tsbThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbThoat.Name = "tsbThoat";
            this.tsbThoat.Size = new System.Drawing.Size(58, 22);
            this.tsbThoat.Text = "Thoát";
            // 
            // tsbHome
            // 
            this.tsbHome.Image = global::ThuctapCSDL.Properties.Resources.home;
            this.tsbHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbHome.Name = "tsbHome";
            this.tsbHome.Size = new System.Drawing.Size(80, 22);
            this.tsbHome.Text = "Trang chủ";
            this.tsbHome.Click += new System.EventHandler(this.tsbHome_Click);
            // 
            // frmDeviceSaling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 402);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmDeviceSaling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanh lí thiết bị";
            this.Load += new System.EventHandler(this.ThanhliTB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTien;
        private System.Windows.Forms.ToolStripButton tsbHome;
        private System.Windows.Forms.ToolStripButton tsbThoat;
        private System.Windows.Forms.ToolStripButton tsbLuu;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton tsbXoa;
        private System.Windows.Forms.ToolStripButton tsbSua;
        private System.Windows.Forms.ToolStripButton tsbThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TextBox txtMatb;
        private System.Windows.Forms.TextBox txtMamay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker txtNgay;
        private System.Windows.Forms.ComboBox txtMacb;
    }
}