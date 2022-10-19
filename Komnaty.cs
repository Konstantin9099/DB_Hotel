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
    public partial class Komnaty : Form
    {
        public int ID = 0;
        public Komnaty(int ID_log)
        {
            InitializeComponent();
            Get_Info(ID_log);
            ID = ID_log;
        }

        private void Komnaty_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // Получаем данные из БД из таблицы "rooms" - "Комнаты".
        public void Get_Info(int ID)
        {
            string query = "SELECT id_room AS 'Код', num_room '№ комнаты', floor_room 'этаж комнаты' FROM rooms order by num_room; ";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                dataGridView1.DataSource = dt;
                dataGridView1.ClearSelection();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.ClearSelection();
                dataGridView1.Columns[0].Visible = false;
                this.dataGridView1.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла непредвиденая ошибка!" + Environment.NewLine + ex.Message);
            }
        }

        // Вывод данных в поля формы (№ комнаты и этаж) при выделении строки нажатием курсора.
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            komnata_tb.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            etazh_tb.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        // Добавление комнаты.
        private void dobavit_btn_Click(object sender, EventArgs e)
        {
            // Проверяем, чтобы были введены ФИО.
            if (komnata_tb.Text == null || komnata_tb.Text == "")
                MessageBox.Show(
                    "Введите № комнаты.",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            else if(etazh_tb.Text == null || etazh_tb.Text == "")
                MessageBox.Show(
                    "Введите этаж комнаты.",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            else
            {
                DialogResult res = MessageBox.Show("Вы уверены что хотите добавить информацию?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    string query = "insert into rooms(num_room, floor_room) values('" + komnata_tb.Text + "', '" + etazh_tb.Text + "'); ";
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
                    Get_Info(ID);
                    komnata_tb.Clear();
                    etazh_tb.Clear();
                }
            }
        }

        string id;
        public Komnaty(string mode, string Id)
        {
            InitializeComponent();

            if (mode == "chng")
            {
                id = Id;
            }
        }

        // Переход к форме "Изменить".
        private void izmenit_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                Izmenit_komnata IzmKomn = new Izmenit_komnata("chng", dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
                IzmKomn.label3.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
                IzmKomn.komnata_tb.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
                IzmKomn.etazh_tb.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString();
                IzmKomn.Owner = this;
                IzmKomn.Show();
            }
        }

        //Функция, позволяющая отправить команду на сервер БД для оптимизации кода.
        public void do_Action(string query)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                cmDB.ExecuteReader();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
            }
        }

        // Обновление БД.
        private void obnovit_btn_Click(object sender, EventArgs e)
        {
            Get_Info(ID);
            komnata_tb.Clear();
            etazh_tb.Clear();
        }

        // Переход в меню и закрытие формы.
        private void menu_bt_Click(object sender, EventArgs e)
        {
            Menu Men = new Menu(ID);
            Men.Owner = this;
            this.Hide();
            Men.Show();
        }
    }
}
