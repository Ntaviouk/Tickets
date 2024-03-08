using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yt_DesignUI.Components;
using Tickets.Forms;
using Tickets.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using yt_DesignUI;
using System.Drawing.Drawing2D;


namespace Tickets.Forms
{
    public partial class Main : Form
    {
        private Account loggedInAccount;
        private List<Route> routes = new List<Route>();
        private List<CityStop> cityStops = new List<CityStop>();
        private int currentIndex;
        public Main(Account account)
        {
            InitializeComponent();
            loggedInAccount = account;
            DoMain();
        }

        private void DoMain()
        {
            egoldsFormStyle1.HeaderColor = Color.FromArgb(53, 78, 44);
            egoldsFormStyle1.BackColor = Color.FromArgb(53, 78, 44);
            //egoldsFormStyle1.FormStyle = EgoldsFormStyle.fStyle.UserStyle;
            SetStyle(this);
            OffPanels();
            routes.Clear();
            cityStops.Clear();
            currentIndex = 0;
            routes.AddRange(DataBase.routes);


            SetcityStops();
            DisplayPanels();
        }

        private void SetcityStops()
        {
            foreach (var route in DataBase.routes)
            {
                cityStops.Add(route.Stops[0]);
                cityStops.Add(route.Stops[route.Stops.Count - 1]);
            }
        }

        private void SetStyle(Control control)
        {
            //label1.BackColor = Color.FromArgb(80, 0xD8, 0xD8, 0xD8);
            button1.BackColor = Color.FromArgb(53, 78, 44);
            button4.BackColor = Color.FromArgb(232, 232, 232);
            button5.BackColor = Color.FromArgb(232, 232, 232);
            button6.BackColor = Color.FromArgb(232, 232, 232);

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
            pictureBox6.BackColor = SystemColors.Control;
            pictureBox2.BackColor = Color.White;
            pictureBox20.BackColor = Color.FromArgb(53, 78, 44);
            pictureBox21.BackColor = Color.FromArgb(53, 78, 44);

            RoutePictureBox(pictureBox12, 50);
            RoutePictureBox(pictureBox8, 50);
            RoutePictureBox(pictureBox18, 50);
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string temp = egoldsGoogleTextBox1.Text;
            egoldsGoogleTextBox1.Text = egoldsGoogleTextBox2.Text;
            egoldsGoogleTextBox2.Text = temp;
        }
        private void PanelVisible(Panel panel, bool status)
        {
            panel.Visible = status;
        }
        private void OffPanels()
        {
            PanelVisible(panel1, false);
            PanelVisible(panel2, false);
            PanelVisible(panel3, false);
        }

