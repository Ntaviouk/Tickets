using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tickets.Models;
using Tickets.Serializable;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tickets.Forms
{
    public partial class AdminAddTrain : Form
    {
        private Train train;
        Random random = new Random();
        public AdminAddTrain()
        {
            InitializeComponent();
            DoMain();
        }
        
        private void DoMain()
        {
            SetComboBox();
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
        private void yt_Button2_Click(object sender, EventArgs e)
        {
            
            if (train == null)
            {
                train = new Train(egoldsGoogleTextBox1.Text, egoldsGoogleTextBox2.Text, new List<Carriage>(),null);
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
            //yt_Button1.Enabled = false;
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
        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (train != null)
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png|All files (*.*)|*.*";
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string selectedFilePath = openFileDialog.FileName;
                        string fileExtension = Path.GetExtension(selectedFilePath);
                        string folderPath = Path.Combine(Application.StartupPath, "TrainPhotos");
                        string destinationPath = Path.Combine(folderPath, train.Name + $"_#{random.Next(10000, 99999)}" + fileExtension);

                        File.Copy(selectedFilePath, destinationPath, true);

                        pictureBox12.Image = Image.FromFile(destinationPath);
                        train.AddPhoto(destinationPath);

                    }
                }
            }
            else
            {
                MessageBox.Show("Спочатку створіть новий потяг", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}
