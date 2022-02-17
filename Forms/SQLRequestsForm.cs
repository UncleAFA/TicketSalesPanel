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
    public partial class SQLRequestsForm : Form
    {
        public SQLRequestsForm()
        {
            InitializeComponent();
        }

        private readonly string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=итог.mdb;";
        
        
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SQLButton1_Click(object sender, EventArgs e)
        {
            InfoDataGridView.Rows.Clear();
            InfoDataGridView.Columns.Clear();

            label1.Text = "Описание: \nВыводит информацию о местах (где больше 8) на самолёте, отправленном в рейс после 19.06.21";

            var column1 = new DataGridViewColumn();
            column1.HeaderText = "№рейса"; //текст в шапке
            column1.ReadOnly = true; //значение в этой колонке нельзя править
            column1.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки

            var column2 = new DataGridViewColumn();
            column2.HeaderText = "Дата_отправления";
            column2.ReadOnly = true; //значение в этой колонке нельзя править
            column2.CellTemplate = new DataGridViewTextBoxCell();

            var column3 = new DataGridViewColumn();
            column3.HeaderText = "Кол_во_свободных_мест";
            column3.ReadOnly = true; //значение в этой колонке нельзя править
            column3.CellTemplate = new DataGridViewTextBoxCell();

            var column4 = new DataGridViewColumn();
            column4.HeaderText = "Цена_билета";
            column4.ReadOnly = true; //значение в этой колонке нельзя править
            column4.CellTemplate = new DataGridViewTextBoxCell();

            var column5 = new DataGridViewColumn();
            column5.HeaderText = "Цена_билета";
            column5.ReadOnly = true; //значение в этой колонке нельзя править
            column5.CellTemplate = new DataGridViewTextBoxCell();


            InfoDataGridView.Columns.Add(column1);
            InfoDataGridView.Columns.Add(column2);
            InfoDataGridView.Columns.Add(column3);
            InfoDataGridView.Columns.Add(column4);
            InfoDataGridView.Columns.Add(column5);

            // поле - ссылка на экземпляр класса OleDbConnection для соединения с БД
            OleDbConnection myConnection;
            // создаем экземпляр класса OleDbConnection
            myConnection = new OleDbConnection(connectString);
            // открываем соединение с БД
            myConnection.Open();
            // текст запроса
            string query = "SELECT Места.*, Самолет.Модель FROM Самолет INNER JOIN(Аэропорт INNER JOIN (Рейсы INNER JOIN ((Билет INNER JOIN Места ON Билет.[№рейса] = Места.[№рейса]) INNER JOIN Пассажиры ON Места.[№рейса] = Пассажиры.[№рейса]) ON(Рейсы.[№рейса] = Места.[№рейса]) AND(Рейсы.[№рейса] = Пассажиры.[№рейса]) AND(Билет.[№рейса] = Рейсы.[№рейса])) ON Аэропорт.Назв_аэропорта = Рейсы.Аэропорт_отправления) ON Самолет.Борт№ = Рейсы.Борт№ WHERE(((Места.Дата_отправления) >=#6/19/2021#) AND ((Места.Кол_во_свободных_мест)>8));";
            // создаем объект OleDbCommand для выполнения запроса к БД MS Access
            OleDbCommand command = new OleDbCommand(query, myConnection);
            // получаем объект OleDbDataReader для чтения табличного результата запроса SELECT
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                InfoDataGridView.Rows.Add();
                InfoDataGridView[0, InfoDataGridView.Rows.Count - 1].Value = reader[0].ToString();
                InfoDataGridView[1, InfoDataGridView.Rows.Count - 1].Value = reader[1].ToString();
                InfoDataGridView[2, InfoDataGridView.Rows.Count - 1].Value = reader[2].ToString();
                InfoDataGridView[3, InfoDataGridView.Rows.Count - 1].Value = reader[3].ToString();
                InfoDataGridView[4, InfoDataGridView.Rows.Count - 1].Value = reader[4].ToString();
            }
            myConnection.Close();
        }

        private void SQLButton2_Click(object sender, EventArgs e)
        {
            InfoDataGridView.Rows.Clear();
            InfoDataGridView.Columns.Clear();

            label1.Text = "Описание: \nВыводит информацию о российских аэропортах, где есть детская комната (+ рейсы с этого аэропорта после 18.06.21)";

            var column1 = new DataGridViewColumn();
            column1.HeaderText = "Назв_аэропорта"; //текст в шапке
            column1.ReadOnly = true; //значение в этой колонке нельзя править
            column1.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки

            var column2 = new DataGridViewColumn();
            column2.HeaderText = "Город";
            column2.ReadOnly = true; //значение в этой колонке нельзя править
            column2.CellTemplate = new DataGridViewTextBoxCell();

            var column3 = new DataGridViewColumn();
            column3.HeaderText = "Страна";
            column3.ReadOnly = true; //значение в этой колонке нельзя править
            column3.CellTemplate = new DataGridViewTextBoxCell();

            var column4 = new DataGridViewColumn();
            column4.HeaderText = "Телефон";
            column4.ReadOnly = true; //значение в этой колонке нельзя править
            column4.CellTemplate = new DataGridViewTextBoxCell();

            var column5 = new DataGridViewColumn();
            column5.HeaderText = "Налич_детс_комнат";
            column5.ReadOnly = true; //значение в этой колонке нельзя править
            column5.CellTemplate = new DataGridViewTextBoxCell();

            var column6 = new DataGridViewColumn();
            column6.HeaderText = "№рейса";
            column6.ReadOnly = true; //значение в этой колонке нельзя править
            column6.CellTemplate = new DataGridViewTextBoxCell();

            var column7 = new DataGridViewColumn();
            column7.HeaderText = "Дата_отправления";
            column7.ReadOnly = true; //значение в этой колонке нельзя править
            column7.CellTemplate = new DataGridViewTextBoxCell();


            InfoDataGridView.Columns.Add(column1);
            InfoDataGridView.Columns.Add(column2);
            InfoDataGridView.Columns.Add(column3);
            InfoDataGridView.Columns.Add(column4);
            InfoDataGridView.Columns.Add(column5);
            InfoDataGridView.Columns.Add(column6);
            InfoDataGridView.Columns.Add(column7);

            // поле - ссылка на экземпляр класса OleDbConnection для соединения с БД
            OleDbConnection myConnection;
            // создаем экземпляр класса OleDbConnection
            myConnection = new OleDbConnection(connectString);
            // открываем соединение с БД
            myConnection.Open();
            // текст запроса
            string query = "SELECT Аэропорт.Назв_аэропорта, Аэропорт.Город, Аэропорт.Страна, Аэропорт.Телефон, Аэропорт.Наличие_детс_комнат, Рейсы.[№рейса], Рейсы.Дата_отправления FROM Аэропорт INNER JOIN Рейсы ON Аэропорт.Назв_аэропорта = Рейсы.Аэропорт_отправления WHERE(((Аэропорт.Страна) = 'Россия') AND((Аэропорт.Наличие_детс_комнат) = 'есть') AND((Рейсы.Дата_отправления) >=#6/18/2021#));";
            // создаем объект OleDbCommand для выполнения запроса к БД MS Access
            OleDbCommand command = new OleDbCommand(query, myConnection);
            // получаем объект OleDbDataReader для чтения табличного результата запроса SELECT
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                InfoDataGridView.Rows.Add();
                InfoDataGridView[0, InfoDataGridView.Rows.Count - 1].Value = reader[0].ToString();
                InfoDataGridView[1, InfoDataGridView.Rows.Count - 1].Value = reader[1].ToString();
                InfoDataGridView[2, InfoDataGridView.Rows.Count - 1].Value = reader[2].ToString();
                InfoDataGridView[3, InfoDataGridView.Rows.Count - 1].Value = reader[3].ToString();
                InfoDataGridView[4, InfoDataGridView.Rows.Count - 1].Value = reader[4].ToString();
                InfoDataGridView[5, InfoDataGridView.Rows.Count - 1].Value = reader[5].ToString();
                InfoDataGridView[6, InfoDataGridView.Rows.Count - 1].Value = reader[6].ToString();
            }
            myConnection.Close();
        }

        private void SQLButton3_Click(object sender, EventArgs e)
        {
            InfoDataGridView.Rows.Clear();
            InfoDataGridView.Columns.Clear();

            label1.Text = "Описание: \nВыводит информацию о рейсе и билете, стоимость которого меньше 13000";

            var column1 = new DataGridViewColumn();
            column1.HeaderText = "№Билета"; //текст в шапке
            column1.ReadOnly = true; //значение в этой колонке нельзя править
            column1.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки

            var column2 = new DataGridViewColumn();
            column2.HeaderText = "№рейса";
            column2.ReadOnly = true; //значение в этой колонке нельзя править
            column2.CellTemplate = new DataGridViewTextBoxCell();

            var column3 = new DataGridViewColumn();
            column3.HeaderText = "Цена_билета";
            column3.ReadOnly = true; //значение в этой колонке нельзя править
            column3.CellTemplate = new DataGridViewTextBoxCell();

            var column4 = new DataGridViewColumn();
            column4.HeaderText = "Номер_места";
            column4.ReadOnly = true; //значение в этой колонке нельзя править
            column4.CellTemplate = new DataGridViewTextBoxCell();

            var column5 = new DataGridViewColumn();
            column5.HeaderText = "Дата_Отправления";
            column5.ReadOnly = true; //значение в этой колонке нельзя править
            column5.CellTemplate = new DataGridViewTextBoxCell();

            var column6 = new DataGridViewColumn();
            column6.HeaderText = "Назв_аэропорта";
            column6.ReadOnly = true; //значение в этой колонке нельзя править
            column6.CellTemplate = new DataGridViewTextBoxCell();



            InfoDataGridView.Columns.Add(column1);
            InfoDataGridView.Columns.Add(column2);
            InfoDataGridView.Columns.Add(column3);
            InfoDataGridView.Columns.Add(column4);
            InfoDataGridView.Columns.Add(column5);
            InfoDataGridView.Columns.Add(column6);
            // поле - ссылка на экземпляр класса OleDbConnection для соединения с БД
            OleDbConnection myConnection;
            // создаем экземпляр класса OleDbConnection
            myConnection = new OleDbConnection(connectString);
            // открываем соединение с БД
            myConnection.Open();
            // текст запроса
            string query = "SELECT Билет.*, Рейсы.Дата_отправления, Аэропорт.Назв_аэропорта FROM Аэропорт INNER JOIN(Рейсы INNER JOIN Билет ON Рейсы.[№рейса] = Билет.[№рейса]) ON Аэропорт.Назв_аэропорта = Рейсы.Аэропорт_отправления WHERE(((Билет.Цена_билета) < 13000)); ";
            // создаем объект OleDbCommand для выполнения запроса к БД MS Access
            OleDbCommand command = new OleDbCommand(query, myConnection);
            // получаем объект OleDbDataReader для чтения табличного результата запроса SELECT
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                InfoDataGridView.Rows.Add();
                InfoDataGridView[0, InfoDataGridView.Rows.Count - 1].Value = reader[0].ToString();
                InfoDataGridView[1, InfoDataGridView.Rows.Count - 1].Value = reader[1].ToString();
                InfoDataGridView[2, InfoDataGridView.Rows.Count - 1].Value = reader[2].ToString();
                InfoDataGridView[3, InfoDataGridView.Rows.Count - 1].Value = reader[3].ToString();
                InfoDataGridView[4, InfoDataGridView.Rows.Count - 1].Value = reader[4].ToString();
                InfoDataGridView[5, InfoDataGridView.Rows.Count - 1].Value = reader[5].ToString();
            }
            myConnection.Close();
        }

        private void SQLButton4_Click(object sender, EventArgs e)
        {
            InfoDataGridView.Rows.Clear();
            InfoDataGridView.Columns.Clear();

            label1.Text = "Описание: \nВыводит информацию о самолёте старше 2000-го года, направляющийся в Москву";

            var column1 = new DataGridViewColumn();
            column1.HeaderText = "Борт№"; //текст в шапке
            column1.ReadOnly = true; //значение в этой колонке нельзя править
            column1.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки

            var column2 = new DataGridViewColumn();
            column2.HeaderText = "Модель";
            column2.ReadOnly = true; //значение в этой колонке нельзя править
            column2.CellTemplate = new DataGridViewTextBoxCell();

            var column3 = new DataGridViewColumn();
            column3.HeaderText = "Авиакомпания";
            column3.ReadOnly = true; //значение в этой колонке нельзя править
            column3.CellTemplate = new DataGridViewTextBoxCell();

            var column4 = new DataGridViewColumn();
            column4.HeaderText = "Вместимость";
            column4.ReadOnly = true; //значение в этой колонке нельзя править
            column4.CellTemplate = new DataGridViewTextBoxCell();

            var column5 = new DataGridViewColumn();
            column5.HeaderText = "Год_выпуска";
            column5.ReadOnly = true; //значение в этой колонке нельзя править
            column5.CellTemplate = new DataGridViewTextBoxCell();

            var column6 = new DataGridViewColumn();
            column6.HeaderText = "№рейса";
            column6.ReadOnly = true; //значение в этой колонке нельзя править
            column6.CellTemplate = new DataGridViewTextBoxCell();

            var column7 = new DataGridViewColumn();
            column7.HeaderText = "Аэропорт_отправления";
            column7.ReadOnly = true; //значение в этой колонке нельзя править
            column7.CellTemplate = new DataGridViewTextBoxCell();

            var column8 = new DataGridViewColumn();
            column8.HeaderText = "Город_прибытия";
            column8.ReadOnly = true; //значение в этой колонке нельзя править
            column8.CellTemplate = new DataGridViewTextBoxCell();

            InfoDataGridView.Columns.Add(column1);
            InfoDataGridView.Columns.Add(column2);
            InfoDataGridView.Columns.Add(column3);
            InfoDataGridView.Columns.Add(column4);
            InfoDataGridView.Columns.Add(column5);
            InfoDataGridView.Columns.Add(column6);
            InfoDataGridView.Columns.Add(column7);
            InfoDataGridView.Columns.Add(column8);
            // поле - ссылка на экземпляр класса OleDbConnection для соединения с БД
            OleDbConnection myConnection;
            // создаем экземпляр класса OleDbConnection
            myConnection = new OleDbConnection(connectString);
            // открываем соединение с БД
            myConnection.Open();
            // текст запроса
            string query = "SELECT Самолет.*, Рейсы.[№рейса], Рейсы.Аэропорт_отправления, Рейсы.Город_прибытия FROM Самолет INNER JOIN Рейсы ON Самолет.Борт№ = Рейсы.Борт№ WHERE(((Самолет.Год_выпуска) <#1/1/2000#) AND ((Рейсы.Город_прибытия)='Москва'));";
            // создаем объект OleDbCommand для выполнения запроса к БД MS Access
            OleDbCommand command = new OleDbCommand(query, myConnection);
            // получаем объект OleDbDataReader для чтения табличного результата запроса SELECT
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                InfoDataGridView.Rows.Add();
                InfoDataGridView[0, InfoDataGridView.Rows.Count - 1].Value = reader[0].ToString();
                InfoDataGridView[1, InfoDataGridView.Rows.Count - 1].Value = reader[1].ToString();
                InfoDataGridView[2, InfoDataGridView.Rows.Count - 1].Value = reader[2].ToString();
                InfoDataGridView[3, InfoDataGridView.Rows.Count - 1].Value = reader[3].ToString();
                InfoDataGridView[4, InfoDataGridView.Rows.Count - 1].Value = reader[4].ToString();
                InfoDataGridView[5, InfoDataGridView.Rows.Count - 1].Value = reader[5].ToString();
                InfoDataGridView[6, InfoDataGridView.Rows.Count - 1].Value = reader[6].ToString();
                InfoDataGridView[7, InfoDataGridView.Rows.Count - 1].Value = reader[7].ToString();
            }
            myConnection.Close();
        }

        private void SQLButton5_Click(object sender, EventArgs e)
        {
            InfoDataGridView.Rows.Clear();
            InfoDataGridView.Columns.Clear();

            label1.Text = "Описание: \nВыводит информацию о российских аэропортах, включая рейсы из этих аэропортов и место их прибытия";

            var column1 = new DataGridViewColumn();
            column1.HeaderText = "Назв_аэропорта"; //текст в шапке
            column1.ReadOnly = true; //значение в этой колонке нельзя править
            column1.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки

            var column2 = new DataGridViewColumn();
            column2.HeaderText = "Страна";
            column2.ReadOnly = true; //значение в этой колонке нельзя править
            column2.CellTemplate = new DataGridViewTextBoxCell();

            var column3 = new DataGridViewColumn();
            column3.HeaderText = "Город";
            column3.ReadOnly = true; //значение в этой колонке нельзя править
            column3.CellTemplate = new DataGridViewTextBoxCell();

            var column4 = new DataGridViewColumn();
            column4.HeaderText = "№рейса";
            column4.ReadOnly = true; //значение в этой колонке нельзя править
            column4.CellTemplate = new DataGridViewTextBoxCell();

            var column5 = new DataGridViewColumn();
            column5.HeaderText = "Место прибытия";
            column5.ReadOnly = true; //значение в этой колонке нельзя править
            column5.CellTemplate = new DataGridViewTextBoxCell();

            InfoDataGridView.Columns.Add(column1);
            InfoDataGridView.Columns.Add(column2);
            InfoDataGridView.Columns.Add(column3);
            InfoDataGridView.Columns.Add(column4);
            InfoDataGridView.Columns.Add(column5);
            // поле - ссылка на экземпляр класса OleDbConnection для соединения с БД
            OleDbConnection myConnection;
            // создаем экземпляр класса OleDbConnection
            myConnection = new OleDbConnection(connectString);
            // открываем соединение с БД
            myConnection.Open();
            // текст запроса
            string query = "SELECT Аэропорт.Назв_аэропорта, Аэропорт.Страна, Аэропорт.Город, Рейсы.[№рейса], Рейсы.[Место прибытия] FROM Аэропорт INNER JOIN Рейсы ON Аэропорт.Назв_аэропорта = Рейсы.Аэропорт_отправления WHERE(((Аэропорт.Страна) = 'Россия')); ";
            // создаем объект OleDbCommand для выполнения запроса к БД MS Access
            OleDbCommand command = new OleDbCommand(query, myConnection);
            // получаем объект OleDbDataReader для чтения табличного результата запроса SELECT
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                InfoDataGridView.Rows.Add();
                InfoDataGridView[0, InfoDataGridView.Rows.Count - 1].Value = reader[0].ToString();
                InfoDataGridView[1, InfoDataGridView.Rows.Count - 1].Value = reader[1].ToString();
                InfoDataGridView[2, InfoDataGridView.Rows.Count - 1].Value = reader[2].ToString();
                InfoDataGridView[3, InfoDataGridView.Rows.Count - 1].Value = reader[3].ToString();
                InfoDataGridView[4, InfoDataGridView.Rows.Count - 1].Value = reader[4].ToString();
            }
            myConnection.Close();
        }
    }
}
