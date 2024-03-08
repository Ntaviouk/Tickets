using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tickets.Models;

namespace Tickets.Forms
{
    public partial class SelectPlace : Form
    {
        private Form PreviousForm;
        private Ticket Ticket;
        
         public SelectPlace(Form previousform, Ticket ticket)
        {
            InitializeComponent();
            PreviousForm = previousform;
            Ticket = ticket;

            DoMain();
            SetBackColors(this);
        }

        private void DoMain()
        {
            egoldsFormStyle1.HeaderColor = Color.FromArgb(53, 78, 44);
            egoldsFormStyle1.BackColor = Color.FromArgb(53, 78, 44);
            Panel1(Ticket.SelectedRoute, Ticket.SelectedCities[0], Ticket.SelectedCities[1]);

            SetComboBox1();
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

                if (ctrl is System.Windows.Forms.Button)
                {
                    SetButtonsBackColor((System.Windows.Forms.Button)ctrl);
                }
            }
            pictureBox3.BackColor = SystemColors.Control;
            pictureBox6.BackColor = SystemColors.Control;
            button4.BackColor = Color.FromArgb(232, 232, 232);
            pictureBox20.BackColor = Color.FromArgb(53, 78, 44);
            pictureBox21.BackColor = Color.FromArgb(53, 78, 44);

            RoutePictureBox(pictureBox12, 50);
        }

        private void RoutePictureBox(PictureBox _pictureBox, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(_pictureBox.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(_pictureBox.Width - radius, _pictureBox.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, _pictureBox.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            _pictureBox.Region = new Region(path);
        }

        private void SetButtonsBackColor(System.Windows.Forms.Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
        }

        private void PanelVisible(Panel panel, bool status)
        {
            panel.Visible = status;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ticket.AddPlace(SearchCariage(Ticket.SelectedRoute), Convert.ToInt32(comboBox2.SelectedItem));
            EnterPassengerData enter = new EnterPassengerData(this, Ticket);
            
            enter.Show();
            this.Hide();
        }

        private Carriage SearchCariage(Route route)
        {
            foreach (Carriage item in route.Train.Carriages)
            {
                if (item.Type == comboBox1.SelectedItem)
                {
                    return item;
                }
            }
            return null;
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

            if (route.Train.Photo != null)
            {
                pictureBox12.Image = Image.FromFile(route.Train.Photo);
            }
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
        private void SetPrice(Carriage carriage)
        {
            label7.Text = $"{carriage.Price}₴";
        }
        private void SetComboBox1()
        {
            comboBox1.Items.Clear();
            foreach (Carriage item in Ticket.SelectedRoute.Train.Carriages) 
            {
                comboBox1.Items.Add(item.Type);
            }
        }

        private void SetComboBox2(Carriage carriage)
        {
            comboBox2.Items.Clear();
            comboBox2.Enabled = true;
            if (carriage != null)
            {
                foreach (int item in carriage.Seats)
                {
                    comboBox2.Items.Add(item);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in Ticket.SelectedRoute.Train.Carriages)
            {
                if (item.Type == comboBox1.SelectedItem)
                {
                    SetComboBox2(item);
                    SetPrice(item);
                }

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            button4.Enabled = true; 
        }
        private void pictureBox20_Click(object sender, EventArgs e)
        {
            YourTickets yourTickets = new YourTickets(Ticket.LoggedAccount);
            yourTickets.ShowDialog();
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.ShowDialog();
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
