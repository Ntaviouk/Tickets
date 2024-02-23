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
    public partial class AdminAddCarriage : Form
    {
        public AdminAddCarriage()
        {
            InitializeComponent();
        }

        private void yt_Button2_Click(object sender, EventArgs e)
        {
            Carriage carriage = new Carriage(egoldsGoogleTextBox1.Text, egoldsGoogleTextBox2.Text, Int32.Parse(egoldsGoogleTextBox3.Text), true);
            DataBase.carriages.Add(carriage);
            Save();
            this.Close();
        }

        private void Save()
        {
            SaveToJson save = new SaveToJson();
            save.Save("Carriages.json", DataBase.carriages);
        }
    }
}
