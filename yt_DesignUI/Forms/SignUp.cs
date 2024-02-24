using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tickets;
using Tickets.Models;
using Tickets.Serializable;

namespace yt_DesignUI
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignIn signIn = new SignIn();
            signIn.Show();
        }

        

        private void yt_Button2_Click(object sender, EventArgs e)
        {
            
            DB dB = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `accounts` (`Name`, `Surname`, `Email`, `Password`) VALUES (@name, @surname, @email, @password);",dB.GetConnection());
            command.Parameters.Add("@name",MySqlDbType.VarChar).Value=egoldsGoogleTextBox1.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = egoldsGoogleTextBox2.Text;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = egoldsGoogleTextBox3.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = HashPassword(egoldsGoogleTextBox4.Text);

            dB.OpenConnection();

            if(command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успішно створений", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                SignIn signIn = new SignIn();
                signIn.Show();
            }

            dB.CloseConnection();
        }
        private string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        private void SignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            SignIn sign = new SignIn();
            sign.Show();
        }

        private void Save()
        {
            SaveToJson save = new SaveToJson();
            save.Save("Accounts.json", DataBase.accounts);
        }
    }
}
