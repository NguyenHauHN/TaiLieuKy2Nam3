namespace ThuctapCSDL
{
    partial class frmRepair
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
            this.label5 = new System.Windows.Forms.Label();
            this.dgvChon = new System.Windows.Forms.DataGridView();
            this.Chon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cmbMaCanBo = new System.Windows.Forms.ComboBox();
            this.dtpNgaySua = new System.Windows.Forms.DateTimePicker();
            this.rtbNoiDung = new System.Windows.Forms.RichTextBox();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPhongMay = new System.Windows.Forms.ComboBox();
            this.cmbChon = new System.Windows.Forms.ComboBox();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.tsbHome = new System.Windows.Forms.ToolStripButton();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtMaMay = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaTb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTT1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTT2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChon)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Phòng máy";
            // 
            // dgvChon
            // 
            this.dgvChon.BackgroundColor = System.Drawing.Color.White;
            this.dgvChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Chon});
            this.dgvChon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvChon.Location = new System.Drawing.Point(3, 58);
            this.dgvChon.Name = "dgvChon";
            this.dgvChon.Size = new System.Drawing.Size(546, 243);
            this.dgvChon.TabIndex = 0;
            // 
            // Chon
            // 
            this.Chon.DataPropertyName = "Chon";
            this.Chon.FalseValue = "0";
            this.Chon.HeaderText = "Chọn";
            this.Chon.Name = "Chon";
            this.Chon.TrueValue = "1";
            // 
            // cmbMaCanBo
            // 
            this.cmbMaCanBo.FormattingEnabled = true;
            this.cmbMaCanBo.Location = new System.Drawing.Point(106, 82);
            this.cmbMaCanBo.Name = "cmbMaCanBo";
            this.cmbMaCanBo.Size = new System.Drawing.Size(341, 23);
            this.cmbMaCanBo.TabIndex = 24;
            // 
            // dtpNgaySua
            // 
            this.dtpNgaySua.Location = new System.Drawing.Point(106, 52);
            this.dtpNgaySua.Name = "dtpNgaySua";
            this.dtpNgaySua.Size = new System.Drawing.Size(341, 23);
            this.dtpNgaySua.TabIndex = 23;
            // 
            // rtbNoiDung
            // 
            this.rtbNoiDung.Location = new System.Drawing.Point(106, 114);
            this.rtbNoiDung.Name = "rtbNoiDung";
            this.rtbNoiDung.Size = new System.Drawing.Size(341, 92);
            this.rtbNoiDung.TabIndex = 22;
            this.rtbNoiDung.Text = "";
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Location = new System.Drawing.Point(106, 21);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(341, 23);
            this.txtMaPhieu.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Mã Cán Bộ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Ngày Sửa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nội Dung";
            // 
            // cmbPhongMay
            // 
            this.cmbPhongMay.FormattingEnabled = true;
            this.cmbPhongMay.Location = new System.Drawing.Point(92, 21);
            this.cmbPhongMay.Name = "cmbPhongMay";
            this.cmbPhongMay.Size = new System.Drawing.Size(149, 23);
            this.cmbPhongMay.TabIndex = 15;
            // 
            // cmbChon
            // 
            this.cmbChon.FormattingEnabled = true;
            this.cmbChon.Items.AddRange(new object[] {
            "Sửa máy tính",
            "Sửa thiết bị"});
            this.cmbChon.Location = new System.Drawing.Point(300, 21);
            this.cmbChon.Name = "cmbChon";
            this.cmbChon.Size = new System.Drawing.Size(158, 23);
            this.cmbChon.TabIndex = 14;
            // 
            // tsbAdd
            // 
            this.tsbAdd.Image = global::ThuctapCSDL.Properties.Resources._1473536478_Add;
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(58, 22);
            this.tsbAdd.Text = "Thêm";
            // 
            // tsbEdit
            // 
            this.tsbEdit.Image = global::ThuctapCSDL.Properties.Resources._1473536520_Edit;
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(46, 22);
            this.tsbEdit.Text = "Sửa";
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = global::ThuctapCSDL.Properties.Resources.trash_delete_16x16;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(47, 22);
            this.tsbDelete.Text = "Xóa";
            // 
            // tsbSave
            // 
            this.tsbSave.Image = global::ThuctapCSDL.Properties.Resources._1473536499_Save;
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(75, 22);
            this.tsbSave.Text = "Cập nhật";
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
            this.tsbHome.Size = new System.Drawing.Size(60, 22);
            this.tsbHome.Text = "Home";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.White;
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = global::ThuctapCSDL.Properties.Resources.timkiem;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(794, 339);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(76, 24);
            this.btnTimKiem.TabIndex = 48;
            this.btnTimKiem.Text = "Search";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.tsbEdit,
            this.tsbDelete,
            this.tsbSave,
            this.tsbRefresh,
            this.tsbHome});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(1040, 25);
            this.toolStrip1.TabIndex = 46;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDetails);
            this.groupBox1.Controls.Add(this.dgvList);
            this.groupBox1.Location = new System.Drawing.Point(15, 365);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1014, 210);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phiếu sửa chữa";
            // 
            // dgvDetails
            // 
            this.dgvDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetails.Location = new System.Drawing.Point(448, 19);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.Size = new System.Drawing.Size(563, 188);
            this.dgvDetails.TabIndex = 1;
            // 
            // dgvList
            // 
            this.dgvList.BackgroundColor = System.Drawing.Color.White;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvList.Location = new System.Drawing.Point(3, 19);
            this.dgvList.Name = "dgvList";
            this.dgvList.Size = new System.Drawing.Size(445, 188);
            this.dgvList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Mã Phiếu";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmbPhongMay);
            this.groupBox2.Controls.Add(this.dgvChon);
            this.groupBox2.Controls.Add(this.cmbChon);
            this.groupBox2.Location = new System.Drawing.Point(481, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(552, 304);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn sửa chữa";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(247, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "Loại sửa";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtTimKiem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTimKiem.Location = new System.Drawing.Point(541, 339);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(252, 23);
            this.txtTimKiem.TabIndex = 49;
            this.txtTimKiem.Text = "What can i help you find?";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbMaCanBo);
            this.groupBox3.Controls.Add(this.dtpNgaySua);
            this.groupBox3.Controls.Add(this.rtbNoiDung);
            this.groupBox3.Controls.Add(this.txtMaPhieu);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(16, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(459, 218);
            this.groupBox3.TabIndex = 47;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin";
            // 
            // txtMaMay
            // 
            this.txtMaMay.Location = new System.Drawing.Point(305, 18);
            this.txtMaMay.Name = "txtMaMay";
            this.txtMaMay.Size = new System.Drawing.Size(143, 23);
            this.txtMaMay.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(249, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 15);
            this.label9.TabIndex = 39;
            this.label9.Text = "Mã máy";
            // 
            // txtMaTb
            // 
            this.txtMaTb.Location = new System.Drawing.Point(107, 18);
            this.txtMaTb.Name = "txtMaTb";
            this.txtMaTb.Size = new System.Drawing.Size(139, 23);
            this.txtMaTb.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 15);
            this.label8.TabIndex = 37;
            this.label8.Text = "Mã thiết bị";
            // 
            // txtTT1
            // 
            this.txtTT1.Location = new System.Drawing.Point(107, 46);
            this.txtTT1.Name = "txtTT1";
            this.txtTT1.Size = new System.Drawing.Size(341, 23);
            this.txtTT1.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 15);
            this.label7.TabIndex = 35;
            this.label7.Text = "Tình trạng trước";
            // 
            // txtTT2
            // 
            this.txtTT2.Location = new System.Drawing.Point(107, 77);
            this.txtTT2.Name = "txtTT2";
            this.txtTT2.Size = new System.Drawing.Size(341, 23);
            this.txtTT2.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 15);
            this.label6.TabIndex = 33;
            this.label6.Text = "Tình trạng sau";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtMaMay);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtMaTb);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtTT1);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtTT2);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(15, 242);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(460, 117);
            this.groupBox4.TabIndex = 50;
            this.groupBox4.TabStop = false;
            // 
            // frmRepair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 582);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmRepair";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa chữa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvChon)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvChon;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Chon;
        private System.Windows.Forms.ComboBox cmbMaCanBo;
        private System.Windows.Forms.DateTimePicker dtpNgaySua;
        private System.Windows.Forms.RichTextBox rtbNoiDung;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPhongMay;
        private System.Windows.Forms.ComboBox cmbChon;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.ToolStripButton tsbHome;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtMaMay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaTb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTT1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTT2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}