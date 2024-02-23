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
using yt_DesignUI.Forms;
using yt_DesignUI.Models;
using yt_DesignUI.Serializable;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace yt_DesignUI
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
            egoldsGoogleTextBox2.UseSystemPasswordChar = true;
            Load();
            
        }

        private void yt_Button2_Click(object sender, EventArgs e)
        {

            string EmailUser = egoldsGoogleTextBox1.Text;
            string PasswordUser = egoldsGoogleTextBox2.Text;

            if (EmailUser == "admin" && PasswordUser == "admin")
            {
                this.Hide();
                Admin admin = new Admin();
                admin.Show();
            }else
            {
                DB db = new DB();
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT * FROM `accounts` WHERE `Email` = @uE AND `Password` = @uP", db.GetConnection());
                command.Parameters.Add("@uE", MySqlDbType.VarChar).Value = EmailUser;
                command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = HashPassword(PasswordUser);

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    DataRow row = table.Rows[0];
                    string name = row["Name"].ToString();
                    string surname = row["Surname"].ToString();
                    string email = row["Email"].ToString();
                    string password = row["Password"].ToString();

                    Account loggedInAccount = new Account(name, surname, email, password);
                    this.Hide();
                    Main main = new Main(loggedInAccount);
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Невірний логін або пароль", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            
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
        private void label1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.Show();
            
        }
        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.Show();
        }

        private void Load()
        {
            SaveToJson load = new SaveToJson();

            DataBase.accounts = load.Load<Account>("Accounts.json");
            DataBase.carriages = load.Load<Carriage>("Carriages.json");
            DataBase.trains = load.Load<Train>("Trains.json");
            DataBase.routes = load.Load<Route>("Routes.json");
        }

        private void SignIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        
    }
}
