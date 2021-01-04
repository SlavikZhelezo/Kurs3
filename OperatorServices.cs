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
    public partial class OperatorQuery : Form
    {
        public OperatorQuery()
        {
            InitializeComponent();
        }

        private void servicesButton_Click(object sender, EventArgs e)
        {
            string str = "server=localhost;user=root;password=Semenovski3Polk13;database=cab_company;port=3306";
            MySqlConnection connection = new MySqlConnection(str);
            try
            {
                connection.Open();
                string sql = "SELECT * FROM services ";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataWindow.DataSource = ds.Tables[0];
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tarifButton_Click(object sender, EventArgs e)
        {            
            string str = "server=localhost;user=root;password=Semenovski3Polk13;database=cab_company;port=3306";
            MySqlConnection connection = new MySqlConnection(str);
            try
            {
                connection.Open();
                string sql = "SELECT * FROM tariff ";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataWindow.DataSource = ds.Tables[0];
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void driverButton_Click(object sender, EventArgs e)
        {
            string str = "server=localhost;user=root;password=Semenovski3Polk13;database=cab_company;port=3306";
            MySqlConnection connection = new MySqlConnection(str);
            try
            {
                connection.Open();
                string sql = "SELECT staffid, name, phone_number FROM staff where positionid = '2';";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataWindow.DataSource = ds.Tables[0];
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
