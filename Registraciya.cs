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
using ExcelObj = Microsoft.Office.Interop.Excel;

namespace DB_Hotel
{
    public partial class Registraciya : Form
    {
        public int ID = 0;
        public Registraciya(int ID_log)
        {
            InitializeComponent();
            Get_Info(ID_log);
            ID = ID_log;
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }

        private void Registraciya_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // Получаем данные из БД.
        public void Get_Info(int ID)
        {
            // Таблица "reg" - "Регистрация".
            string query = "SELECT * FROM lives, reg, rooms, workers WHERE lives.id_live=reg.who_live and workers.id_worker=reg.who_write and rooms.id_room=reg.id_room ORDER BY id_reg;";
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
                this.dataGridView1.Columns[1].HeaderText = "ФИО гостя";
                this.dataGridView1.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dataGridView1.Columns[1].Width = 200;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[4].Visible = false;
                this.dataGridView1.Columns[5].HeaderText = "Дата заезда";
                this.dataGridView1.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dataGridView1.Columns[5].Width = 80;
                this.dataGridView1.Columns[6].HeaderText = "Дата выезда";
                this.dataGridView1.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dataGridView1.Columns[6].Width = 80;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].Visible = false;
                this.dataGridView1.Columns[9].HeaderText = "№ комнаты";
                this.dataGridView1.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dataGridView1.Columns[9].Width = 60;
                dataGridView1.Columns[10].Visible = false;
                dataGridView1.Columns[11].Visible = false;
                this.dataGridView1.Columns[12].HeaderText = "Кто зарегистрировал (ФИО)";
                this.dataGridView1.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dataGridView1.Columns[12].Width = 220;
                dataGridView1.Columns[13].Visible = false;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла непредвиденая ошибка!" + Environment.NewLine + ex.Message);
            }

            // Таблица "rooms" (Комнаты) - занятые номера.
            string query1 = "SELECT * FROM rooms inner join reg ON rooms.id_room=reg.id_room where id_reg IN (SELECT id_reg FROM reg WHERE when_out>=CURDATE()) order by id_reg; ";
            MySqlConnection conn1 = DBUtils.GetDBConnection();
            MySqlDataAdapter sda1 = new MySqlDataAdapter(query1, conn1);
            DataTable dt1 = new DataTable();
            try
            {
                conn1.Open();
                sda1.Fill(dt1);
                dataGridView2.DataSource = dt1;
                dataGridView2.ClearSelection();
                dataGridView2.Columns[0].Visible = false;
                this.dataGridView2.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dataGridView2.Columns[1].HeaderText = "№ комнаты";
                this.dataGridView2.Columns[1].Width = 75;
                this.dataGridView2.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dataGridView2.Columns[2].HeaderText = "Этаж";
                this.dataGridView2.Columns[2].Width = 75;
                dataGridView2.Columns[3].Visible = false;
                dataGridView2.Columns[4].Visible = false;
                dataGridView2.Columns[5].Visible = false;
                this.dataGridView2.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dataGridView2.Columns[6].HeaderText = "Дата заезда";
                this.dataGridView2.Columns[6].Width = 105;
                this.dataGridView2.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dataGridView2.Columns[7].HeaderText = "Дата выезда";
                this.dataGridView2.Columns[7].Width = 105;
                dataGridView2.Columns[8].Visible = false;

                dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                conn1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла непредвиденая ошибка!" + Environment.NewLine + ex.Message);
            }
        }

        // Вывод выпадающих списков в поля "ФИО гостя" и "Сотрудник, выполнивший запись:".
        private void Registraciya_Load(object sender, EventArgs e)
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
                conn.Close();
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
                string query2 = "SELECT * FROM  hotels.rooms order by num_room;";
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

        // Вывод данных в текстовые поля формы "Регистрация" при выделении строки нажатием курсора.
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fio_gost_cb.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            fio_sotr_cb.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            dateTimePicker2.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            nom_komn_cb.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();            
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

        // Кнопка "Добавить".
        private void dobavit_btn_Click(object sender, EventArgs e)
        {
            // Проверяем, чтобы были введены ФИО.
            if (fio_gost_cb.Text == null || fio_gost_cb.Text == "")
                MessageBox.Show(
                    "Выберете ФИО гостя.",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            else if (fio_sotr_cb.Text == null || fio_sotr_cb.Text == "")
                MessageBox.Show(
                    "Выберете ФИО сотрудника, выполняющего запись.",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            else if (nom_komn_cb.Text == null || nom_komn_cb.Text == "")
                MessageBox.Show(
                    "Выберете номер свободной комнаты.",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            else
            {                
                string Date1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string Date2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                string query = "insert into reg(who_live, who_write, when_in, when_out, id_room) values('" + id_gost_lb.Text + "', '" + id_sotr_lb.Text + "', '" + Date1 + "', '" + Date2 + "', '" + id_komn_lb.Text + "'); ";
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
            }
        }

        // Кнопка "Изменить".
        private void izmenit_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                Izmenit_registraciya IzmReg = new Izmenit_registraciya("chng", dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString());
                IzmReg.label6.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
                IzmReg.fio_gost_cb.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
                IzmReg.label7.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString();
                IzmReg.fio_sotr_cb.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[12].Value.ToString();
                IzmReg.dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[5].Value.ToString());
                IzmReg.dateTimePicker2.Value = Convert.ToDateTime(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[6].Value.ToString());
                IzmReg.nom_komn_cb.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[9].Value.ToString();
                IzmReg.Owner = this;
                IzmReg.Show();
            }
        }

        // Кнопка "Обновить".
        private void obnovit_btn_Click(object sender, EventArgs e)
        {
            Get_Info(ID);
        }

        // Кнопка "Удалить".
        private void udalit_btn_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Вы уверены что хотите удалить информацию?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                string valueCell = dataGridView1.CurrentCell.Value != null ? dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString() : "";
                string del = "delete from reg where id_reg = " + valueCell + ";";
                do_Action(del);
            }
            else
            {
                MessageBox.Show("Не выбрано ни одной записи! Удаление невозможно.");
            }
        }

        // Кнопка "Menu".
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

        // Кнопка "Печать". Экспорт файла в Excel.
        private void print_bt_Click(object sender, EventArgs e) 
        {
            int kol = dataGridView1.Rows.Count;
            if (kol != 0)
            {
                Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
                Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
                //Книга.
                ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
                //Таблица.
                ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    ExcelApp.Cells[1, i + 1] = Convert.ToString(dataGridView1.Columns[i].HeaderText);
                }
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        ExcelApp.Cells[i + 2, j + 1] = Convert.ToString(dataGridView1.Rows[i].Cells[j].Value);
                    }
                }
                //Вызываем приложение Excel.
                ExcelApp.Visible = true;
                ExcelApp.UserControl = true;
            }
            else
            {
                MessageBox.Show("Для импорта данных из таблицы в Excel для начало заполните таблицу данными!", "Импорт данных из таблицы в Excel");
            }
        }

        // Выбор ФИО гостя в выпадающем списке comboBox.
        private void fio_gost_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
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
        }

        // Выбор ФИО сотрудника в выпадающем списке comboBox.
        private void fio_sotr_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
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
        }

        // Выбор № комнаты в выпадающем списке comboBox.
        private void nom_komn_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
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
        }
    }
}
