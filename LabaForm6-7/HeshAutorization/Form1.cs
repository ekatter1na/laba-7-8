﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using SD = System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace HeshAutorization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-ASVK2VM; Initial Catalog=Laba; Integrated Security=True");
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

        public void openConnection()
        {
            if (sqlConnection.State == SD.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void closeConnection()
        {
            if (sqlConnection.State == SD.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonClick(object sender, EventArgs e)
        {
            string Login = textBox1.Text.ToString();
            string Password = textBox2.Text.ToString();

            openConnection();

            if(Proverka(Login, Password) == true)
            {
                MessageBox.Show("Авторизация успешна", "Выполнено");
            }
            else
            {
                MessageBox.Show("Выввели неверный логин или пароль", "Ошибка");
            }
            closeConnection();
        }

        private void buttonRegClick(object sender, EventArgs e)
        {
            string LoginReg = textBox3.Text.ToString();
            string PasswordReg1 = textBox4.Text.ToString();
            string PasswordReg2 = textBox5.Text.ToString();
            string Name = textBox8.Text.ToString();
            string lastName = textBox7.Text.ToString();
            string post = textBox6.Text.ToString();

            if (PasswordReg1 == PasswordReg2)
            {
                    openConnection();

                    if (Proverka(LoginReg, PasswordReg1) == true)
                    {
                        MessageBox.Show("Такой аккаун уже есть", "Ошибка");
                    }
                    else if (Proverka(LoginReg, PasswordReg1) == false)
                    {

                        PasswordReg1 = CreateMD5(PasswordReg1); 

                        string commandString = $"insert into tabl (логин, пароль, имя, фамилия, должность) values('{LoginReg}', '{PasswordReg1}', '{Name}', '{lastName}', '{post}')";
                        
                        SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
                    try
                    {
                        if (sqlCommand.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Аккаунт был создан", "Выполнено");

                        }
                        else
                        {
                            MessageBox.Show("Аккаунт не создан", "Ошибка");
                        }
                    }
                    catch (Exception ex) { 
                        MessageBox.Show(ex.Message, "Выполнено");
                    }
                    }
                
                
            }
            else
            {
                MessageBox.Show("Пароли не совпадают", "Ошибка");
            }

            closeConnection();
        }

        private Boolean Proverka(string log, string pass)
        {
            DataTable table = new DataTable();
            string Login = log;
            string Password = pass;

            Password = CreateMD5(Password);

            string commandString = $"select логин, пароль from tabl where логин='{Login}' and пароль='{Password}'";

            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(table);

            if(table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string CreateMD5(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new System.Text.StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        
    }
}
