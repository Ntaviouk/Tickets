using yt_DesignUI;

namespace Tickets.Forms
{
    partial class ForgotPassword
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.yt_Button2 = new yt_DesignUI.yt_Button();
            this.egoldsGoogleTextBox1 = new yt_DesignUI.EgoldsGoogleTextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(70, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "Privacy Policy and Terms of Service apply";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(239, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Увійти";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(94, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "Уже маєте аккаунт?";
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
            this.yt_Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yt_Button2.ForeColor = System.Drawing.Color.White;
            this.yt_Button2.Location = new System.Drawing.Point(24, 271);
            this.yt_Button2.Name = "yt_Button2";
            this.yt_Button2.RippleColor = System.Drawing.Color.Black;
            this.yt_Button2.Rounding = 60;
            this.yt_Button2.RoundingEnable = true;
            this.yt_Button2.Size = new System.Drawing.Size(340, 49);
            this.yt_Button2.TabIndex = 33;
            this.yt_Button2.Text = "Скинути пароль";
            this.yt_Button2.TextHover = null;
            this.yt_Button2.UseDownPressEffectOnClick = false;
            this.yt_Button2.UseRippleEffect = true;
            this.yt_Button2.UseVisualStyleBackColor = false;
            this.yt_Button2.UseZoomEffectOnHover = false;
            this.yt_Button2.Click += new System.EventHandler(this.yt_Button2_Click);
            // 
            // egoldsGoogleTextBox1
            // 
            this.egoldsGoogleTextBox1.BackColor = System.Drawing.Color.White;
            this.egoldsGoogleTextBox1.BorderColor = System.Drawing.Color.Black;
            this.egoldsGoogleTextBox1.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.egoldsGoogleTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.egoldsGoogleTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.egoldsGoogleTextBox1.FontTextPreview = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.egoldsGoogleTextBox1.ForeColor = System.Drawing.Color.Black;
            this.egoldsGoogleTextBox1.Location = new System.Drawing.Point(24, 200);
            this.egoldsGoogleTextBox1.Name = "egoldsGoogleTextBox1";
            this.egoldsGoogleTextBox1.SelectionStart = 0;
            this.egoldsGoogleTextBox1.Size = new System.Drawing.Size(340, 45);
            this.egoldsGoogleTextBox1.TabIndex = 32;
            this.egoldsGoogleTextBox1.TextInput = "";
            this.egoldsGoogleTextBox1.TextPreview = "Електронна пошта";
            this.egoldsGoogleTextBox1.UseSystemPasswordChar = false;
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 429);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yt_Button2);
            this.Controls.Add(this.egoldsGoogleTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPassword";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ForgotPassword_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private yt_Button yt_Button2;
        private EgoldsGoogleTextBox egoldsGoogleTextBox1;
    }
}