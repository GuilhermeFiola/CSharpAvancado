﻿namespace _11___Eventos
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
            this.btn_video_encoder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_video_encoder
            // 
            this.btn_video_encoder.Location = new System.Drawing.Point(283, 250);
            this.btn_video_encoder.Name = "btn_video_encoder";
            this.btn_video_encoder.Size = new System.Drawing.Size(180, 64);
            this.btn_video_encoder.TabIndex = 0;
            this.btn_video_encoder.Text = "Video Encoder";
            this.btn_video_encoder.UseVisualStyleBackColor = true;
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_video_encoder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_video_encoder;
    }
}

