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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private MySqlDataAdapter MyDA = new MySqlDataAdapter();
        private BindingSource bSource = new BindingSource();
        private DataSet ds = new DataSet();
        private DataTable table = new DataTable();


        private void Form4_Load(object sender, EventArgs e)
        {
            Class1 connn = new Class1();
            MySqlConnection conn = new MySqlConnection(connn.connStr);
            string sql = $"SELECT idStud, fioStud, drStud FROM t_datetime";
            conn.Open();
            MyDA.SelectCommand = new MySqlCommand(sql, conn);
            MyDA.Fill(table);
            bSource.DataSource = table;
            dataGridView1.DataSource = bSource;
            conn.Close();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string a = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            DateTime date = DateTime.Today;
            DateTime date2 = Convert.ToDateTime(dataGridView1.Rows[Convert.ToInt32(a)].Cells[2].Value.ToString());
            TimeSpan diff1 = date2.Subtract(date);
            MessageBox.Show(diff1.ToString());
            //не получилось нормально вывести :(
        }
    }
}
