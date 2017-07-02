namespace ThuctapCSDL
{
    partial class frmCompRoom
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvRoomList = new System.Windows.Forms.DataGridView();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSL = new System.Windows.Forms.DataGridView();
            this.cmbXem = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnXem = new System.Windows.Forms.Button();
            this.cmbMaPhong = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSL)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(813, 25);
            this.toolStrip1.TabIndex = 0;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvRoomList);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(this.txtMa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 333);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin";
            // 
            // dgvRoomList
            // 
            this.dgvRoomList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoomList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoomList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvRoomList.Location = new System.Drawing.Point(3, 143);
            this.dgvRoomList.Name = "dgvRoomList";
            this.dgvRoomList.Size = new System.Drawing.Size(367, 187);
            this.dgvRoomList.TabIndex = 5;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(93, 73);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(211, 22);
            this.txtTen.TabIndex = 3;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(93, 38);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(211, 22);
            this.txtMa.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phòng";
            // 
            // dgvSL
            // 
            this.dgvSL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSL.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSL.Location = new System.Drawing.Point(3, 143);
            this.dgvSL.Name = "dgvSL";
            this.dgvSL.Size = new System.Drawing.Size(434, 187);
            this.dgvSL.TabIndex = 2;
            // 
            // cmbXem
            // 
            this.cmbXem.FormattingEnabled = true;
            this.cmbXem.Items.AddRange(new object[] {
            "Máy Tính",
            "Thiết Bị"});
            this.cmbXem.Location = new System.Drawing.Point(269, 39);
            this.cmbXem.Name = "cmbXem";
            this.cmbXem.Size = new System.Drawing.Size(147, 21);
            this.cmbXem.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Xem";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnXem);
            this.groupBox2.Controls.Add(this.cmbMaPhong);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbXem);
            this.groupBox2.Controls.Add(this.dgvSL);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(373, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(440, 333);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thống kê";
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(59, 72);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 23);
            this.btnXem.TabIndex = 5;
            this.btnXem.Text = "Chi tiết";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // cmbMaPhong
            // 
            this.cmbMaPhong.FormattingEnabled = true;
            this.cmbMaPhong.Location = new System.Drawing.Point(84, 39);
            this.cmbMaPhong.Name = "cmbMaPhong";
            this.cmbMaPhong.Size = new System.Drawing.Size(138, 21);
            this.cmbMaPhong.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên phòng";
            // 
            // frmCompRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 358);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmCompRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phòng máy";
            this.Load += new System.EventHandler(this.PhongMay_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSL)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbThem;
        private System.Windows.Forms.ToolStripButton tsbSua;
        private System.Windows.Forms.ToolStripButton tsbXoa;
        private System.Windows.Forms.ToolStripButton tsbLuu;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.ToolStripButton tsbHome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSL;
        private System.Windows.Forms.ComboBox cmbXem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.ComboBox cmbMaPhong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvRoomList;
    }
}