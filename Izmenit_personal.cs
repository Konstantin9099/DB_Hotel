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

namespace DB_Hotel
{
    public partial class Izmenit_personal : Form
    {
        public Personal fm { get; set; }
        public Izmenit_personal(Personal fm)
        {
            InitializeComponent();
            this.fm = fm;
        }

        void do_Action(string query)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                MySqlDataReader rd = cmDB.ExecuteReader();
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла непредвиденная ошибка!");
            }
        }

        string id;
        public Izmenit_personal(string mode, string Id)
        {
            InitializeComponent();

            if (mode == "chng")
            {
                id = Id;
            }
        }

        // Вывод выпадающего списка в поле "Наименование должности" - код должности. 
        private void Izmenit_personal_Load(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM  hotels.position ";
                MySqlConnection conn = DBUtils.GetDBConnection();
                MySqlCommand cmDB = new MySqlCommand(query, conn);

                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    dolzhnost_cmb.Items.Add(reader.GetString("name_position"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Сохранение изменений.
        private void sohranit_btn_Click(object sender, EventArgs e)
        {
            string id_dolz = dolzhnost_cmb.Text;
            try
            {
                string ID_sotr = "SELECT id_position FROM position where name_position='" + id_dolz + "';";
                MySqlConnection conn = DBUtils.GetDBConnection();
                MySqlCommand cmDB = new MySqlCommand(ID_sotr, conn);
                conn.Open();
                MySqlCommand command = new MySqlCommand(ID_sotr, conn);
                id_dolz_lb.Text = command.ExecuteScalar().ToString();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            // Проверяем, чтобы были заполнены все поля.
            if (fio_tb.Text == null || fio_tb.Text == "")
                MessageBox.Show(
                    "Введите ФИО сотрудника.",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            else if (dolzhnost_cmb.Text == null || dolzhnost_cmb.Text == "")
                MessageBox.Show(
                    "Выберете должность.",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            {
                DialogResult res = MessageBox.Show("Вы уверены что хотите изменить информацию?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    string query = "update workers set fio = '" + fio_tb.Text + "', id_position = '" + id_dolz_lb.Text + "' where id_worker =" + id.ToString() + ";";
                    MySqlConnection conn = DBUtils.GetDBConnection();
                    MySqlCommand cmDB = new MySqlCommand(query, conn);
                    try
                    {
                        conn.Open();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Произошла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
                    }
                    do_Action(query);
                }

            }
        }
        // Команда "Назад" - к форме "Персонал".
        private void nazad_btn_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }
    }
}