        private void DisplayPanels()
        {
            OffPanels();


            for (int i = currentIndex; i < Math.Min(routes.Count, currentIndex + 3); i++)
            {
                switch (i - currentIndex)
                {
                    case 0:
                        Panel1(routes[i], cityStops[i * 2], cityStops[i * 2 + 1]);
                        break;
                    case 1:
                        Panel2(routes[i], cityStops[i * 2], cityStops[i * 2 + 1]);
                        break;
                    case 2:
                        Panel3(routes[i], cityStops[i * 2], cityStops[i * 2 + 1]);
                        break;
                    default:
                        break;
                }
            }

            // Визначення видимості кнопок перемикання
            if (routes.Count > 3)
            {
                button2.Enabled = currentIndex >= 3;
                button3.Enabled = currentIndex + 3 < routes.Count;
            }
            else
            {
                button2.Enabled = false;
                button3.Enabled = false;
            }
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

        private void Panel2(Route route, CityStop city1, CityStop city2)
        {
            PanelVisible(panel2, true);
            label12.Text = route.RouteName;
            label9.Text = city1.CityName;
            label8.Text = city2.CityName;

            label11.Text = city1.ArrivalTime.ToString("HH:mm");
            label10.Text = city2.ArrivalTime.ToString("HH:mm");

            label7.Text = CalculateTimeDifference(city1.ArrivalTime, city2.ArrivalTime);

            if (route.Train.Photo != null)
            {
                pictureBox8.Image = Image.FromFile(route.Train.Photo);
            }
        }

        private void Panel3(Route route, CityStop city1, CityStop city2)
        {
            PanelVisible(panel3, true);
            label18.Text = route.RouteName;
            label15.Text = city1.CityName;
            label14.Text = city2.CityName;

            label17.Text = city1.ArrivalTime.ToString("HH:mm");
            label16.Text = city2.ArrivalTime.ToString("HH:mm");

            label13.Text = CalculateTimeDifference(city1.ArrivalTime, city2.ArrivalTime);

            if (route.Train.Photo != null)
            {
                pictureBox18.Image = Image.FromFile(route.Train.Photo);
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
        private void button1_Click(object sender, EventArgs e)
        {
            bool isFromFilled = !string.IsNullOrEmpty(egoldsGoogleTextBox1.Text);
            bool isToFilled = !string.IsNullOrEmpty(egoldsGoogleTextBox2.Text);

            if (isFromFilled && !isToFilled)
            {
                MessageBox.Show("Заповніть поле Куди", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!isFromFilled && isToFilled)
            {
                MessageBox.Show("Заповніть поле Звідки", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Search(egoldsGoogleTextBox1.Text, egoldsGoogleTextBox2.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (currentIndex >= 3)
            {
                currentIndex -= 3;
                DisplayPanels();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (currentIndex + 3 < routes.Count)
            {
                currentIndex += 3;
                DisplayPanels();
            }
        }
        private void pictureBox20_Click(object sender, EventArgs e)
        {
            YourTickets yourTickets = new YourTickets(loggedInAccount);
            yourTickets.ShowDialog();
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.ShowDialog();
        }

        private void Search(string city1Name, string city2Name)
        {
            if (city1Name == "" && city2Name == "")
            {
                DoMain();
            }
            else
            {
                currentIndex = 0;
                routes.Clear();
                cityStops.Clear();

                foreach (Route route in DataBase.routes)
                {
                    bool city1Found = !string.IsNullOrEmpty(city1Name);
                    bool city2Found = !string.IsNullOrEmpty(city2Name);
                    bool bothCitiesFound = false; // Флаг, що позначає, чи були знайдені обидва міста

                    // Перевіряємо, чи міста city1Name та city2Name знаходяться на маршруті
                    int city1Index = -1;
                    int city2Index = -1;
                    foreach (CityStop cityStop in route.Stops)
                    {
                        if (city1Found && cityStop.CityName.Contains(city1Name))
                        {
                            cityStops.Add(cityStop);
                            city1Index = route.Stops.IndexOf(cityStop);
                            city1Found = false;
                        }
                        else if (city2Found && cityStop.CityName.Contains(city2Name))
                        {
                            cityStops.Add(cityStop);
                            city2Index = route.Stops.IndexOf(cityStop);
                            city2Found = false;
                        }

                        if (city1Index != -1 && city2Index != -1)
                        {
                            bothCitiesFound = true;
                            break;
                        }
                    }

                    if (bothCitiesFound && city1Index < city2Index)
                    {
                        routes.Add(route);
                    }
                }

                DisplayPanels();
            }
        }



        private void SelectOlaceSearch(string route, string city1, string city2)
        {
            List<CityStop> SelectedCities = new List<CityStop>();

            foreach (CityStop city in cityStops)
            {
                if (city.CityName == city1 || city.CityName == city2)
                {
                    SelectedCities.Add(city);
                }
            }

            foreach (Route item in routes)
            {
                if (item.RouteName == route)
                {
                    Ticket ticket = new Ticket(loggedInAccount, item, SelectedCities, new List<String>());
                    SelectPlace selectPlace = new SelectPlace(this, ticket);

                    this.Hide();
                    selectPlace.Show();
                    break;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SelectOlaceSearch(label2.Text, label4.Text, label5.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SelectOlaceSearch(label12.Text, label9.Text, label8.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SelectOlaceSearch(label18.Text, label15.Text, label14.Text);
        }
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            SignIn sign = new SignIn();
            sign.Show();
        }


    }
}
