namespace Tutorial3
{
    partial class ChuyenFont
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
            this.txtString = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radUppercase = new System.Windows.Forms.RadioButton();
            this.radLowercase = new System.Windows.Forms.RadioButton();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập chuỗi bất kỳ";
            // 
            // txtString
            // 
            this.txtString.Location = new System.Drawing.Point(155, 38);
            this.txtString.Name = "txtString";
            this.txtString.Size = new System.Drawing.Size(306, 20);
            this.txtString.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chọn kiểu chữ";
            // 
            // radUppercase
            // 
            this.radUppercase.AutoSize = true;
            this.radUppercase.Location = new System.Drawing.Point(33, 106);
            this.radUppercase.Name = "radUppercase";
            this.radUppercase.Size = new System.Drawing.Size(65, 17);
            this.radUppercase.TabIndex = 3;
            this.radUppercase.TabStop = true;
            this.radUppercase.Text = "Chữ hoa";
            this.radUppercase.UseVisualStyleBackColor = true;
            // 
            // radLowercase
            // 
            this.radLowercase.AutoSize = true;
            this.radLowercase.Location = new System.Drawing.Point(33, 138);
            this.radLowercase.Name = "radLowercase";
            this.radLowercase.Size = new System.Drawing.Size(80, 17);
            this.radLowercase.TabIndex = 4;
            this.radLowercase.TabStop = true;
            this.radLowercase.Text = "Chữ thường";
            this.radLowercase.UseVisualStyleBackColor = true;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(155, 170);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(306, 20);
            this.txtResult.TabIndex = 6;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(31, 213);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(33, 170);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(75, 23);
            this.btnResult.TabIndex = 8;
            this.btnResult.Text = "Kết quả";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // ChuyenFont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 261);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.radLowercase);
            this.Controls.Add(this.radUppercase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtString);
            this.Controls.Add(this.label1);
            this.Name = "ChuyenFont";
            this.Text = "Chuyển đổi kiểu chữ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtString;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radUppercase;
        private System.Windows.Forms.RadioButton radLowercase;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnResult;
    }
}

