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
    public partial class Izmenit_dolzhnost : Form
    {
        public Dolzhnosti fm { get; set; }
        public Izmenit_dolzhnost(Dolzhnosti fm)
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
        public Izmenit_dolzhnost(string mode, string Id)
        {
            InitializeComponent();

            if (mode == "chng")
            {
                id = Id;
            }
        }
        // Команда - сохранить изменения.
        private void sohranit_btn_Click(object sender, EventArgs e)
        {
            // Проверяем, чтобы были заполнены все поля.
            if (dolzhnost_tb.Text == null || dolzhnost_tb.Text == "")
                MessageBox.Show(
                    "Введите наименование должности.",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            {
                DialogResult res = MessageBox.Show("Вы уверены что хотите сохранить информацию?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    string query = "update position set name_position = '" + dolzhnost_tb.Text + "' where id_position =" + id.ToString() + ";";
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
        // Команда - "Назад".
        private void nazad_btn_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }
    }
}
