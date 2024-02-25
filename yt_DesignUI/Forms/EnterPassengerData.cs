using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tickets.Models;

namespace Tickets.Forms
{
    public partial class EnterPassengerData : Form
    {
        private Account LoggedInAccount;
        private Route SelectedRoute;
        private Form PreviousForm;
        private string SelectedCarriageType;
        private int SelectedCarriageSeat;
        private List<CityStop> SelectedCities = new List<CityStop>();
        public EnterPassengerData(Account loggedinaccount, Route selectedroute, Form previousform, string selectedcarriagetype, int selectedcarriageseat, List<CityStop> selectedcities)
        {
            InitializeComponent();
            LoggedInAccount = loggedinaccount;
            SelectedRoute = selectedroute;
            PreviousForm = previousform;
            SelectedCarriageType = selectedcarriagetype;
            SelectedCarriageSeat = selectedcarriageseat;
            SelectedCities = selectedcities;

            DoMain();
        }

        private void DoMain()
        {
            egoldsFormStyle1.HeaderColor = Color.FromArgb(53, 78, 44);
            egoldsFormStyle1.BackColor = Color.FromArgb(53, 78, 44);
            SetBackColors(this);


        }

        private void SetBackColors(Control control)
        {

            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is Label)
                {
                    ((Label)ctrl).BackColor = Color.FromArgb(232, 232, 232);
                }

                if (ctrl is PictureBox)
                {
                    ((PictureBox)ctrl).BackColor = Color.FromArgb(232, 232, 232);
                }

                if (ctrl.HasChildren)
                {
                    SetBackColors(ctrl);
                }

                //if (ctrl is System.Windows.Forms.Button)
                //{
                //    SetButtonsBackColor((System.Windows.Forms.Button)ctrl);
                //}

                pictureBox4.BackColor = SystemColors.Control;
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            PreviousForm.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
            PreviousForm.Show();
        }
        private void EnterPassengerData_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                PreviousForm.Show();
            }
        }

        
    }
}
