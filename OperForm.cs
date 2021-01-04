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
    public partial class OperMainForm : Form
    {
        public OperMainForm()
        {
            InitializeComponent();
        }


        //Строка для переменной с ID оператора
        /*String login = */
        String login = "13";
        
        private void orderButton_Click(object sender, EventArgs e)
        {
            OperatorQuery query = new OperatorQuery();
            query.Show();
        }

        public string Vremya(string vrem)
        {
            object x = DateTime.Now;
            return x.ToString();
        }

        private void orderPay_Click(object sender, EventArgs e)
        {

            string str = "server=localhost;user=root;password=Semenovski3Polk13;database=cab_company;port=3306";
            MySqlConnection connection = new MySqlConnection(str);
            try
            {
                connection.Open();
                string phone = phoneField.Text;
                string fromstop = whereField.Text;
                string tostop = toField.Text;
                string tarif = tarifField.Text;
                string service = serviceField.Text;
                string auto = autoField.Text;
                string stoperid = login;
                object x = DateTime.Now;
                string z = x.ToString();

                String sql = "insert into cab_company.called (`TimeOrder`, `phone_number`, `wherefrom`, `whereto`, `tariffid`, `servicesid`, `AutoID`, `staffoperid`) values('" + z + "', " + phone + ", '" + fromstop + "', '" + tostop + "', " + tarif + ", " + service + ", " + auto + ", " + stoperid + ");";
                MessageBox.Show(sql.ToString());
                
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection);
                connection.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}

/*
private System.Windows.Forms.Label time_actual;
private System.Windows.Forms.Label phoneNumber;
private System.Windows.Forms.Label From;
private System.Windows.Forms.Label To;
private System.Windows.Forms.Label tariff;
private System.Windows.Forms.Label services;
private System.Windows.Forms.Label auto;
private System.Windows.Forms.TextBox textBox1;
private System.Windows.Forms.TextBox textBox2;
private System.Windows.Forms.TextBox textBox3;
private System.Windows.Forms.TextBox textBox4;
private System.Windows.Forms.TextBox textBox5;
private System.Windows.Forms.TextBox textBox6;
private System.Windows.Forms.TextBox textBox7;
private System.Windows.Forms.Panel MenuPanel;
private System.Windows.Forms.Label driverButton;
private System.Windows.Forms.Label tarifButton;
private System.Windows.Forms.Label servicesButton;
private System.Windows.Forms.Label MenuLabel;

    */
/*private void button1_Click(object sender, EventArgs e)
{
    string str = "server=localhost;user=root;password=123;database=proba;port=3306";
    MySqlConnection connection = new MySqlConnection(str);
    try
    {
        connection.Open();
        string sql = "SELECT * FROM zakazchik;";
        MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection);
        DataSet ds = new DataSet();
        adapter.Fill(ds);
        dataGridView1.DataSource = ds.Tables[0];
        connection.Close();
    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.ToString());
    }
}*/
