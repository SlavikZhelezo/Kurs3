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

namespace Kurs3
{
    public partial class Autorization : Form
    {
        public Autorization()
        {
            InitializeComponent();
        }

        public class Safety
        {
            public static string Hash(string value)
            {
                var sha1 = System.Security.Cryptography.SHA1.Create();
                var inputBytes = Encoding.UTF8.GetBytes(value);
                var hash = sha1.ComputeHash(inputBytes);

                var sb = new StringBuilder();
                for (var i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            string Director = "12a447b6bda6611f1ca0ff50a33eb90bf89e3451";
            string Administrator = "1eda23758be9e36e5e0d2a6a87de584aaca0193f";
            string Operator = "d0e687b079fb70f2208d1f8d2c75d64d74925496";
            try
            {
                string LoginUser = loginField.Text;
                string Password = passField.Text;

                if (LoginUser == "" || Password == "")
                    MessageBox.Show("Заполните поля");
                if (LoginUser.Length < 5 || Password.Length < 5)
                    MessageBox.Show("Недостаточно символов. Не менее 5-ти символов");

                DBconnect db = new DBconnect();
                using (MySqlCommand command = new MySqlCommand("SELECT id_user, password, comment FROM user WHERE user=@Login;", db.getConnection()))
                {
                    command.Parameters.AddWithValue("@Login", LoginUser);
                    db.openConnection();


                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string id = Convert.ToString(reader["id_user"]);
                        string password = Convert.ToString(reader["password"]);
                        string comment = Convert.ToString(reader["comment"]);
                        string hashedPassword = Safety.Hash(Password);
                        password = password.ToUpper();//перевод пароля из БД в верхний регистр

                        DBconnect.SimpleString = id;

                        if (password != hashedPassword)
                        {
                            MessageBox.Show("Неверный пароль");
                        }
                        else if (password == hashedPassword & comment == Director)
                        {
                            Director dirFORM = new Director();
                            dirFORM.Show();
                            this.Hide();
                        }
                        else if (password == hashedPassword & comment == Administrator)
                        {
                            Administrator admFORM = new Administrator();
                            admFORM.Show();
                            this.Hide();
                        }
                        else if(password == hashedPassword & comment == Operator)
                        {
                            OperMainForm operFORM = new OperMainForm();
                            MessageBox.Show(id);
                            operFORM.Show();
                            this.Hide();
                        }
                        else if (password == hashedPassword & comment == "Director")
                        {
                            OperMainForm operFORM = new OperMainForm();
                            operFORM.Show();
                            this.Hide();
                        }
                    }
                    db.closeConnection();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
