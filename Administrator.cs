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
    public partial class Administrator : Form
    {
        public Administrator()
        {
            InitializeComponent();
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            try//прячем подразделы "Меню" и перемещаем панель "Запросы" наверх
            {
                if (serviceButton.Visible == false)
                {
                    queryPanel.Left = 0;
                    queryPanel.Top = 130;
                }
                else
                {
                    queryPanel.Left = 0;
                    queryPanel.Top = 50;
                };

            }
            catch
            {
                MessageBox.Show("Ничё не вышло");
            };
            if ( serviceButton.Visible == true)
            {
                serviceButton.Visible = false;
            }
            else
            {
                serviceButton.Visible = true;
            }
            
        }

        private void queryButton_Click_1(object sender, EventArgs e)
        {

            //Прячем  или показваем подразделы "Запросы"
            if (autoQuery.Visible == true)
            {
                autoQuery.Visible = false;
                callQuery.Visible = false;
                serviceQuery.Visible = false;
                staffQuery.Visible = false;
                tarifQuery.Visible = false;
            }
            else
            {
                autoQuery.Visible = true;
                callQuery.Visible = true;
                serviceQuery.Visible = true;
                staffQuery.Visible = true;
                tarifQuery.Visible = true;
            }
        }

        private void serviceButton_Click(object sender, EventArgs e)
        { //Открываем окно редактирования Администратора
            EditAdmin edam = new EditAdmin();
            edam.Show();
        }

        private void autoQuery_Click(object sender, EventArgs e)
        {//Делаем запрос на выведение данных из таблицы авто
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

        private void callQuery_Click(object sender, EventArgs e)
        {//Делаем запрос на выведение данных из таблицы заказы
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

        private void serviceQuery_Click(object sender, EventArgs e)
        {//Делаем запрос на выведение данных из таблицы сервис
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

        private void staffQuery_Click(object sender, EventArgs e)
        {//Делаем запрос на выведение данных из таблицы сотрудники
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

        private void tarifQuery_Click(object sender, EventArgs e)
        {//Делаем запрос на выведение данных из таблицы тариф
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
    }
}
