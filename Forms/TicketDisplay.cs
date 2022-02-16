using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketSalesPanel
{
    public partial class TicketDisplay : Form
    {
        private Pass PassInfoForView;
        private readonly string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=итог.mdb;";

        public TicketDisplay(Pass NewPass)
        {
            PassInfoForView = NewPass;
            InitializeComponent();
            FIOLabel.Text = PassInfoForView.PassengerFIO;
            FlightNumberLabel.Text = PassInfoForView.FlightNumber;
            NumPassLabel.Text = PassInfoForView.NumPass.ToString();
            NumSaetLabel.Text = PassInfoForView.NumSeat.ToString();
            TypeSeatLabel.Text = PassInfoForView.TypeOfSalon.Remove(0,2);
            PassportNumSeriesLabel.Text = PassInfoForView.Document;
            ShearInfo();

        }
        private void ShearInfo()
        {
            // поле - ссылка на экземпляр класса OleDbConnection для соединения с БД
            OleDbConnection myConnection;
            // создаем экземпляр класса OleDbConnection
            myConnection = new OleDbConnection(connectString);


            // открываем соединение с БД
            myConnection.Open();
            // текст запроса
            string query = $"SELECT *FROM Рейсы WHERE №рейса = '{PassInfoForView.FlightNumber}'";
            // создаем объект OleDbCommand для выполнения запроса к БД MS Access
            OleDbCommand command = new OleDbCommand(query, myConnection);
            // получаем объект OleDbDataReader для чтения табличного результата запроса SELECT
            OleDbDataReader reader = command.ExecuteReader();
            string[] Info = new string[9];
            while (reader.Read())
            {
                for (int i = 0; i < 9; i++)
                {
                    Info[i] = reader[i].ToString();
                }
            }
            FromLabel.Text = Info[1];
            ToLabel.Text = Info[4] +" "+ Info[5];
            DepartDateLabel.Text = Info[2].Remove(9,11);
            DepartTimeLabel.Text = Info[3].Remove(0, 10);
            myConnection.Close();


            // открываем соединение с БД
            myConnection.Open();
            // текст запроса
            string query2 = $"SELECT Авиакомпания FROM Самолет WHERE Борт№ = '{Info[8]}'";
            // создаем объект OleDbCommand для выполнения запроса к БД MS Access
            OleDbCommand command2 = new OleDbCommand(query2, myConnection);
            // получаем объект OleDbDataReader для чтения табличного результата запроса SELECT
            OleDbDataReader reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                    AirlineNameLabel.Text = reader2[0].ToString();
            }
            myConnection.Close();

        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
