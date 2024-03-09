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
using Tickets.Serializable;

namespace Tickets.Forms
{
    public partial class AdminAddRoute : Form
    {
        private Route route;
        public AdminAddRoute()
        {
            InitializeComponent();
            SetComboBox();
        }

        private void yt_Button2_Click(object sender, EventArgs e)
        {
            if (route == null)
            {
                Clear();
                route = new Route(egoldsGoogleTextBox1.Text, DataBase.trains[comboBox1.SelectedIndex], new List<CityStop>(), dateTimePicker1.Value);
                yt_Button2.Text = "OK";
                panel1.Visible = false;
                panel2.Visible = true;
            }
            else
            {
                DataBase.routes.Add(route);
                Save();
                this.Close();
            }
        }

        private void SetComboBox()
        {
            comboBox1.Items.Clear();
            foreach (Train item in DataBase.trains)
            {
                comboBox1.Items.Add(item.Name);
            }
        }

        private void Save()
        {
            SaveToJson save = new SaveToJson();
            save.Save("Routes.json", DataBase.routes);
        }

        private void yt_Button1_Click(object sender, EventArgs e)
        {
            route.AddStop(egoldsGoogleTextBox2.Text, DateTime.Parse(maskedTextBox1.Text), DateTime.Parse(maskedTextBox2.Text));

            egoldsGoogleTextBox2.Text = null;
            maskedTextBox1.Text = null;
            maskedTextBox2.Text = null;

        }

        private void Clear()
        {
            egoldsGoogleTextBox1.Enabled = false;
            comboBox1.Enabled = false;

            egoldsGoogleTextBox2.Enabled = true;
            maskedTextBox1.Enabled = true;
            maskedTextBox2.Enabled = true;
            yt_Button1.Enabled = true;

        }

        
    }
}
