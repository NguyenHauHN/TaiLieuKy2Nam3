namespace ThuctapCSDL.GUI
{
    partial class frmReport
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPhongMay = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbChon = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaCanBo = new System.Windows.Forms.TextBox();
            this.rdbTinhTrang = new System.Windows.Forms.RadioButton();
            this.rdbNgay = new System.Windows.Forms.RadioButton();
            this.cmbTinhTrang = new System.Windows.Forms.ComboBox();
            this.rdbCanBo = new System.Windows.Forms.RadioButton();
            this.btnXem = new System.Windows.Forms.Button();
            this.chbSuaChua = new System.Windows.Forms.CheckBox();
            this.chbThanhLy = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.lblTong = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.chbNhap = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phòng máy";
            // 
            // cmbPhongMay
            // 
            this.cmbPhongMay.FormattingEnabled = true;
            this.cmbPhongMay.Location = new System.Drawing.Point(112, 21);
            this.cmbPhongMay.Name = "cmbPhongMay";
            this.cmbPhongMay.Size = new System.Drawing.Size(156, 21);
            this.cmbPhongMay.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Chọn";
            // 
            // cmbChon
            // 
            this.cmbChon.FormattingEnabled = true;
            this.cmbChon.Items.AddRange(new object[] {
            "Thiết bị",
            "Máy tính"});
            this.cmbChon.Location = new System.Drawing.Point(316, 21);
            this.cmbChon.Name = "cmbChon";
            this.cmbChon.Size = new System.Drawing.Size(162, 21);
            this.cmbChon.TabIndex = 8;
            this.cmbChon.Text = "Thiết bị";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaCanBo);
            this.groupBox1.Controls.Add(this.rdbTinhTrang);
            this.groupBox1.Controls.Add(this.rdbNgay);
            this.groupBox1.Controls.Add(this.cmbTinhTrang);
            this.groupBox1.Controls.Add(this.rdbCanBo);
            this.groupBox1.Location = new System.Drawing.Point(127, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 76);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // txtMaCanBo
            // 
            this.txtMaCanBo.Location = new System.Drawing.Point(93, 21);
            this.txtMaCanBo.Name = "txtMaCanBo";
            this.txtMaCanBo.Size = new System.Drawing.Size(174, 20);
            this.txtMaCanBo.TabIndex = 8;
            // 
            // rdbTinhTrang
            // 
            this.rdbTinhTrang.AutoSize = true;
            this.rdbTinhTrang.Location = new System.Drawing.Point(14, 45);
            this.rdbTinhTrang.Name = "rdbTinhTrang";
            this.rdbTinhTrang.Size = new System.Drawing.Size(73, 17);
            this.rdbTinhTrang.TabIndex = 7;
            this.rdbTinhTrang.TabStop = true;
            this.rdbTinhTrang.Text = "Tình trạng";
            this.rdbTinhTrang.UseVisualStyleBackColor = true;
            // 
            // rdbNgay
            // 
            this.rdbNgay.AutoSize = true;
            this.rdbNgay.Location = new System.Drawing.Point(282, 23);
            this.rdbNgay.Name = "rdbNgay";
            this.rdbNgay.Size = new System.Drawing.Size(88, 17);
            this.rdbNgay.TabIndex = 6;
            this.rdbNgay.Text = "Ngày thực thi";
            this.rdbNgay.UseVisualStyleBackColor = true;
            // 
            // cmbTinhTrang
            // 
            this.cmbTinhTrang.FormattingEnabled = true;
            this.cmbTinhTrang.Items.AddRange(new object[] {
            "Đang sửa chữa",
            "Đã sửa"});
            this.cmbTinhTrang.Location = new System.Drawing.Point(93, 44);
            this.cmbTinhTrang.Name = "cmbTinhTrang";
            this.cmbTinhTrang.Size = new System.Drawing.Size(174, 21);
            this.cmbTinhTrang.TabIndex = 5;
            this.cmbTinhTrang.Text = "Đang sửa chữa";
            // 
            // rdbCanBo
            // 
            this.rdbCanBo.AutoSize = true;
            this.rdbCanBo.Location = new System.Drawing.Point(14, 23);
            this.rdbCanBo.Name = "rdbCanBo";
            this.rdbCanBo.Size = new System.Drawing.Size(59, 17);
            this.rdbCanBo.TabIndex = 3;
            this.rdbCanBo.Text = "Cán bộ";
            this.rdbCanBo.UseVisualStyleBackColor = true;
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.Color.White;
            this.btnXem.Image = global::ThuctapCSDL.Properties.Resources.timkiem;
            this.btnXem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXem.Location = new System.Drawing.Point(422, 172);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 23);
            this.btnXem.TabIndex = 10;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = false;
            // 
            // chbSuaChua
            // 
            this.chbSuaChua.AutoSize = true;
            this.chbSuaChua.Location = new System.Drawing.Point(49, 78);
            this.chbSuaChua.Name = "chbSuaChua";
            this.chbSuaChua.Size = new System.Drawing.Size(72, 17);
            this.chbSuaChua.TabIndex = 12;
            this.chbSuaChua.Text = "Sửa chữa";
            this.chbSuaChua.UseVisualStyleBackColor = true;
            // 
            // chbThanhLy
            // 
            this.chbThanhLy.AutoSize = true;
            this.chbThanhLy.Location = new System.Drawing.Point(49, 101);
            this.chbThanhLy.Name = "chbThanhLy";
            this.chbThanhLy.Size = new System.Drawing.Size(67, 17);
            this.chbThanhLy.TabIndex = 13;
            this.chbThanhLy.Text = "Thanh lý";
            this.chbThanhLy.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvList);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(604, 227);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách";
            // 
            // dgvList
            // 
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(3, 16);
            this.dgvList.Name = "dgvList";
            this.dgvList.Size = new System.Drawing.Size(598, 208);
            this.dgvList.TabIndex = 0;
            // 
            // lblTong
            // 
            this.lblTong.AutoSize = true;
            this.lblTong.Location = new System.Drawing.Point(46, 177);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(52, 13);
            this.lblTong.TabIndex = 15;
            this.lblTong.Text = "Tổng số: ";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.White;
            this.btnPrint.Image = global::ThuctapCSDL.Properties.Resources.Printer1;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(510, 172);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 11;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // chbNhap
            // 
            this.chbNhap.AutoSize = true;
            this.chbNhap.Location = new System.Drawing.Point(49, 137);
            this.chbNhap.Name = "chbNhap";
            this.chbNhap.Size = new System.Drawing.Size(86, 17);
            this.chbNhap.TabIndex = 16;
            this.chbNhap.Text = "Nhập thiết bị";
            this.chbNhap.UseVisualStyleBackColor = true;
            this.chbNhap.CheckedChanged += new System.EventHandler(this.chbNhap_CheckedChanged);
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 428);
            this.Controls.Add(this.chbNhap);
            this.Controls.Add(this.lblTong);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.chbThanhLy);
            this.Controls.Add(this.chbSuaChua);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbChon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbPhongMay);
            this.Controls.Add(this.label1);
            this.Name = "frmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPhongMay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbChon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbNgay;
        private System.Windows.Forms.ComboBox cmbTinhTrang;
        private System.Windows.Forms.RadioButton rdbCanBo;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.CheckBox chbSuaChua;
        private System.Windows.Forms.CheckBox chbThanhLy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Label lblTong;
        private System.Windows.Forms.RadioButton rdbTinhTrang;
        private System.Windows.Forms.TextBox txtMaCanBo;
        private System.Windows.Forms.CheckBox chbNhap;
    }
}