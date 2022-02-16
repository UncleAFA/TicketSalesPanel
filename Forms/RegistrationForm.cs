﻿using System;
using System.Data.OleDb;

using System.Windows.Forms;

namespace TicketSalesPanel.Forms
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private Pass NewPass = new Pass();

        // строка подключения к MS Access
        // вариант 1
        private string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=итог.mdb;";
        // вариант 2
        //public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=итог.mdb;";

        //переменные для формирования номера билета
        private string LettersPass = "AAR";

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Passenger NewPassenger = new Passenger();
            NewPassenger.Name = NameTextBox.Text;
            NewPassenger.Surname = SurnameTextBox.Text;
            NewPassenger.MiddleName = MiddleNameTextBox.Text;
            NewPassenger.PassportSeriesNumber = PassportSeriesTextBox.Text + PassportNumberTextBox.Text;
            NewPassenger.Address = ResidentialAddressTextBox.Text;
            NewPassenger.PhoneNumber = PhoneNumberTextBox.Text;
            bool check = CheckingAvailableSeats(TypeOfSalonComboBox.SelectedItem.ToString(), FlightNumberСomboBox.SelectedItem.ToString());
            NewPass.TypeOfSalon = TypeOfSalonComboBox.SelectedItem.ToString();
            if (!check)
            {
                DialogResult result = MessageBox.Show("Предложите пассажиру поменять тип салона! (да - если он согласне, нет - если он отказался)","Места в этой категории заняты", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    MessageBox.Show("Следующий полет состоится через три часа");
                    this.Close();
                }
            }
            if (check)
            {
                RegistrationPassenger(NewPassenger, FlightNumberСomboBox.SelectedItem.ToString());
                RegistratioPass(FlightNumberСomboBox.SelectedItem.ToString());
                this.Close();
                TicketDisplay ticketDisplay = new TicketDisplay(NewPass);
                ticketDisplay.Show();

            }
            
            //MessageBox.Show(SelectedTypeOfSalon);
        }
        //регистрация билета в бд
        private void RegistratioPass(string FlightNumber)
        {
            // поле - ссылка на экземпляр класса OleDbConnection для соединения с БД
            OleDbConnection myConnection;
            // создаем экземпляр класса OleDbConnection
            myConnection = new OleDbConnection(connectString);

            // открываем соединение с БД
            myConnection.Open();

            // текст запроса
            string query = $"SELECT Кол_во_свободных_мест, Цена_билета FROM Места WHERE №рейса = '{FlightNumber}'";
            // создаем объект OleDbCommand для выполнения запроса к БД MS Access
            OleDbCommand command = new OleDbCommand(query, myConnection);
            // получаем объект OleDbDataReader для чтения табличного результата запроса SELECT
            OleDbDataReader reader = command.ExecuteReader();

            
            int FreeSeats = -1;//Переменна для количество свободных мест на рейс
            while (reader.Read())
            {
                FreeSeats = Convert.ToInt32(reader[0].ToString());
                NewPass.Coast = Convert.ToInt32(reader[1].ToString());
            }

            myConnection.Close();
            RegistrationSeat(FlightNumber, FreeSeats);

        }
        private void RegistrationSeat(string FlightNumber, int FreeSeats)
        {
            int[] SeatsArr = new int[10];
            int ThisNumSeat = -1;
            int LastNumPassInDB = 0;




            // поле - ссылка на экземпляр класса OleDbConnection для соединения с БД
            OleDbConnection myConnection;
            // создаем экземпляр класса OleDbConnection
            myConnection = new OleDbConnection(connectString);





            // открываем соединение с БД
            myConnection.Open();
            // текст запроса
            string query = $"SELECT Номер_места FROM Билет WHERE №рейса = '{FlightNumber}'";
            // создаем объект OleDbCommand для выполнения запроса к БД MS Access
            OleDbCommand command = new OleDbCommand(query, myConnection);
            // получаем объект OleDbDataReader для чтения табличного результата запроса SELECT
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                SeatsArr[Convert.ToInt32(reader[0].ToString()) - 1] = 1;
            }
            myConnection.Close();




            if (TypeOfSalonComboBox.SelectedItem.ToString() == "1)Для курящих")
            {
                for (int i = SeatsArr.Length/2; i < SeatsArr.Length; i++)
                {
                    if (SeatsArr[i] == 0)
                    {
                        ThisNumSeat = i+1;
                        break;
                    }                        
                }
            }
            if (TypeOfSalonComboBox.SelectedItem.ToString() == "2)Для не курящих")
            {
                for (int i = 0; i <= 4; i++)
                {
                    if (SeatsArr[i] == 0)
                    {
                        ThisNumSeat = i+1;
                        break;
                    }  
                }
            }
            NewPass.NumSeat = ThisNumSeat;




            // открываем соединение с БД
            myConnection.Open();
            // текст запроса
            string query2 = $"SELECT №Билета FROM Билет ORDER BY №Билета";
            // создаем объект OleDbCommand для выполнения запроса к БД MS Access
            OleDbCommand command2 = new OleDbCommand(query2, myConnection);
            // получаем объект OleDbDataReader для чтения табличного результата запроса SELECT
            OleDbDataReader reader2 = command2.ExecuteReader();            
            while (reader2.Read())
            {
                LastNumPassInDB = Convert.ToInt32(reader2[0].ToString());
            }
            NewPass.NumPass = LastNumPassInDB + 1;
            myConnection.Close();






            // открываем соединение с БД
            myConnection.Open();
            // текст запроса
            string query3 = $"UPDATE Места SET Кол_во_свободных_мест = Кол_во_свободных_мест-1 WHERE №рейса = '{FlightNumber}'";
            // создаем объект OleDbCommand для выполнения запроса к БД MS Access
            OleDbCommand command3 = new OleDbCommand(query3, myConnection);
            // выполняем запрос к MS Access
            command3.ExecuteNonQuery();           
            myConnection.Close();


            // открываем соединение с БД
            myConnection.Open();
            // текст запроса
            string query4 = $"INSERT INTO Билет (№Билета, №рейса, Цена_билета, Номер_места) VALUES ({NewPass.NumPass}, '{FlightNumber}', {NewPass.Coast}, {NewPass.NumSeat})";
            // создаем объект OleDbCommand для выполнения запроса к БД MS Access
            OleDbCommand command4 = new OleDbCommand(query4, myConnection);
            // выполняем запрос к MS Access
            command4.ExecuteNonQuery();
            myConnection.Close();
        }
        //Запрос в Бд для внесение данных нового пользователя(таблица пассажиры)
        private void RegistrationPassenger(Passenger NewPassenger, string FlightNumber)
        {
            // поле - ссылка на экземпляр класса OleDbConnection для соединения с БД
            OleDbConnection myConnection;
            // создаем экземпляр класса OleDbConnection
            myConnection = new OleDbConnection(connectString);
            // открываем соединение с БД
            myConnection.Open();

            string NumPass = CreateNumPass();
            // текст запроса
            //string query = $"INSERT INTO Пассажиры (№Билета, Серия№Паспорта, ФИО, Адрес, Телефон_сот, №рейса) VALUES ('{NumPass}',{NewPassenger.PassportSeriesNumber}, '{NewPassenger.Name}', '{NewPassenger.Address}', {NewPassenger.PhoneNumber}, '{FlightNumber}')";
            string query = $"INSERT INTO Пассажиры (№Билета, Серия№Паспорта, ФИО, Адрес, Телефон_сот, №рейса) VALUES ('{NumPass}',{NewPassenger.PassportSeriesNumber}, '{NewPassenger.Surname + " " + NewPassenger.Name + " " + NewPassenger.MiddleName}', '{NewPassenger.Address}', {NewPassenger.PhoneNumber}, '{FlightNumber}')";

            // создаем объект OleDbCommand для выполнения запроса к БД MS Access
            OleDbCommand command = new OleDbCommand(query, myConnection);

            // выполняем запрос к MS Access
            command.ExecuteNonQuery();

            //// заркываем соединение с БД
            myConnection.Close();
        }
        private string CreateNumPass()
        {
            int NumPass = 0;
            // поле - ссылка на экземпляр класса OleDbConnection для соединения с БД
            OleDbConnection myConnection;
            // создаем экземпляр класса OleDbConnection
            myConnection = new OleDbConnection(connectString);

            // открываем соединение с БД
            myConnection.Open();

            // текст запроса
            string query = $"SELECT №Билета FROM Пассажиры ORDER BY №Билета";
            // создаем объект OleDbCommand для выполнения запроса к БД MS Access
            OleDbCommand command = new OleDbCommand(query, myConnection);
            // получаем объект OleDbDataReader для чтения табличного результата запроса SELECT
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string SNum = reader[0].ToString().Remove(0,3);
                NumPass = Convert.ToInt32(SNum);
                break;
            }

            myConnection.Close();
            return $"{LettersPass}{NumPass-1}";
        }
        //ФУНКЦИЯ ДЛЯ ПРОВЕРКИ СВОБОДНЫХ МЕСТ ПО ВВЕДЕННОЙ КОТЕГОРИИ
        private bool CheckingAvailableSeats(string SelectedTypeOfSalon, string FlightNumber)
        {
            int[] SeatsArr = FindBusySeats(FlightNumber);

            if (SelectedTypeOfSalon == "1)Для курящих")
            {
                for (int i = 5; i < SeatsArr.Length; i++)
                {
                    if (SeatsArr[i] == 0)
                        return true;
                }
            }
            if (SelectedTypeOfSalon == "2)Для не курящих")
            {
                for (int i = 0; i <= 4; i++)
                {
                    if (SeatsArr[i] == 0)
                        return true;
                }
            }
            
            return false;
        }

        //Получение информации о занятых местах из бд
        private int[] FindBusySeats(string FlightNumber)
        {
            // поле - ссылка на экземпляр класса OleDbConnection для соединения с БД
            OleDbConnection myConnection;
            // создаем экземпляр класса OleDbConnection
            myConnection = new OleDbConnection(connectString);

            // открываем соединение с БД
            myConnection.Open();

            // текст запроса
            string query = $"SELECT Номер_места FROM Билет WHERE №рейса = '{FlightNumber}'";
            // создаем объект OleDbCommand для выполнения запроса к БД MS Access
            OleDbCommand command = new OleDbCommand(query, myConnection);
            // получаем объект OleDbDataReader для чтения табличного результата запроса SELECT
            OleDbDataReader reader = command.ExecuteReader();

            int[] SeatsArr = new int[10];
            while (reader.Read())
            {
                SeatsArr[Convert.ToInt32(reader[0].ToString())-1] = 1;
            }

            myConnection.Close();
            return SeatsArr;
        }
    }
}
