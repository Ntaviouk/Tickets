﻿using yt_DesignUI;

namespace Tickets.Forms
{
    partial class AdminAddRoute
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAddRoute));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.egoldsGoogleTextBox2 = new yt_DesignUI.EgoldsGoogleTextBox();
            this.yt_Button1 = new yt_DesignUI.yt_Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.egoldsGoogleTextBox1 = new yt_DesignUI.EgoldsGoogleTextBox();
            this.yt_Button2 = new yt_DesignUI.yt_Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(14, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 22);
            this.label1.TabIndex = 40;
            this.label1.Text = "Виберіть потяг";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(18, 101);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(256, 30);
            this.comboBox1.TabIndex = 39;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Enabled = false;
            this.maskedTextBox1.Font = new System.Drawing.Font("Montserrat SemiBold", 20F, System.Drawing.FontStyle.Bold);
            this.maskedTextBox1.Location = new System.Drawing.Point(23, 78);
            this.maskedTextBox1.Mask = "00:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(74, 40);
            this.maskedTextBox1.TabIndex = 43;
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Enabled = false;
            this.maskedTextBox2.Font = new System.Drawing.Font("Montserrat SemiBold", 20F, System.Drawing.FontStyle.Bold);
            this.maskedTextBox2.Location = new System.Drawing.Point(119, 78);
            this.maskedTextBox2.Mask = "00:00";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(74, 40);
            this.maskedTextBox2.TabIndex = 44;
            this.maskedTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.maskedTextBox2);
            this.panel2.Controls.Add(this.maskedTextBox1);
            this.panel2.Controls.Add(this.egoldsGoogleTextBox2);
            this.panel2.Controls.Add(this.yt_Button1);
            this.panel2.Location = new System.Drawing.Point(44, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(326, 208);
            this.panel2.TabIndex = 48;
            this.panel2.Visible = false;
            // 
            // egoldsGoogleTextBox2
            // 
            this.egoldsGoogleTextBox2.BackColor = System.Drawing.Color.White;
            this.egoldsGoogleTextBox2.BorderColor = System.Drawing.Color.Black;
            this.egoldsGoogleTextBox2.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.egoldsGoogleTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.egoldsGoogleTextBox2.Enabled = false;
            this.egoldsGoogleTextBox2.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.egoldsGoogleTextBox2.FontTextPreview = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.egoldsGoogleTextBox2.ForeColor = System.Drawing.Color.Black;
            this.egoldsGoogleTextBox2.Location = new System.Drawing.Point(23, 16);
            this.egoldsGoogleTextBox2.Name = "egoldsGoogleTextBox2";
            this.egoldsGoogleTextBox2.SelectionStart = 0;
            this.egoldsGoogleTextBox2.Size = new System.Drawing.Size(170, 45);
            this.egoldsGoogleTextBox2.TabIndex = 42;
            this.egoldsGoogleTextBox2.TextInput = "";
            this.egoldsGoogleTextBox2.TextPreview = "Місто";
            this.egoldsGoogleTextBox2.UseSystemPasswordChar = false;
            // 
            // yt_Button1
            // 
            this.yt_Button1.BackColor = System.Drawing.Color.DarkGreen;
            this.yt_Button1.BackColorAdditional = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.yt_Button1.BackColorGradientEnabled = true;
            this.yt_Button1.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.yt_Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.yt_Button1.BorderColorEnabled = false;
            this.yt_Button1.BorderColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.yt_Button1.BorderColorOnHoverEnabled = false;
            this.yt_Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yt_Button1.Enabled = false;
            this.yt_Button1.Font = new System.Drawing.Font("Montserrat Light", 40F);
            this.yt_Button1.ForeColor = System.Drawing.Color.White;
            this.yt_Button1.Location = new System.Drawing.Point(228, 44);
            this.yt_Button1.Name = "yt_Button1";
            this.yt_Button1.RippleColor = System.Drawing.Color.Black;
            this.yt_Button1.Rounding = 60;
            this.yt_Button1.RoundingEnable = true;
            this.yt_Button1.Size = new System.Drawing.Size(68, 55);
            this.yt_Button1.TabIndex = 41;
            this.yt_Button1.Text = "+";
            this.yt_Button1.TextHover = null;
            this.yt_Button1.UseDownPressEffectOnClick = false;
            this.yt_Button1.UseRippleEffect = true;
            this.yt_Button1.UseVisualStyleBackColor = false;
            this.yt_Button1.UseZoomEffectOnHover = false;
            this.yt_Button1.Click += new System.EventHandler(this.yt_Button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.egoldsGoogleTextBox1);
            this.panel1.Location = new System.Drawing.Point(12, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 252);
            this.panel1.TabIndex = 49;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePicker1.CustomFormat = "dd/MM";
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(18, 151);
            this.dateTimePicker1.MinDate = new System.DateTime(2024, 3, 10, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(117, 44);
            this.dateTimePicker1.TabIndex = 47;
            this.dateTimePicker1.Value = new System.DateTime(2024, 3, 10, 0, 0, 0, 0);
            // 
            // egoldsGoogleTextBox1
            // 
            this.egoldsGoogleTextBox1.BackColor = System.Drawing.Color.White;
            this.egoldsGoogleTextBox1.BorderColor = System.Drawing.Color.Black;
            this.egoldsGoogleTextBox1.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.egoldsGoogleTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.egoldsGoogleTextBox1.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.egoldsGoogleTextBox1.FontTextPreview = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.egoldsGoogleTextBox1.ForeColor = System.Drawing.Color.Black;
            this.egoldsGoogleTextBox1.Location = new System.Drawing.Point(18, 11);
            this.egoldsGoogleTextBox1.Name = "egoldsGoogleTextBox1";
            this.egoldsGoogleTextBox1.SelectionStart = 0;
            this.egoldsGoogleTextBox1.Size = new System.Drawing.Size(256, 45);
            this.egoldsGoogleTextBox1.TabIndex = 36;
            this.egoldsGoogleTextBox1.TextInput = "";
            this.egoldsGoogleTextBox1.TextPreview = "Назва";
            this.egoldsGoogleTextBox1.UseSystemPasswordChar = false;
            // 
            // yt_Button2
            // 
            this.yt_Button2.BackColor = System.Drawing.Color.DarkGreen;
            this.yt_Button2.BackColorAdditional = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.yt_Button2.BackColorGradientEnabled = true;
            this.yt_Button2.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.yt_Button2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.yt_Button2.BorderColorEnabled = false;
            this.yt_Button2.BorderColorOnHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.yt_Button2.BorderColorOnHoverEnabled = false;
            this.yt_Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yt_Button2.Font = new System.Drawing.Font("Montserrat Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yt_Button2.ForeColor = System.Drawing.Color.White;
            this.yt_Button2.Location = new System.Drawing.Point(56, 340);
            this.yt_Button2.Name = "yt_Button2";
            this.yt_Button2.RippleColor = System.Drawing.Color.Black;
            this.yt_Button2.Rounding = 60;
            this.yt_Button2.RoundingEnable = true;
            this.yt_Button2.Size = new System.Drawing.Size(270, 49);
            this.yt_Button2.TabIndex = 38;
            this.yt_Button2.Text = "Створити маршрут";
            this.yt_Button2.TextHover = null;
            this.yt_Button2.UseDownPressEffectOnClick = false;
            this.yt_Button2.UseRippleEffect = true;
            this.yt_Button2.UseVisualStyleBackColor = false;
            this.yt_Button2.UseZoomEffectOnHover = false;
            this.yt_Button2.Click += new System.EventHandler(this.yt_Button2_Click);
            // 
            // AdminAddRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 419);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.yt_Button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminAddRoute";
            this.Text = "AdminAddRoute";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private yt_Button yt_Button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private yt_Button yt_Button2;
        private EgoldsGoogleTextBox egoldsGoogleTextBox1;
        private EgoldsGoogleTextBox egoldsGoogleTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}