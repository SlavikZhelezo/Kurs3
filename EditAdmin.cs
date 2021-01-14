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

namespace Kurs3
{
    public partial class EditAdmin : Form
    {

        public EditAdmin()
        {
            InitializeComponent();
            dataPanel.Visible = false;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            
            DBconnect db = new DBconnect();

            string id = idBox.Text;
            string nameServ = nameBox.Text;
            string descServ = descripBox.Text;
            string costServ = costBox.Text;

            if (id == "" || nameServ == "" || descServ == "" || costServ == "")
                MessageBox.Show("Заполните все поля");
            else
            {
                try
                {
                    MySqlCommand command = new MySqlCommand("call services_add(" + id + ",'" + nameServ + "','" + descServ + "'," + costServ + ")", db.getConnection());


                    db.openConnection();

                    if (command.ExecuteNonQuery() == 1)
                        MessageBox.Show("Услуга успешно добавлена");
                    else
                        MessageBox.Show("Ошибка  при  добавлении услуги");

                    db.closeConnection();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

        }

        private void serviceButton_Click(object sender, EventArgs e)
        {
            dataPanel.Visible = true;
            addPanel.Visible = true;
            addStaff.Visible = false;
            tariffPanel.Visible = false;
        }

        string staff = "";
        string gender = "";
        private void staffButton_Click(object sender, EventArgs e)
        {
            dataPanel.Visible = true;
            addStaff.Visible = true;
            addPanel.Visible = false;
            tariffPanel.Visible = false;

        }

        private void genderCombo_SelectedIndexChanged(object sender, EventArgs e)
        {    
            gender = genderCombo.SelectedIndex.ToString();
            if (gender == "0")
                gender = "муж";
            else if (gender == "1")
                gender = "жен";
        }

        private void positionCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            staff = positionCombo.SelectedIndex.ToString();
            if (staff == "0")
                staff = "4";
            else if (staff == "1")
                staff = "2";
            else if (staff == "2")
                staff = "7";
            else if (staff == "3")
                staff = "10";
            else if (staff == "4")
                staff = "11";
        }

        private void addStaffButton_Click(object sender, EventArgs e)
        {
            DBconnect db = new DBconnect();

            string idStaff = idStaffBox.Text;
            string age = ageBox.Text;
            string phone = phoneBox.Text;
            string fio = fioBox.Text;
            string address = addressBox.Text;
            string passport = passportBox.Text;

            if (idStaff == "" || age == "" || phone == "" || fio == "" || address == "" || passport == "")
                MessageBox.Show("Заполните все поля");
            try
            {

                MySqlCommand command = new MySqlCommand("call insert_staff(" + idStaff + ",'" + fio + "'," + age + ",'" + gender + "','" + address + "','" + phone + "','" + passport + "'," + staff + ")", db.getConnection());


                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Сотрудник успешно добавлена");
                else
                    MessageBox.Show("Ошибка  при  добавлении сотрудника");

                db.closeConnection();
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void tarifButton_Click(object sender, EventArgs e)
        {
            dataPanel.Visible = true;
            addStaff.Visible = false;
            addPanel.Visible = false;
            tariffPanel.Visible = true;
        }

        private void addTarifButton_Click(object sender, EventArgs e)
        {

            DBconnect db = new DBconnect();

            string id = idTarifBox.Text;
            string nameTarif = nameTarifBox.Text;
            string descTarif = descTarifBox.Text;
            string costTarif = costTariifBox.Text;

            if (id == "" || nameTarif == "" || descTarif == "" || costTarif == "")
                MessageBox.Show("Заполните все поля");
            try
            {

                MySqlCommand command = new MySqlCommand("call tariff_add(" + id + ",'" + nameTarif + "','" + descTarif + "'," + costTarif + ")", db.getConnection());


                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Тариф успешно добавлен");
                else
                    MessageBox.Show("Ошибка  при  добавлении тарифа");

                db.closeConnection();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }

        
}


