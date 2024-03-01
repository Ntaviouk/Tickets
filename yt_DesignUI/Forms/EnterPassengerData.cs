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
        private Form PreviousForm;
        private Ticket Ticket;

        public EnterPassengerData(Form previousform, Ticket ticket)
        {
            InitializeComponent();
            PreviousForm = previousform;
            Ticket = ticket;
            

            DoMain();
        }
        private void DoMain()
        {
            egoldsFormStyle1.HeaderColor = Color.FromArgb(53, 78, 44);
            egoldsFormStyle1.BackColor = Color.FromArgb(53, 78, 44);
            SetBackColors(this);
            SetTextBoxes(Ticket.LoggedAccount);
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
                pictureBox20.BackColor = Color.FromArgb(53, 78, 44);
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
                if (item.Type == Ticket.SelectedCarriage.Type)
                {
                    return item;
                }
            }
            return null;
        }
        private void SetPrice()
        {
            label7.Text = $"{SearchCariage(Ticket.SelectedRoute).Price}₴";
        }

        private void PlusPrice(double Price)
        {
            label7.Text = $"{Double.Parse(label7.Text.Substring(0, label7.Text.Length - 1)) + Price}₴";
        }

        private void egoldsToggleSwitch1_CheckedChanged(object sender)
        {
            UpdatePrice(70, egoldsToggleSwitch1.Checked, "Постільна білизна");
        }

        private void egoldsToggleSwitch2_CheckedChanged(object sender)
        {
            UpdatePrice(30, egoldsToggleSwitch2.Checked, "Авторський чай");
        }

        private void egoldsToggleSwitch3_CheckedChanged(object sender)
        {
            UpdatePrice(30, egoldsToggleSwitch3.Checked, "Чайний збір");
        }

        private void egoldsToggleSwitch5_CheckedChanged(object sender)
        {
            UpdatePrice(70, egoldsToggleSwitch5.Checked, "Дріп кава");
        }

        private void egoldsToggleSwitch6_CheckedChanged(object sender)
        {
            UpdatePrice(40, egoldsToggleSwitch6.Checked, "Фірмове печиво");
        }

        private void UpdatePrice(int priceChange, bool isChecked, string name)
        {
            if (isChecked)
            {
                PlusPrice(priceChange);
                Ticket.AddAdditionalInfo(name);
            }
            else
            {
                PlusPrice(-priceChange);
                Ticket.RemoveAdditionalInfo(name);
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

        private void button4_Click(object sender, EventArgs e)
        {
            SearchCariage(Ticket.SelectedRoute).BuySeat(Ticket.SelectedCarriageSeat);
            Ticket.SetPrice(Double.Parse(label7.Text.Substring(0, label7.Text.Length - 1)));
            DataBase.tickets.Add(Ticket);
            Save();

            this.Hide();


            Main main = new Main(Ticket.LoggedAccount); 
            main.Show();
        }

        private void Save()
        {
            SaveToJson save = new SaveToJson();
            save.Save("Routes.json", DataBase.routes);
            save.Save("Tickets.json", DataBase.tickets);
            
        }
        private void pictureBox20_Click(object sender, EventArgs e)
        {
            YourTickets yourTickets = new YourTickets(Ticket.LoggedAccount);
            yourTickets.ShowDialog();
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
