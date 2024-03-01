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
    public partial class YourTickets : Form
    {
        private Account LoggedAccount;

        private int currentIndex;
        List<Route> routes = new List<Route>();
        List<CityStop> cityStops = new List<CityStop>();
        List<Ticket> tickets = new List<Ticket>();
        public YourTickets(Account loggedaccount)
        {
            InitializeComponent();
            LoggedAccount = loggedaccount;
            DoMain();
        }
        private void DoMain()
        {
            egoldsFormStyle1.HeaderColor = Color.FromArgb(53, 78, 44);
            egoldsFormStyle1.BackColor = Color.FromArgb(53, 78, 44);
            
            SetStyle(this);
            OffPanels();
            Search();
            currentIndex = 0;
        }
        private void Search()
        {
            foreach (var item in DataBase.tickets)
            {
                if (item.LoggedAccount == LoggedAccount)
                {
                    routes.Add(item.SelectedRoute);
                    tickets.Add(item);
                    cityStops.AddRange(item.SelectedCities);
                }
            }
            DisplayPanels();
        }

        private void SetStyle(Control control)
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
                    SetStyle(ctrl);
                }

                if (ctrl is System.Windows.Forms.Button)
                {
                    SetButtonsBackColor((System.Windows.Forms.Button)ctrl);
                }
            }

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
        private void OffPanels()
        {
            PanelVisible(panel1, false);
            PanelVisible(panel2, false);
        }

        private void Panel1(Route route, CityStop city1, CityStop city2, Ticket ticket)
        {
            PanelVisible(panel1, true);
            label2.Text = route.RouteName;
            label4.Text = city1.CityName;
            label5.Text = city2.CityName;

            label1.Text = city1.ArrivalTime.ToString("HH:mm");
            label3.Text = city2.ArrivalTime.ToString("HH:mm");

            label6.Text = CalculateTimeDifference(city1.ArrivalTime, city2.ArrivalTime);

            label9.Text = $"{ticket.SelectedRoute.Train.Carriages.IndexOf(ticket.SelectedCarriage)+1}";
            label10.Text = $"{ticket.SelectedCarriageSeat}";


        }

        private void Panel2(Route route, CityStop city1, CityStop city2, Ticket ticket)
        {
            PanelVisible(panel2, true);
            label20.Text = route.RouteName;
            label17.Text = city1.CityName;
            label16.Text = city2.CityName;

            label19.Text = city1.ArrivalTime.ToString("HH:mm");
            label18.Text = city2.ArrivalTime.ToString("HH:mm");

            label15.Text = CalculateTimeDifference(city1.ArrivalTime, city2.ArrivalTime);

            label12.Text = $"{ticket.SelectedRoute.Train.Carriages.IndexOf(ticket.SelectedCarriage)+1}";
            label11.Text = $"{ticket.SelectedCarriageSeat}";
        }

        private void DisplayPanels()
        {
            OffPanels();


            for (int i = currentIndex; i < Math.Min(routes.Count, currentIndex + 3); i++)
            {
                switch (i - currentIndex)
                {
                    case 0:
                        Panel1(routes[i], cityStops[i * 2], cityStops[i * 2 + 1], tickets[i]);
                        break;
                    case 1:
                        Panel2(routes[i], cityStops[i * 2], cityStops[i * 2 + 1], tickets[i]);
                        break;
                    default:
                        break;
                }
            }

            // Визначення видимості кнопок перемикання
            if (routes.Count > 2)
            {
                button2.Visible = true;
                button3.Visible = true;

                button2.Enabled = currentIndex >= 2;
                button3.Enabled = currentIndex + 2 < routes.Count;
            }
            else
            {
                button2.Enabled = false;
                button3.Enabled = false;
            }
        }

        static string CalculateTimeDifference(DateTime time1, DateTime time2)
        {

            TimeSpan difference = time2 - time1;
            difference = difference.Duration();

            int hoursDifference = difference.Hours;
            int minutesDifference = difference.Minutes;

            string result = $"{hoursDifference} год. {minutesDifference} хв.";

            return result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (currentIndex >= 2)
            {
                currentIndex -= 2;
                DisplayPanels();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (currentIndex + 2 < routes.Count)
            {
                currentIndex += 2;
                DisplayPanels();
            }
        }
    }
}
