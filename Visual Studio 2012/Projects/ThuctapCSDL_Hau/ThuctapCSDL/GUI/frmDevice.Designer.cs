namespace ThuctapCSDL
{
    partial class frmDevice
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
            this.rtbTinhTrang = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbLoaiTB = new System.Windows.Forms.ComboBox();
            this.cmbMaPhong = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbThem = new System.Windows.Forms.ToolStripButton();
            this.tsbSua = new System.Windows.Forms.ToolStripButton();
            this.tsbXoa = new System.Windows.Forms.ToolStripButton();
            this.tsbLuu = new System.Windows.Forms.ToolStripButton();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbTinhTrang
            // 
            this.rtbTinhTrang.Location = new System.Drawing.Point(406, 28);
            this.rtbTinhTrang.Name = "rtbTinhTrang";
            this.rtbTinhTrang.Size = new System.Drawing.Size(240, 68);
            this.rtbTinhTrang.TabIndex = 13;
            this.rtbTinhTrang.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbLoaiTB);
            this.groupBox1.Controls.Add(this.rtbTinhTrang);
            this.groupBox1.Controls.Add(this.cmbMaPhong);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(this.txtMa);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 150);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin";
            // 
            // cmbLoaiTB
            // 
            this.cmbLoaiTB.FormattingEnabled = true;
            this.cmbLoaiTB.Location = new System.Drawing.Point(108, 102);
            this.cmbLoaiTB.Name = "cmbLoaiTB";
            this.cmbLoaiTB.Size = new System.Drawing.Size(207, 23);
            this.cmbLoaiTB.TabIndex = 14;
            // 
            // cmbMaPhong
            // 
            this.cmbMaPhong.FormattingEnabled = true;
            this.cmbMaPhong.Location = new System.Drawing.Point(406, 102);
            this.cmbMaPhong.Name = "cmbMaPhong";
            this.cmbMaPhong.Size = new System.Drawing.Size(240, 23);
            this.cmbMaPhong.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(333, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Phòng máy";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(108, 65);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(207, 22);
            this.txtTen.TabIndex = 9;
            // 
            // txtMa
            // 
            this.txtMa.Enabled = false;
            this.txtMa.Location = new System.Drawing.Point(108, 28);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(207, 22);
            this.txtMa.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(333, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tình trạng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại thiết bị";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên thiết bị";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã thiết bị";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbThem,
            this.tsbSua,
            this.tsbXoa,
            this.tsbLuu,
            this.tsbRefresh});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(694, 25);
            this.toolStrip1.TabIndex = 25;
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
            this.tsbLuu.Size = new System.Drawing.Size(47, 22);
            this.tsbLuu.Text = "Lưu";
            this.tsbLuu.Click += new System.EventHandler(this.tsbLuu_Click);
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.Image = global::ThuctapCSDL.Properties.Resources.ẽit;
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(66, 22);
            this.tsbRefresh.Text = "Refresh";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTimKiem);
            this.groupBox2.Controls.Add(this.dgvList);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(694, 258);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTimKiem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTimKiem.ForeColor = System.Drawing.Color.Black;
            this.txtTimKiem.Location = new System.Drawing.Point(486, 33);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(196, 20);
            this.txtTimKiem.TabIndex = 30;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // dgvList
            // 
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvList.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(12, 59);
            this.dgvList.Name = "dgvList";
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(670, 193);
            this.dgvList.TabIndex = 27;
            this.dgvList.SelectionChanged += new System.EventHandler(this.dgvList_SelectionChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(426, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 15);
            this.label7.TabIndex = 29;
            this.label7.Text = "Tìm kiếm";
            // 
            // frmDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 463);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmDevice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thiết bị";
            this.Load += new System.EventHandler(this.frmThietBi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtbTinhTrang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbMaPhong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.ToolStripButton tsbLuu;
        private System.Windows.Forms.ToolStripButton tsbXoa;
        private System.Windows.Forms.ToolStripButton tsbSua;
        private System.Windows.Forms.ToolStripButton tsbThem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbLoaiTB;
    }
}