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
                var inputBytes = Encoding.ASCII.GetBytes(value);
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
            
            try
            {
                string LoginUser = loginField.Text;
                string Password = passField.Text;

                if (LoginUser == "" || Password == "")
                {
                    MessageBox.Show("Заполните поля");
                }

                if (LoginUser.Length<5 || Password.Length<5)
                {
                    MessageBox.Show("Недостаточно символов. Не менее 5-ти символов");
                }

                string str = "server=localhost;user=root;password=Semenovski3Polk13;database=cab_company;port=3306";
                MySqlConnection connection = new MySqlConnection(str);
                connection.Open();
                string sql = "SELECT * FROM users WHERE `user`=@us and `password` = @pas";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
