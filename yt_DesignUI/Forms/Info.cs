using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tickets.Forms
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
            DoMain();
        }

        private void DoMain()
        {
            egoldsFormStyle1.HeaderColor = Color.FromArgb(53, 78, 44);
            egoldsFormStyle1.BackColor = Color.FromArgb(53, 78, 44);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string instagramUrl = "https://www.instagram.com/dimasdaniuk0811/";
            System.Diagnostics.Process.Start(instagramUrl);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string instagramUrl = "https://github.com/Ntaviouk";
            System.Diagnostics.Process.Start(instagramUrl);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string instagramUrl = "https://t.me/Ntaviouk";
            System.Diagnostics.Process.Start(instagramUrl);
        }

        private void yt_Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
