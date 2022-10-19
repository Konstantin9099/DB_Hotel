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
    public partial class Izmenit_registraciya : Form
    {
        public Registraciya fm { get; set; }
        public Izmenit_registraciya()
        {
            InitializeComponent();
            this.fm = fm;
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
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

        string id_reg;

        public Izmenit_registraciya(string mode, string Id_reg)
        {
            InitializeComponent();

            if (mode == "chng")
            {
                id_reg = Id_reg;
            }
        }

        // Вывод выпадающих списков в поля "ФИО гостя" и "Сотрудник, выполнивший запись:".
        private void Izmenit_registraciya_Load(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM  hotels.lives ";
                MySqlConnection conn = DBUtils.GetDBConnection();
                MySqlCommand cmDB = new MySqlCommand(query, conn);

                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    fio_gost_cb.Items.Add(reader.GetString("fio"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                string query1 = "SELECT * FROM  hotels.workers ";
                MySqlConnection conn1 = DBUtils.GetDBConnection();
                MySqlCommand cmDB = new MySqlCommand(query1, conn1);

                conn1.Open();
                MySqlCommand command = new MySqlCommand(query1, conn1);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    fio_sotr_cb.Items.Add(reader.GetString("fio"));
                }
                conn1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                string query2 = "SELECT * FROM  hotels.rooms ";
                MySqlConnection conn2 = DBUtils.GetDBConnection();
                MySqlCommand cmDB = new MySqlCommand(query2, conn2);

                conn2.Open();
                MySqlCommand command = new MySqlCommand(query2, conn2);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    nom_komn_cb.Items.Add(reader.GetString("num_room"));
                }
                conn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        // Команда "Назад" - к форме "Регистрация".
        private void nazad_btn_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }
        // Сохранение изменений.
        private void sohranit_btn_Click(object sender, EventArgs e)
        {
            // Извлечение id гостя через выпадающей списк ФИО в comboBox.
            string id_gost = fio_gost_cb.Text;
            try
            {
                string ID_gost = "SELECT id_live FROM lives where fio='" + id_gost + "';";
                MySqlConnection conn = DBUtils.GetDBConnection();
                MySqlCommand cmDB = new MySqlCommand(ID_gost, conn);

                conn.Open();
                MySqlCommand command = new MySqlCommand(ID_gost, conn);
                id_gost_lb.Text = command.ExecuteScalar().ToString();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Извлечение id сотрудника через выпадающей списк ФИО в comboBox.
            string id_sotr = fio_sotr_cb.Text;
            try
            {
                string ID_sotr = "SELECT id_worker FROM workers where fio='" + id_sotr + "';";
                MySqlConnection conn = DBUtils.GetDBConnection();
                MySqlCommand cmDB = new MySqlCommand(ID_sotr, conn);

                conn.Open();
                MySqlCommand command = new MySqlCommand(ID_sotr, conn);
                id_sotr_lb.Text = command.ExecuteScalar().ToString();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Извлечение id комнаты через выпадающей списк номеров в comboBox.
            string id_komn = nom_komn_cb.Text;
            try
            {
                string ID_komn = "SELECT id_room FROM rooms where num_room='" + id_komn + "';";
                MySqlConnection conn = DBUtils.GetDBConnection();
                MySqlCommand cmDB = new MySqlCommand(ID_komn, conn);

                conn.Open();
                MySqlCommand command = new MySqlCommand(ID_komn, conn);
                id_komn_lb.Text = command.ExecuteScalar().ToString();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Проверяем, чтобы были заполнены все поля.
            if (fio_gost_cb.Text == null || fio_gost_cb.Text == "")
                MessageBox.Show(
                    "Выберете ФИО гостя.",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            else if (fio_sotr_cb.Text == null || fio_sotr_cb.Text == "")
                MessageBox.Show(
                    "Выберете ФИО сотрудника.",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            else if (nom_komn_cb.Text == null || nom_komn_cb.Text == "")
                MessageBox.Show(
                    "Выберете № комнаты.",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            {
                DialogResult res = MessageBox.Show("Вы уверены что хотите изменить информацию?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    string Date1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                    string Date2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                    string query = "update reg set who_live = '" + id_gost_lb.Text + "', who_write = '" + id_sotr_lb.Text + "', when_in = '" + Date1 + "', when_out = '" + Date2 + "', id_room = '" + id_komn_lb.Text + "' where id_reg =" + id_reg.ToString() + ";";
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
    }
}
