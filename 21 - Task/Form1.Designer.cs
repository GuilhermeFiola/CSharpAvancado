namespace _21___Task
{
    partial class Form1
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
            this.btn_download = new System.Windows.Forms.Button();
            this.rtx_site = new System.Windows.Forms.RichTextBox();
            this.txt_site = new System.Windows.Forms.TextBox();
            this.lbl_site = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_download
            // 
            this.btn_download.Location = new System.Drawing.Point(43, 271);
            this.btn_download.Name = "btn_download";
            this.btn_download.Size = new System.Drawing.Size(248, 48);
            this.btn_download.TabIndex = 0;
            this.btn_download.Text = "Download";
            this.btn_download.UseVisualStyleBackColor = true;
            this.btn_download.Click += new System.EventHandler(this.btn_download_Click);
            // 
            // rtx_site
            // 
            this.rtx_site.Location = new System.Drawing.Point(44, 57);
            this.rtx_site.Name = "rtx_site";
            this.rtx_site.Size = new System.Drawing.Size(248, 208);
            this.rtx_site.TabIndex = 1;
            this.rtx_site.Text = "";
            // 
            // txt_site
            // 
            this.txt_site.Location = new System.Drawing.Point(44, 29);
            this.txt_site.Name = "txt_site";
            this.txt_site.Size = new System.Drawing.Size(247, 22);
            this.txt_site.TabIndex = 2;
            // 
            // lbl_site
            // 
            this.lbl_site.AutoSize = true;
            this.lbl_site.Location = new System.Drawing.Point(41, 9);
            this.lbl_site.Name = "lbl_site";
            this.lbl_site.Size = new System.Drawing.Size(32, 17);
            this.lbl_site.TabIndex = 3;
            this.lbl_site.Text = "Site";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 347);
            this.Controls.Add(this.lbl_site);
            this.Controls.Add(this.txt_site);
            this.Controls.Add(this.rtx_site);
            this.Controls.Add(this.btn_download);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_download;
        private System.Windows.Forms.RichTextBox rtx_site;
        private System.Windows.Forms.TextBox txt_site;
        private System.Windows.Forms.Label lbl_site;
    }
}

