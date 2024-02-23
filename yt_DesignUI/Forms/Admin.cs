using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tickets.Forms;

namespace Tickets.Forms
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void yt_Button1_Click(object sender, EventArgs e)
        {
            AdminAddCarriage carriage = new AdminAddCarriage();
            carriage.Show();
        }

        private void yt_Button2_Click(object sender, EventArgs e)
        {
            AdminAddTrain train = new AdminAddTrain();
            train.Show();
        }

        private void yt_Button3_Click(object sender, EventArgs e)
        {
            AdminAddRoute route = new AdminAddRoute();
            route.Show();
        }
    }
}
