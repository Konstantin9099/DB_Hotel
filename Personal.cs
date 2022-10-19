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
    public partial class Personal : Form
    {
        public int ID = 0;
        public Personal(int ID_log)
        {
            InitializeComponent();
            Get_Info(ID_log);
            ID = ID_log;
        }

        private void Personal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // Получаем данные из БД из таблицы "positions" - "Должности".
        public void Get_Info(int ID)
        {
            string query = "SELECT * FROM workers, position WHERE workers.id_position=position.id_position ORDER BY name_position; ";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.ClearSelection();
                dataGridView1.Columns[0].Visible = false;
                this.dataGridView1.Columns[1].HeaderText = "ФИО сотрудника";
                this.dataGridView1.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dataGridView1.Columns[1].Width = 220;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[3].Visible = false;
                this.dataGridView1.Columns[4].HeaderText = "Должность";
                this.dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dataGridView1.Columns[4].Width = 120;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла непредвиденая ошибка!" + Environment.NewLine + ex.Message);
            }
        }
        // Вывод данных в текстовые поля формы "Персонал" при выделении строки нажатием курсора.
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fio_tb.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dolzhnost_cmb.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

        }
        // Вывод выпадающего списка в поле "Наименование должности" - код должности. 
        private void Personal_Load(object sender, EventArgs e)
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
        // Добавление нового сотрудника.
        private void dobavit_btn_Click(object sender, EventArgs e)
        {
            // Проверяем, чтобы были введены ФИО.
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
            else
            {
                DialogResult res = MessageBox.Show("Вы уверены что хотите добавить информацию?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    string query = "insert into workers(fio, id_position) values('" + fio_tb.Text + "', '" + id_dolzn_lb.Text + "'); ";
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
                    // fio_tb.Clear();
                    // dolzhnost_cmb.SelectedIndex = -1;
                }

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

        string id;
        public Personal(string mode, string Id)
        {
            InitializeComponent();

            if (mode == "chng")
            {
                id = Id;
            }
        }

        // Переход к форме изменить.
        private void izmenit_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                Izmenit_personal IzmPerson = new Izmenit_personal("chng", dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
                IzmPerson.label3.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
                IzmPerson.fio_tb.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
                IzmPerson.dolzhnost_cmb.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value.ToString();
                IzmPerson.Owner = this;
                IzmPerson.Show();
            }
        }
        // Обновление БД.
        private void obnovit_btn_Click(object sender, EventArgs e)
        {
            Get_Info(ID);
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

        // Выбор должности в выпадающем списке comboBox.
        private void dolzhnost_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id_dolz = dolzhnost_cmb.Text;
            try
            {
                string ID_dolz = "SELECT id_position FROM position where name_position='" + id_dolz + "';";
                MySqlConnection conn = DBUtils.GetDBConnection();
                MySqlCommand cmDB = new MySqlCommand(ID_dolz, conn);

                conn.Open();
                MySqlCommand command = new MySqlCommand(ID_dolz, conn);
                id_dolzn_lb.Text = command.ExecuteScalar().ToString();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
