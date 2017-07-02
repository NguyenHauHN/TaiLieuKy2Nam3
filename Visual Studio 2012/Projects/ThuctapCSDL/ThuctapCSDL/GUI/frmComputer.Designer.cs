namespace ThuctapCSDL
{
    partial class frmComputer
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbThem = new System.Windows.Forms.ToolStripButton();
            this.tsbSua = new System.Windows.Forms.ToolStripButton();
            this.tsbXoa = new System.Windows.Forms.ToolStripButton();
            this.tsbLuu = new System.Windows.Forms.ToolStripButton();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.tsbHome = new System.Windows.Forms.ToolStripButton();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtTenMay = new System.Windows.Forms.TextBox();
            this.txtCauHinh = new System.Windows.Forms.TextBox();
            this.txtMaMay = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtbTinhTrang = new System.Windows.Forms.RichTextBox();
            this.cmbMaPhong = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbThem,
            this.tsbSua,
            this.tsbXoa,
            this.tsbLuu,
            this.tsbRefresh,
            this.tsbHome});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(719, 25);
            this.toolStrip1.TabIndex = 19;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbThem
            // 
            this.tsbThem.Image = global::ThuctapCSDL.Properties.Resources._1473536478_Add;
            this.tsbThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbThem.Name = "tsbThem";
            this.tsbThem.Size = new System.Drawing.Size(58, 22);
            this.tsbThem.Text = "Thêm";
            // 
            // tsbSua
            // 
            this.tsbSua.Image = global::ThuctapCSDL.Properties.Resources._1473536520_Edit;
            this.tsbSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSua.Name = "tsbSua";
            this.tsbSua.Size = new System.Drawing.Size(46, 22);
            this.tsbSua.Text = "Sửa";
            // 
            // tsbXoa
            // 
            this.tsbXoa.Image = global::ThuctapCSDL.Properties.Resources.trash_delete_16x16;
            this.tsbXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbXoa.Name = "tsbXoa";
            this.tsbXoa.Size = new System.Drawing.Size(47, 22);
            this.tsbXoa.Text = "Xóa";
            // 
            // tsbLuu
            // 
            this.tsbLuu.Image = global::ThuctapCSDL.Properties.Resources._1473536499_Save;
            this.tsbLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLuu.Name = "tsbLuu";
            this.tsbLuu.Size = new System.Drawing.Size(75, 22);
            this.tsbLuu.Text = "Cập nhật";
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.Image = global::ThuctapCSDL.Properties.Resources.ẽit;
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(66, 22);
            this.tsbRefresh.Text = "Refresh";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Phòng máy";
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(422, 28);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(236, 22);
            this.dtpDate.TabIndex = 10;
            // 
            // txtTenMay
            // 
            this.txtTenMay.Location = new System.Drawing.Point(110, 61);
            this.txtTenMay.Name = "txtTenMay";
            this.txtTenMay.Size = new System.Drawing.Size(218, 22);
            this.txtTenMay.TabIndex = 9;
            // 
            // txtCauHinh
            // 
            this.txtCauHinh.Location = new System.Drawing.Point(110, 95);
            this.txtCauHinh.Name = "txtCauHinh";
            this.txtCauHinh.Size = new System.Drawing.Size(218, 22);
            this.txtCauHinh.TabIndex = 8;
            // 
            // txtMaMay
            // 
            this.txtMaMay.Location = new System.Drawing.Point(110, 28);
            this.txtMaMay.Name = "txtMaMay";
            this.txtMaMay.Size = new System.Drawing.Size(218, 22);
            this.txtMaMay.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(340, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tình trạng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày lắp đặt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cấu hình";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên máy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã máy";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbTinhTrang);
            this.groupBox1.Controls.Add(this.cmbMaPhong);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtpDate);
            this.groupBox1.Controls.Add(this.txtTenMay);
            this.groupBox1.Controls.Add(this.txtCauHinh);
            this.groupBox1.Controls.Add(this.txtMaMay);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(694, 163);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin";
            // 
            // rtbTinhTrang
            // 
            this.rtbTinhTrang.Location = new System.Drawing.Point(422, 61);
            this.rtbTinhTrang.Name = "rtbTinhTrang";
            this.rtbTinhTrang.Size = new System.Drawing.Size(236, 89);
            this.rtbTinhTrang.TabIndex = 13;
            this.rtbTinhTrang.Text = "";
            // 
            // cmbMaPhong
            // 
            this.cmbMaPhong.FormattingEnabled = true;
            this.cmbMaPhong.Location = new System.Drawing.Point(110, 127);
            this.cmbMaPhong.Name = "cmbMaPhong";
            this.cmbMaPhong.Size = new System.Drawing.Size(218, 23);
            this.cmbMaPhong.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTimKiem);
            this.groupBox2.Controls.Add(this.btnTimKiem);
            this.groupBox2.Controls.Add(this.dgvList);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(719, 231);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtTimKiem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTimKiem.Location = new System.Drawing.Point(390, 19);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(234, 20);
            this.txtTimKiem.TabIndex = 23;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.White;
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = global::ThuctapCSDL.Properties.Resources.timkiem;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(630, 17);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(73, 23);
            this.btnTimKiem.TabIndex = 22;
            this.btnTimKiem.Text = "Search";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // dgvList
            // 
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvList.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvList.Location = new System.Drawing.Point(3, 52);
            this.dgvList.Name = "dgvList";
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(713, 176);
            this.dgvList.TabIndex = 21;
            // 
            // frmComputer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 440);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmComputer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Máy tính";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.ToolStripButton tsbLuu;
        private System.Windows.Forms.ToolStripButton tsbXoa;
        private System.Windows.Forms.ToolStripButton tsbSua;
        private System.Windows.Forms.ToolStripButton tsbThem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbHome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtTenMay;
        private System.Windows.Forms.TextBox txtCauHinh;
        private System.Windows.Forms.TextBox txtMaMay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtbTinhTrang;
        private System.Windows.Forms.ComboBox cmbMaPhong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvList;
    }
}

