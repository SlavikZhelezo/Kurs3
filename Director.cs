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
    public partial class Director : Form
    {
        public Director()
        {
            InitializeComponent();
        }

        private void tarifQuery_Click(object sender, EventArgs e)
        {
            //Делаем запрос на выведение данных из таблицы тариф
            string str = "server=localhost;user=root;password=Semenovski3Polk13;database=cab_company;port=3306";
            MySqlConnection connection = new MySqlConnection(str);
            try
            {
                connection.Open();
                string sql = "SELECT * FROM tariff";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                windowofdate.DataSource = ds.Tables[0];
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void staffQuery_Click(object sender, EventArgs e)
        {
            //Делаем запрос на выведение данных из таблицы сотрудники
            string str = "server=localhost;user=root;password=Semenovski3Polk13;database=cab_company;port=3306";
            MySqlConnection connection = new MySqlConnection(str);
            try
            {
                connection.Open();
                string sql = "SELECT * FROM staff";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                windowofdate.DataSource = ds.Tables[0];
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void serviceQuery_Click(object sender, EventArgs e)
        {
            //Делаем запрос на выведение данных из таблицы сервис
            string str = "server=localhost;user=root;password=Semenovski3Polk13;database=cab_company;port=3306";
            MySqlConnection connection = new MySqlConnection(str);
            try
            {
                connection.Open();
                string sql = "SELECT * FROM services";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                windowofdate.DataSource = ds.Tables[0];
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void callQuery_Click(object sender, EventArgs e)
        {
            //Делаем запрос на выведение данных из таблицы заказы
            string str = "server=localhost;user=root;password=Semenovski3Polk13;database=cab_company;port=3306";
            MySqlConnection connection = new MySqlConnection(str);
            try
            {
                connection.Open();
                string sql = "SELECT * FROM called";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                windowofdate.DataSource = ds.Tables[0];
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void autoQuery_Click(object sender, EventArgs e)
        {
            //Делаем запрос на выведение данных из таблицы авто
            string str = "server=localhost;user=root;password=Semenovski3Polk13;database=cab_company;port=3306";
            MySqlConnection connection = new MySqlConnection(str);
            try
            {
                connection.Open();
                string sql = "SELECT * FROM auto ";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                windowofdate.DataSource = ds.Tables[0];
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {

        }

        private void positionButton_Click(object sender, EventArgs e)
        {
            //Делаем запрос на выведение данных из таблицы должностей
            string str = "server=localhost;user=root;password=Semenovski3Polk13;database=cab_company;port=3306";
            MySqlConnection connection = new MySqlConnection(str);
            try
            {
                connection.Open();
                string sql = "SELECT * FROM position ";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                windowofdate.DataSource = ds.Tables[0];
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            //Делаем запрос на выведение данных из таблицы пользователи
            string str = "server=localhost;user=root;password=Semenovski3Polk13;database=cab_company;port=3306";
            MySqlConnection connection = new MySqlConnection(str);
            try
            {
                connection.Open();
                string sql = "SELECT * FROM user ";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                windowofdate.DataSource = ds.Tables[0];
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
