using MySql.Data.MySqlClient;
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
using yt_DesignUI;

namespace Tickets.Forms
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void yt_Button2_Click(object sender, EventArgs e)
        {
            string EmailUser = egoldsGoogleTextBox1.Text;

            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `accounts` WHERE `Email` = @uE", db.GetConnection());
            command.Parameters.Add("@uE", MySqlDbType.VarChar).Value = EmailUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Для скидання паролю перейдіть не Вашу пошту і слідуйте інструкціям", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                SignIn signIn = new SignIn();
                signIn.Show();
            }
            else
            {
                MessageBox.Show("Користувача не знайдено", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.Show();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignIn signIn = new SignIn();
            signIn.Show();
        }

        private void ForgotPassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            SignIn signIn = new SignIn();
            signIn.Show();
        }
    }
}
