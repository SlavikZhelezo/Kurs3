using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kurs3
{
    public partial class EditDirecct : Form
    {
        public EditDirecct()
        {
            InitializeComponent();
            EditPanel.Visible = false;
            radioPanel.Visible = false;
            addPanel.Visible = false;
            workPanel.Visible = false;
            StaffChanged.Visible = false;
            tarifPanel.Visible = false;
        }

        DBconnect db = new DBconnect();

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
        private void showGrid() 
        {
            try
            {
                db.openConnection();
                string sql = "SELECT * FROM services";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, db.getConnection());
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGrid.DataSource = ds.Tables[0];
                db.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void deleteRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (deleteRadio.Checked == true)
            {
                EditPanel.Visible = true;
                addPanel.Visible = false;
            }

            showGrid();

        }

        private void serviceButton_Click(object sender, EventArgs e)
        {
            EditPanel.Visible = false;
            radioPanel.Visible = true;
            addStaff.Visible = false;
            addPanel.Visible = false;
            workPanel.Visible = false;
            StaffChanged.Visible = false;
            tarifPanel.Visible = false;
            dataPanel.Visible = false;
            panelForEdit.Visible = false;
            panel1.Visible = false;
            tarifAddPanel.Visible = false;
            tarifwork.Visible = false;
            panelUser.Visible = false;

        }

        private void addRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (addRadio.Checked == true)
            {
                addPanel.Visible = true;
                EditPanel.Visible = false;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DBconnect db = new DBconnect();

            string serv = delBox.Text;
            MessageBox.Show(serv);

            if (serv == "")
                MessageBox.Show("Заполните все поля");
            try
            {
                MySqlCommand command = new MySqlCommand("call delete_serv(" + serv + ")", db.getConnection());

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Услуга успешно удалена");
                    
                }
                else
                    MessageBox.Show("Ошибка  при  удалении");

                showGrid();
                db.closeConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string id = idBox.Text;
            string name = nameBox.Text;
            string desc = descripBox.Text;
            string cost = costBox.Text;

            if (id == "" || name == "" || desc == "" || cost == "")
                MessageBox.Show("Заполните все поля");

            try
            {
                MySqlCommand command = new MySqlCommand("call insert_service(" + id + ", '"+ name +"','"+ desc +"','"+ cost +"')", db.getConnection());

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Тариф успешно добавлен");

                }
                else
                    MessageBox.Show("Ошибка  при  добавлении");

                showGrid();
                db.closeConnection();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        string gender;
        string position;

        private void genderStaffCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            gender = genderStaffCombo.SelectedIndex.ToString();
            if (gender == "0")
                gender = "муж";
            else if (gender == "1")
                gender = "жен";
        }

        private void positionStaffCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            position = positionStaffCombo.SelectedIndex.ToString();
            if (position == "0")
                position = "4";
            else if (position == "1")
                position = "2";
            else if (position == "2")
                position = "7";
            else if (position == "3")
                position = "10";
            else if (position == "4")
                position = "11";
        }

        private void addStaffButton_Click(object sender, EventArgs e)
        {
            string idStaff = idStaffBox.Text;
            string age = ageStaffBox.Text;
            string phone = phoneStaffBox.Text;
            string fio = fioStaffBox.Text;
            string address = addressStaffBox.Text;
            string passport = passportStaffBox.Text;

            if (idStaff == "" || age == "" || phone == "" || fio == "" || address == "" || passport == "")
                MessageBox.Show("Заполните все поля");
            try
            {

                MySqlCommand command = new MySqlCommand("call insert_staff(" + idStaff + ",'" + fio + "'," + age + ",'" + gender + "','" + address + "','" + phone + "','" + passport + "'," + position + ")", db.getConnection());


                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Сотрудник успешно добавлен");
                else
                    MessageBox.Show("Ошибка  при  добавлении сотрудника");

                db.closeConnection();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void staffButton_Click(object sender, EventArgs e)
        {
            EditPanel.Visible = false;
            radioPanel.Visible = false;
            addPanel.Visible = false;
            workPanel.Visible = true;
            addStaff.Visible = true;
            StaffChanged.Visible = true;
            tarifPanel.Visible = false;
            dataPanel.Visible = false;
            panelForEdit.Visible = false;
            panel1.Visible = false;
            tarifAddPanel.Visible = false;
            tarifwork.Visible = false;
            panelUser.Visible = false;

        }

        string choose;

        private void chooseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            choose = chooseComboBox.SelectedIndex.ToString();
            if (choose == "0")
                choose = "staffid";
            else if (choose == "1")
                choose = "name";
            else if (choose == "2")
                choose = "age";
            else if (choose == "3")
                choose = "gender";
            else if (choose == "4")
                choose = "addres";
            else if (choose == "5")
                choose = "Phone_number";
            else if (choose == "6")
                choose = "passport";
            else if (choose == "7")
                choose = "positionid";
        }

        private void editButtom_Click(object sender, EventArgs e)
        {
            string fio = fioEditLabel.Text;
            string dataField = newValue.Text;

            if (fio == "" || dataField == "")
                MessageBox.Show("Заполните все поля");

            try
            {

                MySqlCommand command = new MySqlCommand("(UPDATE staff SET "+ choose +"='"+ dataField +"' WHERE Name ='"+ fio +"')", db.getConnection());


                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Данные успешно изменены");
                else
                    MessageBox.Show("Ошибка  при  изменении данных");

                db.closeConnection();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void StaffAdd_Click(object sender, EventArgs e)
        {
            addPanel.Visible = true;
            panelForEdit.Visible = false;
        }

        private void StaffEdit_Click(object sender, EventArgs e)
        {
            addPanel.Visible = false;
            panelForEdit.Visible = true;
            EditPanel.Visible = false;
            radioPanel.Visible = false;
            workPanel.Visible = true;
            delButton.Visible = false;
            editButtom.Visible = true;
            fioEditLabel.Visible = true;
            fioStaffEditLabel.Visible = true;
        }

        private void StaffDelete_Click(object sender, EventArgs e)
        {
            addPanel.Visible = false;
            panelForEdit.Visible = true;
            EditPanel.Visible = false;
            radioPanel.Visible = false;
            workPanel.Visible = true;
            editButtom.Visible = false;
            delButton.Visible = true;
            fioEditLabel.Visible = false;
            fioStaffEditLabel.Visible = false;
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            string fio = fioEditLabel.Text;
            string dataField = newValue.Text;


            if (dataField == "")
                MessageBox.Show("Заполните все поля");

            try
            {

                MySqlCommand command = new MySqlCommand("(DELETE FROM `staff` WHERE "+ choose +"=" + dataField + ");", db.getConnection());

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Данные успешно удалены");
                else
                    MessageBox.Show("Ошибка  при  удалении данных");

                db.closeConnection();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tarifButton_Click(object sender, EventArgs e)
        {
            dataPanel.Visible = false;
            EditPanel.Visible = false;
            addPanel.Visible = false;
            workPanel.Visible = false;
            panelForEdit.Visible = false;
            StaffChanged.Visible = false;
            tarifPanel.Visible = true;
            panel1.Visible = true;
            tarifAddPanel.Visible = false;
            tarifwork.Visible = false;
            panelUser.Visible = false;
        }

        private void tarifAddBut_Click(object sender, EventArgs e)
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            tarifAddPanel.Visible = true;
            tarifwork.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            tarifAddPanel.Visible = false;
            tarifwork.Visible = true;
            texttariffio.Visible = true;
            label6.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            tarifAddPanel.Visible = false;
            tarifwork.Visible = true;
            texttariffio.Visible = false;
            label6.Visible = false;
        }

        private void userLabel_Click(object sender, EventArgs e)
        {
            EditPanel.Visible = false;
            radioPanel.Visible = false;
            addPanel.Visible = false;
            workPanel.Visible = false;
            addStaff.Visible = false;
            StaffChanged.Visible = false;
            dataPanel.Visible = false;
            panelForEdit.Visible = false;
            panel1.Visible = false;
            tarifAddPanel.Visible = false;
            tarifwork.Visible = false;
            panelUser.Visible = true;
            panel2.Visible = true;
            tarifPanel.Visible = true;
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            DBconnect db = new DBconnect();

            string user = userText.Text;
            string password = passwordText.Text;

            if (user == "" || password == "" || posUser == "")
                MessageBox.Show("Заполните все поля");
            else if (user != "" || password != "" || posUser != "")
            {
                try
                {

                    MySqlCommand command = new MySqlCommand("call hash_password('" + user + "','" + password + "','" + posUser + "')", db.getConnection());


                    db.openConnection();

                    if (command.ExecuteNonQuery() == 1)
                        MessageBox.Show("Пользователь успешно добавлен");
                    else
                        MessageBox.Show("Ошибка  при  добавлении пользователя");

                    db.closeConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        string posUser;

        private void positionCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            posUser = positionCombo.SelectedIndex.ToString();
            if (posUser == "0")
                posUser = "Director";
            else if (posUser == "1")
                posUser = "Administrator";
            else if (posUser == "2")
                posUser = "Operator";
        }

        private void addUser_CheckedChanged(object sender, EventArgs e)
        {
            labelUser.Visible = true;
            userText.Visible = true;
            password.Visible = true; 
            passwordText.Visible = true;
            rulesLabel.Visible = true;
            positionCombo.Visible = true;
            addUserButton.Visible = true;
            editUserButton.Visible = false;
        }

        private void deleteUser_CheckedChanged(object sender, EventArgs e)
        {
            labelUser.Visible = true;
            userText.Visible = true;
            password.Visible = false;
            passwordText.Visible = false;
            rulesLabel.Visible = false;
            positionCombo.Visible = false;
            addUserButton.Visible = false;
            editUserButton.Visible = false;
        }

        private void editRules_CheckedChanged(object sender, EventArgs e)
        {
            labelUser.Visible = true;
            userText.Visible = true;
            password.Visible = false;
            passwordText.Visible = false;
            rulesLabel.Visible = true;
            positionCombo.Visible = true;
            addUserButton.Visible = false;
            editUserButton.Visible = true;
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            DBconnect db = new DBconnect();

            string user = userText.Text;

            if (user == "")
                MessageBox.Show("Заполните все поля");
            else if (user != "")
            {
                try
                {

                    MySqlCommand command = new MySqlCommand("DELETE FROM `user` WHERE id_user=" + user + ";",db.getConnection());


                    db.openConnection();

                    if (command.ExecuteNonQuery() == 1)
                        MessageBox.Show("Пользователь успешно удален");
                    else
                        MessageBox.Show("Ошибка  при  удалении пользователя");

                    db.closeConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void editUserButton_Click(object sender, EventArgs e)
        {
            DBconnect db = new DBconnect();

            string user = userText.Text;

            if (user == "" || posUser == "")
                MessageBox.Show("Заполните все поля");
            else if (user != "" || posUser != "")
            {
                try
                {

                    MySqlCommand command = new MySqlCommand("UPDATE `user` SET `comment` = '"+ posUser +"' WHERE id_user='" + user + "';", db.getConnection());
                    
                    db.openConnection();

                    if (command.ExecuteNonQuery() == 1)
                        MessageBox.Show("Права пользователя изменены");
                    else
                        MessageBox.Show("Ошибка  при  изменении прав пользователя");

                    db.closeConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}