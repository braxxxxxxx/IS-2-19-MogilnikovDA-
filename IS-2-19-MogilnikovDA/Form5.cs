using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ClassLibrary2;

namespace IS_2_19_MogilnikovDA
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private MySqlDataAdapter MyDA = new MySqlDataAdapter();
        private BindingSource bSource = new BindingSource();
        private DataTable table = new DataTable();
        public bool data()
        {

            int InsertCount = 0;
            bool result = false;
            Class1 connn = new Class1();
            MySqlConnection conn = new MySqlConnection(connn.connStr);
            conn.Open();
            string insertreys2 = textBox1.Text;
            string insertdate2 = dateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string newreys2 = $"INSERT INTO t_PraktStud (fioStud, datetimeStud) VALUES ('{insertreys2}', '{insertdate2}')";
            //код взял из курсовой, поэтому переменные могут немного странно звучать 
            try
            {
                // объект для выполнения SQL-запроса
                MySqlCommand command123123 = new MySqlCommand(newreys2, conn);
                // выполняем запрос
                InsertCount = command123123.ExecuteNonQuery();
                // закрываем подключение к БД
            }
            catch
            {
                //Если возникла ошибка, то запрос не вставит ни одной строки
                InsertCount = 0;
            }
            finally
            {
                //Но в любом случае, нужно закрыть соединение
                conn.Close();
                //Ессли количество вставленных строк было не 0, то есть вставлена хотя бы 1 строка
                if (InsertCount != 0)
                {
                    //то результат операции - истина
                    result = true;
                }
            }
            //Вернём результат операции, где его обработает алгоритм
            return result;
        }
        public void getlist()
        {
            Class1 connn = new Class1();
            MySqlConnection conn = new MySqlConnection(connn.connStr);
            string sql = $"SELECT fioStud, datetimeStud FROM t_PraktStud";
            conn.Open();
            MyDA.SelectCommand = new MySqlCommand(sql, conn);
            MyDA.Fill(table);
            bSource.DataSource = table;
            dataGridView1.DataSource = bSource;
            conn.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            dateTimePicker2.Value = DateTime.Now;
            getlist();
        }
        public void obnovit()
        {
            table.Clear();
            getlist();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Введите ФИО");
            }
            else
            {
                data();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            obnovit();
        }
    }
}
