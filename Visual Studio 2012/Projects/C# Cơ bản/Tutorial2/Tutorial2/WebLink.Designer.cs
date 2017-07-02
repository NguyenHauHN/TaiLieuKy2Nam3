namespace Tutorial2
{
    partial class WebLink
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
            this.lBWebname = new System.Windows.Forms.ListBox();
            this.lBLink = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOKLBWebsite = new System.Windows.Forms.Button();
            this.btnResetLBWebsite = new System.Windows.Forms.Button();
            this.btnResetLBLink = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lBWebname
            // 
            this.lBWebname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBWebname.FormattingEnabled = true;
            this.lBWebname.ItemHeight = 16;
            this.lBWebname.Items.AddRange(new object[] {
            "Dân trí",
            "Tuổi trẻ",
            "Kênh 14",
            "Phim mới",
            "Baó mới",
            "Tinh tế",
            "ZingNew",
            "Facebook",
            "VTCNew",
            "Soha",
            "Google",
            "2Sao"});
            this.lBWebname.Location = new System.Drawing.Point(12, 54);
            this.lBWebname.Name = "lBWebname";
            this.lBWebname.Size = new System.Drawing.Size(156, 180);
            this.lBWebname.TabIndex = 0;
            // 
            // lBLink
            // 
            this.lBLink.FormattingEnabled = true;
            this.lBLink.Location = new System.Drawing.Point(367, 54);
            this.lBLink.Name = "lBLink";
            this.lBLink.Size = new System.Drawing.Size(157, 186);
            this.lBLink.TabIndex = 1;
            this.lBLink.SelectedIndexChanged += new System.EventHandler(this.lBLink_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Liên kết Website";
            // 
            // btnOKLBWebsite
            // 
            this.btnOKLBWebsite.Location = new System.Drawing.Point(12, 245);
            this.btnOKLBWebsite.Name = "btnOKLBWebsite";
            this.btnOKLBWebsite.Size = new System.Drawing.Size(75, 23);
            this.btnOKLBWebsite.TabIndex = 3;
            this.btnOKLBWebsite.Text = "OK";
            this.btnOKLBWebsite.UseVisualStyleBackColor = true;
            this.btnOKLBWebsite.Click += new System.EventHandler(this.btnOKLBWebsite_Click);
            // 
            // btnResetLBWebsite
            // 
            this.btnResetLBWebsite.Location = new System.Drawing.Point(93, 245);
            this.btnResetLBWebsite.Name = "btnResetLBWebsite";
            this.btnResetLBWebsite.Size = new System.Drawing.Size(75, 23);
            this.btnResetLBWebsite.TabIndex = 4;
            this.btnResetLBWebsite.Text = "Reset";
            this.btnResetLBWebsite.UseVisualStyleBackColor = true;
            this.btnResetLBWebsite.Click += new System.EventHandler(this.btnResetLBWebsite_Click);
            // 
            // btnResetLBLink
            // 
            this.btnResetLBLink.Location = new System.Drawing.Point(449, 245);
            this.btnResetLBLink.Name = "btnResetLBLink";
            this.btnResetLBLink.Size = new System.Drawing.Size(75, 23);
            this.btnResetLBLink.TabIndex = 6;
            this.btnResetLBLink.Text = "Reset";
            this.btnResetLBLink.UseVisualStyleBackColor = true;
            this.btnResetLBLink.Click += new System.EventHandler(this.btnResetLBLink_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(174, 54);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(187, 186);
            this.txtResult.TabIndex = 7;
            // 
            // WebLink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 280);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnResetLBLink);
            this.Controls.Add(this.btnResetLBWebsite);
            this.Controls.Add(this.btnOKLBWebsite);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lBLink);
            this.Controls.Add(this.lBWebname);
            this.Name = "WebLink";
            this.Text = "WebLink";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lBWebname;
        private System.Windows.Forms.ListBox lBLink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOKLBWebsite;
        private System.Windows.Forms.Button btnResetLBWebsite;
        private System.Windows.Forms.Button btnResetLBLink;
        private System.Windows.Forms.TextBox txtResult;
    }
}

