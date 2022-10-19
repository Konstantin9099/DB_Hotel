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
    public partial class Avtorizaciya : Form
    {
        public Avtorizaciya()
        {
            InitializeComponent();
        }

        private void vhod_btn_Click(object sender, EventArgs e)
        {
            // Запрос к таблице Authorization.
            string query = "SELECT id_login FROM authorization WHERE login ='" + login_box.Text + "' and parol = '" + parol_box.Text + "';";
            MySqlConnection conn = DBUtils.GetDBConnection();
            // Объект для выполнения SQL-запроса.
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            try
            {
                // Устанавливаем соединение с БД.
                conn.Open();
                int result = 0;
                result = Convert.ToInt32(cmDB.ExecuteScalar());
                if (result > 1)
                {
                    Menu Win = new Menu(result); // Обращение к форме "Menu", на которую будет совершаться переход.
                    Win.Owner = this;
                    this.Hide();
                    Win.Show(); // Запуск окна "Menu".
                    login_box.Clear(); // Очистка поля - логин.
                    parol_box.Clear(); // Очистка поля - пароль.
                }
                else
                    MessageBox.Show("Возникла ошибка авторизации!");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
            }
        }

        // Обработка события нажатия на кнопку "Выход".
        private void vyhod_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
