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
            DBconnect db = new DBconnect();

            string phone = phoneField.Text;
            string fromstop = whereField.Text;
            string tostop = toField.Text;
            string stoperid = DBconnect.SimpleString;
            object time = DateTime.Now.ToString("yyyy.MM.dd  h:mm:ss");
            string z = time.ToString();
            MessageBox.Show(z);


            //string z = x.ToString();

            if (phone == "" || fromstop == "" || tostop == "" || stoperid == "" || tarif == "" || autoval == "" || servicesval == "")
                MessageBox.Show("Заполните поля");
            try
            {
                MySqlCommand command = new MySqlCommand("call create_order('"+ z +"','"+ phone +"','"+ fromstop +"','"+ tostop +"','"+ tarif +"', '"+ servicesval +"','"+ autoval +"','"+ stoperid +"')", db.getConnection());
                db.openConnection();
                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Заказ сохранен и передан в обработку");
                else
                    MessageBox.Show("Ошибка  при  создании заказа");

                db.closeConnection();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        string tarif;
        string servicesval;
        string autoval;
        private void tarifBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            tarif = tarifBox.SelectedIndex.ToString();
            if (tarif == "0")
                tarif = "101";
            else if (tarif == "1")
                tarif = "102";
            else if (tarif == "2")
                tarif = "103";
            else if (tarif == "3")
                tarif = "104";
        }

        private void servicesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            servicesval = servicesBox.SelectedIndex.ToString();
            if (servicesval == "0")
                servicesval = "20";
            else if (servicesval == "1")
                servicesval = "21";
            else if (servicesval == "2")
                servicesval = "22";
            else if (servicesval == "3")
                servicesval = "23";
            else if (servicesval == "4")
                servicesval = "24";

        }

        private void autoBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            autoval = autoBox.SelectedIndex.ToString();
            if (autoval == "0")
                autoval = "15";
            else if (autoval == "1")
                autoval = "16";
            else if (autoval == "2")
                autoval = "11";
            else if (autoval == "3")
                autoval = "17";
            else if (autoval == "4")
                autoval = "18";
            else if (autoval == "5")
                autoval = "10";
            else if (autoval == "6")
                autoval = "12";
            else if (autoval == "7")
                autoval = "14";
            else if (autoval == "8")
                autoval = "13";

        }
    }
}

