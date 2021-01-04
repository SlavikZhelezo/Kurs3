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
    public partial class EditAdmin : Form
    {

        string change = "";
        public EditAdmin()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)//Скрываем панель изменений и открываем панель добавления новой услуги
            {
                addPanel.Visible = true;
                EditPanel.Visible = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)//Скрываем панель добавления новой услуги и открываем панель изменений  
            {
                addPanel.Visible = false;
                EditPanel.Visible = true;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                try 
                {
                    string cost = costBox.Text;
                    string id = idBox.Text;
                    string desc = descripBox.Text;
                    string name = nameBox.Text;

                    string str = "INSERT INTO cab_company.services (`idServices`, `Name`, `Description`, `Cost`) VALUES (" + id + ", " + name + "," + desc + ", " + cost + ");";

                } 
                
                catch
                {
                    MessageBox.Show("Заполните все поля!");
                }
            }
            else if (radioButton2.Checked)
            {
                string str = "UPDATE cab_company.services  set" + idServiceEditCheck + " where;";
            }
        }
    }
}

