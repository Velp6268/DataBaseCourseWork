﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }



        DataBase dataBase = new DataBase();
     


        private void button1_Click_1(object sender, EventArgs e)
        {
            var login = textBox1.Text;
            var password = textBox2.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string queryString = $"select login, password from register where login = '{login}' and password = '{password}'"; //переменная для выбора данных

            SqlCommand sqlCommand = new SqlCommand(queryString, dataBase.getConnection()); // Берет по строчке и подключает..

            adapter.SelectCommand = sqlCommand; // подключает
            adapter.Fill(table); //заполняет таблицу



            //111111111111111111111111111111111111111111111111111111111111111111111111111111111111111

            //if (table.Rows.Count == 1) //Открытие формы, и пров1ерка данных
            //{
            //    MessageBox.Show("Вы вошли успешно");
            //    Form1 form1 = new Form1();
            //    this.Hide();
            //    form1.ShowDialog();
            //    this.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Ошибка");
            //}


            //2222222222222222222222222222222222222222222222222222222222222222222222222222222222222222


            //if (table.Rows.Count == 1) //Открытие формы, и проверка данных
            //{
            //    MessageBox.Show("Вы вошли успешно");
            //    DataBaseCar form2 = new DataBaseCar();
            //    this.Hide();
            //    form2.ShowDialog();
            //    this.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Ошибка");
            //}


            //33333333333333333333333333333333333333333333333333333333333333333333333333333333333333333


            //if (table.Rows.Count == 1) //Открытие формы, и проверка данных
            //{
            //    MessageBox.Show("Вы вошли успешно");
            //    ApplicationSupplier form3 = new ApplicationSupplier();
            //    this.Hide();
            //    form3.ShowDialog();
            //    this.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Ошибка");
            //}



            //if (table.Rows.Count == 1) //Открытие формы, и проверка данных
            //{
            //    MessageBox.Show("Вы вошли успешно");
            //    RequestCarSupplier form4 = new RequestCarSupplier();
            //    this.Hide();
            //    form4.ShowDialog();
            //    this.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Ошибка");
            //}

            if (table.Rows.Count == 1) //Открытие формы, и проверка данных
            {
                MessageBox.Show("Вы вошли успешно");
                Form2 form5 = new Form2();
                this.Hide();
                form5.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Ошибка");
            }



        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registeration RegistrForm = new Registeration();
            this.Hide();
            RegistrForm.ShowDialog();
            this.Show();

        }



        private void Authorization_Load(object sender, EventArgs e)
        {
            pictureBox2.Visible= true;
            textBox2.UseSystemPasswordChar = true;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
            pictureBox2.Visible = false;
            pictureBox1.Visible = true;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
            pictureBox2.Visible = true;
            pictureBox1.Visible = false;
        }


    }

}

