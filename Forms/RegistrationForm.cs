using System;
using System.Data.OleDb;

using System.Windows.Forms;

namespace TicketSalesPanel.Forms
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
            FlightNumberСomboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }
        void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FlightNumber = FlightNumberСomboBox.SelectedItem.ToString();
            //MessageBox.Show(FlightNumber);

            // поле - ссылка на экземпляр класса OleDbConnection для соединения с БД
            OleDbConnection myConnection;
            // создаем экземпляр класса OleDbConnection
            myConnection = new OleDbConnection(connectString);


            // открываем соединение с БД
            myConnection.Open();
            // текст запроса
            string query = $"SELECT Аэропорт_отправления,Город_прибытия,Место_прибытия FROM Рейсы WHERE №рейса = '{FlightNumber}'";
            // создаем объект OleDbCommand для выполнения запроса к БД MS Access
            OleDbCommand command = new OleDbCommand(query, myConnection);
            // получаем объект OleDbDataReader для чтения табличного результата запроса SELECT
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                FromLabel.Text = "Откуда: \n" + reader[0].ToString();
                ToLabel.Text = $"Куда: \n{reader[1].ToString()}({reader[2].ToString()})";
                
            }
            myConnection.Close();
        }

        private Pass NewPass = new Pass();

        // строка подключения к MS Access
        // вариант 1
        private readonly string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=итог.mdb;";
        // вариант 2
        //public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=итог.mdb;";

        //переменные для формирования номера билета
        private readonly string LettersPass = "AAR";

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool CheckCorrectInput()
        {
            if (NameTextBox.Text == "")
            {
                MessageBox.Show("Проверьте имя.");
                return true;
            }
            if (SurnameTextBox.Text == "")
            {
                MessageBox.Show("Проверьте фамилию.");
                return true;
            }
            if (MiddleNameTextBox.Text == "")
            {
                MessageBox.Show("Проверьте отчество.");
                return true;
            }
            if (PassportSeriesTextBox.Text == "" | PassportSeriesTextBox.Text.Length != 4)
            {
                MessageBox.Show("Проверьте серию паспорта.");
                return true;
            }
            if (PassportNumberTextBox.Text == "" | PassportNumberTextBox.Text.Length != 5)
            {
                MessageBox.Show("Проверьте Номер паспорта.");
                return true;
            }
            if (ResidentialAddressTextBox.Text == "")
            {
                MessageBox.Show("Проверьте адрес.");
                return true;
            }
            if (PhoneNumberTextBox.Text == "" | PhoneNumberTextBox.Text.Length != 9)
            {
                MessageBox.Show("Проверьте Номер телефона.");
                return true;
            }
            if (FlightNumberСomboBox.SelectedItem == null)
            {
                MessageBox.Show("Проверьте Номер рейса.");
                return true;
            }
            if (TypeOfSalonComboBox.SelectedItem == null)
            {
                MessageBox.Show("Проверьте тип салона.");
                return true;
            }
            return false;
        }
        private void NextButton_Click(object sender, EventArgs e)
        {
            if (CheckCorrectInput())
            {
                return;
            }
                
            
            Passenger NewPassenger = new Passenger
            {
                Name = NameTextBox.Text,
                Surname = SurnameTextBox.Text,
                MiddleName = MiddleNameTextBox.Text,
                PassportSeriesNumber = PassportSeriesTextBox.Text + PassportNumberTextBox.Text,
                Address = ResidentialAddressTextBox.Text,
                PhoneNumber = PhoneNumberTextBox.Text
            };
            bool check = CheckingAvailableSeats(TypeOfSalonComboBox.SelectedItem.ToString(), FlightNumberСomboBox.SelectedItem.ToString());
            NewPass.TypeOfSalon = TypeOfSalonComboBox.SelectedItem.ToString();
            NewPass.FlightNumber = FlightNumberСomboBox.SelectedItem.ToString();
            NewPass.PassengerFIO = NewPassenger.Name + NewPassenger.Surname + NewPassenger.MiddleName;
            NewPass.Document = NewPassenger.PassportSeriesNumber;
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
            string query = $"SELECT Цена_билета FROM Места WHERE №рейса = '{FlightNumber}'";
            // создаем объект OleDbCommand для выполнения запроса к БД MS Access
            OleDbCommand command = new OleDbCommand(query, myConnection);
            // получаем объект OleDbDataReader для чтения табличного результата запроса SELECT
            OleDbDataReader reader = command.ExecuteReader();

            
            while (reader.Read())
            {
                NewPass.Coast = Convert.ToInt32(reader[0].ToString());
            }

            myConnection.Close();
            RegistrationSeat(FlightNumber);

        }
        private void RegistrationSeat(string FlightNumber)
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

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Информация по заполнению формы: \n\nПоле Имя не может быть пустым \n\nПоле Фамилия не может быть пустым \n\nПоле Отчество не может быть пустым \n\nПоле Серия не может быть пустым и иметь меньше 4 чисел \n\nПоле Номер Паспорта не может быть пустым и иметь меньше 5 чисел \n\nПоле Адрес не может быть пустым \n\nПоле Номер телефона не может быть пустым и иметь меньше 9 чисел");
        }
    }
}
