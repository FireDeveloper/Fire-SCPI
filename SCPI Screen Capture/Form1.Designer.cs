﻿namespace SCPI
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
            this.btn_capture = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cBox_Extension = new System.Windows.Forms.ComboBox();
            this.chBox_Color = new System.Windows.Forms.CheckBox();
            this.chBox_Invert = new System.Windows.Forms.CheckBox();
            this.TextBoxFilePath = new System.Windows.Forms.TextBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.IP3 = new System.Windows.Forms.NumericUpDown();
            this.IP4 = new System.Windows.Forms.NumericUpDown();
            this.IP2 = new System.Windows.Forms.NumericUpDown();
            this.IP1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IP3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IP4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IP2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IP1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_capture
            // 
            this.btn_capture.Location = new System.Drawing.Point(21, 111);
            this.btn_capture.Name = "btn_capture";
            this.btn_capture.Size = new System.Drawing.Size(334, 40);
            this.btn_capture.TabIndex = 0;
            this.btn_capture.Text = "Capture";
            this.btn_capture.UseVisualStyleBackColor = true;
            this.btn_capture.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(377, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.connectionToolStripMenuItem.Text = "About";
            this.connectionToolStripMenuItem.Click += new System.EventHandler(this.connectionToolStripMenuItem_Click);
            // 
            // cBox_Extension
            // 
            this.cBox_Extension.FormattingEnabled = true;
            this.cBox_Extension.Items.AddRange(new object[] {
            "BMP24",
            "BMP8",
            "PNG",
            "JPEG",
            "TIFF"});
            this.cBox_Extension.Location = new System.Drawing.Point(261, 84);
            this.cBox_Extension.Name = "cBox_Extension";
            this.cBox_Extension.Size = new System.Drawing.Size(94, 21);
            this.cBox_Extension.TabIndex = 1;
            // 
            // chBox_Color
            // 
            this.chBox_Color.AutoSize = true;
            this.chBox_Color.Checked = true;
            this.chBox_Color.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chBox_Color.Location = new System.Drawing.Point(21, 86);
            this.chBox_Color.Name = "chBox_Color";
            this.chBox_Color.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chBox_Color.Size = new System.Drawing.Size(50, 17);
            this.chBox_Color.TabIndex = 4;
            this.chBox_Color.Text = "Color";
            this.chBox_Color.UseVisualStyleBackColor = true;
            // 
            // chBox_Invert
            // 
            this.chBox_Invert.AutoSize = true;
            this.chBox_Invert.Location = new System.Drawing.Point(76, 86);
            this.chBox_Invert.Name = "chBox_Invert";
            this.chBox_Invert.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chBox_Invert.Size = new System.Drawing.Size(53, 17);
            this.chBox_Invert.TabIndex = 5;
            this.chBox_Invert.Text = "Invert";
            this.chBox_Invert.UseVisualStyleBackColor = true;
            // 
            // TextBoxFilePath
            // 
            this.TextBoxFilePath.Location = new System.Drawing.Point(21, 60);
            this.TextBoxFilePath.Name = "TextBoxFilePath";
            this.TextBoxFilePath.Size = new System.Drawing.Size(334, 20);
            this.TextBoxFilePath.TabIndex = 6;
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(280, 31);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(75, 23);
            this.btn_connect.TabIndex = 12;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // IP3
            // 
            this.IP3.Location = new System.Drawing.Point(178, 34);
            this.IP3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.IP3.Name = "IP3";
            this.IP3.Size = new System.Drawing.Size(45, 20);
            this.IP3.TabIndex = 11;
            // 
            // IP4
            // 
            this.IP4.Location = new System.Drawing.Point(229, 34);
            this.IP4.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.IP4.Name = "IP4";
            this.IP4.Size = new System.Drawing.Size(45, 20);
            this.IP4.TabIndex = 10;
            // 
            // IP2
            // 
            this.IP2.Location = new System.Drawing.Point(127, 34);
            this.IP2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.IP2.Name = "IP2";
            this.IP2.Size = new System.Drawing.Size(45, 20);
            this.IP2.TabIndex = 9;
            // 
            // IP1
            // 
            this.IP1.Location = new System.Drawing.Point(76, 34);
            this.IP1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.IP1.Name = "IP1";
            this.IP1.Size = new System.Drawing.Size(45, 20);
            this.IP1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "IP Address";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 169);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.IP3);
            this.Controls.Add(this.IP4);
            this.Controls.Add(this.IP2);
            this.Controls.Add(this.IP1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxFilePath);
            this.Controls.Add(this.chBox_Invert);
            this.Controls.Add(this.chBox_Color);
            this.Controls.Add(this.cBox_Extension);
            this.Controls.Add(this.btn_capture);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IP3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IP4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IP2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IP1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_capture;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
        private System.Windows.Forms.ComboBox cBox_Extension;
        private System.Windows.Forms.CheckBox chBox_Color;
        private System.Windows.Forms.CheckBox chBox_Invert;
        private System.Windows.Forms.TextBox TextBoxFilePath;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.NumericUpDown IP3;
        private System.Windows.Forms.NumericUpDown IP4;
        private System.Windows.Forms.NumericUpDown IP2;
        private System.Windows.Forms.NumericUpDown IP1;
        private System.Windows.Forms.Label label1;
    }
}

