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

namespace IS_2_19_MogilnikovDA
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        MySqlConnection conn = new MySqlConnection("server=caseum.ru;port=33333;user=st_2_16_19;database=st_2_16_19;password=67502373;");
        class connn : Form2
        {

            public MySqlConnection rtrn()
            {
                return conn;
            }


        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MessageBox.Show("Соединение открыто");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Соединение закрыто"+ ex);
            }
            conn.Close();
        }
    }
}
