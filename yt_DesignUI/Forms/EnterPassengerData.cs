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
using yt_DesignUI;

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
            SetTextBoxes(LoggedInAccount);
            SetPrice();
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
                if (ctrl is EgoldsToggleSwitch)
                {
                    ((EgoldsToggleSwitch)ctrl).BackColorON = Color.FromArgb(53, 78, 44);
                    //((EgoldsToggleSwitch)ctrl).BackColor = Color.FromArgb(0xC2, 0xD8, 0xBA);
                }

                //if (ctrl is System.Windows.Forms.Button)
                //{
                //    SetButtonsBackColor((System.Windows.Forms.Button)ctrl);
                //}

                pictureBox4.BackColor = SystemColors.Control;
            }
        }

        private void SetTextBoxes(Account account)
        {
            egoldsGoogleTextBox1.Text = account.Name;
            egoldsGoogleTextBox2.Text = account.Surname;
            egoldsGoogleTextBox3.Text = account.Email;
        }
        private Carriage SearchCariage(Route route)
        {
            foreach (Carriage item in route.Train.Carriages)
            {
                if (item.Type == SelectedCarriageType)
                {
                    return item;
                }
            }
            return null;
        }
        private void SetPrice()
        {
            label7.Text = $"{SearchCariage(SelectedRoute).Price}₴";
        }

        private void PlusPrice(double Price)
        {
            label7.Text = $"{Double.Parse(label7.Text.Substring(0, label7.Text.Length - 1)) + Price}₴";
        }

        private void egoldsToggleSwitch1_CheckedChanged(object sender)
        {
            UpdatePrice(70, egoldsToggleSwitch1.Checked);
        }

        private void egoldsToggleSwitch2_CheckedChanged(object sender)
        {
            UpdatePrice(30, egoldsToggleSwitch2.Checked);
        }

        private void egoldsToggleSwitch3_CheckedChanged(object sender)
        {
            UpdatePrice(30, egoldsToggleSwitch3.Checked);
        }

        private void egoldsToggleSwitch5_CheckedChanged(object sender)
        {
            UpdatePrice(70, egoldsToggleSwitch5.Checked);
        }

        private void egoldsToggleSwitch6_CheckedChanged(object sender)
        {
            UpdatePrice(40, egoldsToggleSwitch6.Checked);
        }

        private void UpdatePrice(int priceChange, bool isChecked)
        {
            if (isChecked)
                PlusPrice(priceChange);
            else
                PlusPrice(-priceChange);
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

        private void button4_Click(object sender, EventArgs e)
        {
            SearchCariage(SelectedRoute).BuySeat(SelectedCarriageSeat);
            Save();

            this.Hide();
            Main main = new Main(LoggedInAccount); 
            main.Show();
        }

        private void Save()
        {
            SaveToJson save = new SaveToJson();
            save.Save("Routes.json", DataBase.routes);
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text.Length == 19 && maskedTextBox2.Text.Length == 2 && maskedTextBox3.Text.Length == 2 && maskedTextBox4.Text.Length == 3)
            {
                button4.Enabled = true;
            }
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
