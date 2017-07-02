namespace ThuctapCSDL.GUI
{
    partial class frmDeviceSale
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeviceSale));
            this.tsbHome = new System.Windows.Forms.ToolStripButton();
            this.tsbLuu = new System.Windows.Forms.ToolStripButton();
            this.tsbXoa = new System.Windows.Forms.ToolStripButton();
            this.tsbSua = new System.Windows.Forms.ToolStripButton();
            this.tsbThem = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.cmbMacb = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNgay = new System.Windows.Forms.DateTimePicker();
            this.txtMatb = new System.Windows.Forms.TextBox();
            this.txtMamay = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTien = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tsbHome
            // 
            this.tsbHome.Image = global::ThuctapCSDL.Properties.Resources.home;
            this.tsbHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbHome.Name = "tsbHome";
            this.tsbHome.Size = new System.Drawing.Size(80, 22);
            this.tsbHome.Text = "Trang chủ";
            // 
            // tsbLuu
            // 
            this.tsbLuu.Image = global::ThuctapCSDL.Properties.Resources._1473536499_Save;
            this.tsbLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLuu.Name = "tsbLuu";
            this.tsbLuu.Size = new System.Drawing.Size(75, 22);
            this.tsbLuu.Text = "Cập nhật";
            // 
            // tsbXoa
            // 
            this.tsbXoa.Image = global::ThuctapCSDL.Properties.Resources.trash_delete_16x16;
            this.tsbXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbXoa.Name = "tsbXoa";
            this.tsbXoa.Size = new System.Drawing.Size(47, 22);
            this.tsbXoa.Text = "Xóa";
            // 
            // tsbSua
            // 
            this.tsbSua.Image = global::ThuctapCSDL.Properties.Resources._1473536520_Edit;
            this.tsbSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSua.Name = "tsbSua";
            this.tsbSua.Size = new System.Drawing.Size(46, 22);
            this.tsbSua.Text = "Sửa";
            // 
            // tsbThem
            // 
            this.tsbThem.Image = global::ThuctapCSDL.Properties.Resources._1473536478_Add;
            this.tsbThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbThem.Name = "tsbThem";
            this.tsbThem.Size = new System.Drawing.Size(58, 22);
            this.tsbThem.Text = "Thêm";
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
            this.toolStrip1.Size = new System.Drawing.Size(705, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.Image = global::ThuctapCSDL.Properties.Resources.ẽit;
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(66, 22);
            this.tsbRefresh.Text = "Refresh";
            // 
            // cmbMacb
            // 
            this.cmbMacb.FormattingEnabled = true;
            this.cmbMacb.Location = new System.Drawing.Point(418, 26);
            this.cmbMacb.Name = "cmbMacb";
            this.cmbMacb.Size = new System.Drawing.Size(231, 23);
            this.cmbMacb.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbMacb);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 129);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin";
            // 
            // txtNgay
            // 
            this.txtNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtNgay.Location = new System.Drawing.Point(113, 55);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Size = new System.Drawing.Size(218, 22);
            this.txtNgay.TabIndex = 14;
            // 
            // txtMatb
            // 
            this.txtMatb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtMatb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtMatb.Location = new System.Drawing.Point(418, 55);
            this.txtMatb.Name = "txtMatb";
            this.txtMatb.Size = new System.Drawing.Size(231, 22);
            this.txtMatb.TabIndex = 13;
            // 
            // txtMamay
            // 
            this.txtMamay.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtMamay.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtMamay.Location = new System.Drawing.Point(418, 83);
            this.txtMamay.Name = "txtMamay";
            this.txtMamay.Size = new System.Drawing.Size(231, 22);
            this.txtMamay.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(348, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Mã thiết bị";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(348, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Mã máy";
            // 
            // txtTien
            // 
            this.txtTien.Location = new System.Drawing.Point(113, 83);
            this.txtTien.Name = "txtTien";
            this.txtTien.Size = new System.Drawing.Size(218, 22);
            this.txtTien.TabIndex = 7;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(113, 26);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(218, 22);
            this.txtMa.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(348, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã cán bộ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày thanh lí";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số tiền thanh lí";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.dgvList);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(705, 237);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hiển thị thông tin";
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearch.Location = new System.Drawing.Point(402, 21);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(209, 22);
            this.txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::ThuctapCSDL.Properties.Resources.timkiem;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(617, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(67, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // dgvList
            // 
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvList.Location = new System.Drawing.Point(3, 57);
            this.dgvList.Name = "dgvList";
            this.dgvList.Size = new System.Drawing.Size(699, 177);
            this.dgvList.TabIndex = 0;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // frmDeviceSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 409);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmDeviceSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanh lý thiết bị";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton tsbHome;
        private System.Windows.Forms.ToolStripButton tsbLuu;
        private System.Windows.Forms.ToolStripButton tsbXoa;
        private System.Windows.Forms.ToolStripButton tsbSua;
        private System.Windows.Forms.ToolStripButton tsbThem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.ComboBox cmbMacb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker txtNgay;
        private System.Windows.Forms.TextBox txtMatb;
        private System.Windows.Forms.TextBox txtMamay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTien;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}