﻿
namespace Tyuiu.KonyushevskyAA.Sprint6.TaskReview.V12
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBoxAvatar_KAA = new System.Windows.Forms.PictureBox();
            this.labelInfo_KAA = new System.Windows.Forms.Label();
            this.buttonok_KAA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_KAA)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAvatar_KAA
            // 
            this.pictureBoxAvatar_KAA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar_KAA.Image")));
            this.pictureBoxAvatar_KAA.Location = new System.Drawing.Point(13, 14);
            this.pictureBoxAvatar_KAA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxAvatar_KAA.Name = "pictureBoxAvatar_KAA";
            this.pictureBoxAvatar_KAA.Size = new System.Drawing.Size(235, 304);
            this.pictureBoxAvatar_KAA.TabIndex = 2;
            this.pictureBoxAvatar_KAA.TabStop = false;
            // 
            // labelInfo_KAA
            // 
            this.labelInfo_KAA.Location = new System.Drawing.Point(256, 27);
            this.labelInfo_KAA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInfo_KAA.Name = "labelInfo_KAA";
            this.labelInfo_KAA.Size = new System.Drawing.Size(526, 223);
            this.labelInfo_KAA.TabIndex = 3;
            this.labelInfo_KAA.Text = resources.GetString("labelInfo_KAA.Text");
            // 
            // buttonok_KAA
            // 
            this.buttonok_KAA.Location = new System.Drawing.Point(663, 253);
            this.buttonok_KAA.Name = "buttonok_KAA";
            this.buttonok_KAA.Size = new System.Drawing.Size(106, 37);
            this.buttonok_KAA.TabIndex = 4;
            this.buttonok_KAA.Text = "Ok";
            this.buttonok_KAA.UseVisualStyleBackColor = true;
            this.buttonok_KAA.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 371);
            this.Controls.Add(this.buttonok_KAA);
            this.Controls.Add(this.labelInfo_KAA);
            this.Controls.Add(this.pictureBoxAvatar_KAA);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(896, 427);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(896, 427);
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_KAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatar_KAA;
        private System.Windows.Forms.Label labelInfo_KAA;
        private System.Windows.Forms.Button buttonok_KAA;
    }
}