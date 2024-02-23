﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yt_DesignUI.Models;

namespace yt_DesignUI.Forms
{
    public partial class SelectPlace : Form
    {
        private Account LoggedInAccount;
        private Route SelectedRoute;
        private Form PreviousForm;
        private List<CityStop> SelectedCities = new List<CityStop>();
        public SelectPlace(Account loggedInaccount, Route selectedroute, Form previousform, List<CityStop> selectedCities)
        {
            InitializeComponent();
            LoggedInAccount = loggedInaccount;
            SelectedRoute = selectedroute;
            PreviousForm = previousform;
            SelectedCities = selectedCities;

            DoMain();
            SetBackColors(this);
        }

        private void DoMain()
        {
            egoldsFormStyle1.HeaderColor = Color.FromArgb(53, 78, 44);
            egoldsFormStyle1.BackColor = Color.FromArgb(53, 78, 44);
            Panel1(SelectedRoute, SelectedCities[0], SelectedCities[1]);
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
            }
            pictureBox3.BackColor = SystemColors.Control;
        }

        private void PanelVisible(Panel panel, bool status)
        {
            panel.Visible = status;
        }
        private void Panel1(Route route, CityStop city1, CityStop city2)
        {
            PanelVisible(panel1, true);
            label2.Text = route.RouteName;
            label4.Text = city1.CityName;
            label5.Text = city2.CityName;

            label1.Text = city1.ArrivalTime.ToString("HH:mm");
            label3.Text = city2.ArrivalTime.ToString("HH:mm");

            label6.Text = CalculateTimeDifference(city1.ArrivalTime, city2.ArrivalTime);
        }

        private string CalculateTimeDifference(DateTime time1, DateTime time2)
        {

            TimeSpan difference = time2 - time1;
            difference = difference.Duration();

            int hoursDifference = difference.Hours;
            int minutesDifference = difference.Minutes;

            string result = $"{hoursDifference} год. {minutesDifference} хв.";

            return result;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
           this.Close();
           PreviousForm.Show();   
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            PreviousForm.Show();
        }
        private void SelectPlace_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                PreviousForm.Show();
            }
        }
    }
}