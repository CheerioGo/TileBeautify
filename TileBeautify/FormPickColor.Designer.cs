﻿namespace TileBeautify {
    partial class FormPickColor {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.picScreenShot = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picScreenShot)).BeginInit();
            this.SuspendLayout();
            // 
            // picScreenShot
            // 
            this.picScreenShot.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picScreenShot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picScreenShot.Location = new System.Drawing.Point(110, 71);
            this.picScreenShot.Name = "picScreenShot";
            this.picScreenShot.Size = new System.Drawing.Size(341, 309);
            this.picScreenShot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picScreenShot.TabIndex = 2;
            this.picScreenShot.TabStop = false;
            // 
            // FormPickColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picScreenShot);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPickColor";
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.picScreenShot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox picScreenShot;
    }
}