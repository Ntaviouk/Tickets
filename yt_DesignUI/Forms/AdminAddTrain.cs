using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yt_DesignUI.Models;
using yt_DesignUI.Serializable;

namespace yt_DesignUI.Forms
{
    public partial class AdminAddTrain : Form
    {
        private Train train;
        public AdminAddTrain()
        {
            InitializeComponent();
            SetComboBox();
        }

        private void yt_Button2_Click(object sender, EventArgs e)
        {
            
            if (yt_Button2.Text != "OK")
            {
                train = new Train(egoldsGoogleTextBox1.Text, egoldsGoogleTextBox2.Text);
                Clear();
                yt_Button2.Text = "OK";
            }else
            {
                DataBase.trains.Add(train);
                Save();
                this.Close();
            }
        }

        private void yt_Button1_Click(object sender, EventArgs e)
        {
            train.AddCarriage(DataBase.carriages[comboBox1.SelectedIndex]);
            yt_Button1.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            yt_Button1.Enabled = true;
        }

        private void Clear()
        {
            egoldsGoogleTextBox1.Text = null;
            egoldsGoogleTextBox2.Text = null;
            egoldsGoogleTextBox1.Enabled = false;
            egoldsGoogleTextBox2.Enabled = false;

            comboBox1.Enabled = true;
            yt_Button1.Enabled = true;
        }

        private void SetComboBox()
        {
            comboBox1.Items.Clear();
            foreach (Carriage item in DataBase.carriages) 
            {
                comboBox1.Items.Add(item.Name);
            }
        }

        private void Save()
        {
            SaveToJson save = new SaveToJson();
            save.Save("Trains.json", DataBase.trains);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void egoldsGoogleTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void egoldsGoogleTextBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
