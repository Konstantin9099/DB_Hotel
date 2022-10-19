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
    public partial class Gosti : Form
    {
        public int ID = 0;
        public Gosti(int ID_log)
        {
            InitializeComponent();
            Get_Info(ID_log);
            ID = ID_log;
        }

        private void Zhilcy_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        // Получаем данные из БД из таблицы "lives" - "Гости".
        public void Get_Info(int ID)
        {
            string query = "SELECT id_live AS 'Код', fio AS 'ФИО' FROM lives";
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
                this.dataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dataGridView1.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dataGridView1.Columns[1].Width = 220;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла непредвиденая ошибка!" + Environment.NewLine + ex.Message);
            }
        }

        // Вывод данных в текстовое поле формы "ФИО" при выделении строки нажатием курсора.
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fio_tb.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        // Добавление нового гостя.
        private void dobavit_btn_Click(object sender, EventArgs e)
        {
            // Проверяем, чтобы были введены ФИО.
            if (fio_tb.Text == null || fio_tb.Text == "")
                MessageBox.Show(
                    "Введите фамилию, имя и отчество.",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            DialogResult res = MessageBox.Show("Вы уверены что хотите добавить информацию?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                string query = "insert into lives(fio) values('" + fio_tb.Text + "'); ";
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
            Get_Info(ID);
            fio_tb.Clear();
        }

        string id;
        public Gosti(string mode, string Id)
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
                Izmenit_gosti IzmGost = new Izmenit_gosti("chng", dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
                IzmGost.label1.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
                IzmGost.fio_tb.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
                IzmGost.Owner = this;
                IzmGost.Show();
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
            fio_tb.Clear();
        }
        // Удаление "гостя" из БД.
        private void udalit_btn_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Вы уверены что хотите удалить информацию?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                string valueCell = dataGridView1.CurrentCell.Value != null ? dataGridView1.CurrentCell.Value.ToString() : "";
                string del = "delete from lives where id_live = " + valueCell + ";";
                do_Action(del);
            }
            else
            {
                MessageBox.Show("Не выбрано ни одной записи! Удаление невозможно.");
            }
            Get_Info(ID);
            fio_tb.Clear();
        }
        // Переход в меню и закрытие формы.
        private void menu_bt_Click(object sender, EventArgs e)
        {
            Menu Men = new Menu(ID);
            Men.Owner = this;
            this.Hide();
            Men.Show();
        }
        // Строка поиска.
        private void poisk_btn_Click(object sender, EventArgs e)
        {
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].Selected = false;
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                        if (dataGridView1.Rows[i].Cells[j].Value != null)
                            if (dataGridView1.Rows[i].Cells[j].Value.ToString().ToLower().Contains(stroka_poiska_tb.Text.ToLower()))
                            {
                                dataGridView1.Rows[i].Selected = true;
                                break;
                            }
                }
            }
        }
    }
}
