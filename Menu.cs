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
    public partial class Menu : Form
    {
        public int ID = 0;
        public Menu(int ID_log)
        {
            InitializeComponent();
            ID = ID_log;
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void gosti_btn_Click(object sender, EventArgs e)
        {
            Gosti Win = new Gosti(ID);
            Win.Owner = this;
            this.Hide();
            Win.Show();
        }

        private void komnaty_btn_Click(object sender, EventArgs e)
        {
            Komnaty Win = new Komnaty(ID);
            Win.Owner = this;
            this.Hide();
            Win.Show();
        }

        private void registraciya_btn_Click(object sender, EventArgs e)
        {
            Registraciya Win = new Registraciya(ID);
            Win.Owner = this;
            this.Hide();
            Win.Show();
        }

        private void personal_btn_Click(object sender, EventArgs e)
        {
            Personal Win = new Personal(ID);
            Win.Owner = this;
            this.Hide();
            Win.Show();
        }

        private void dolzhnost_btn_Click(object sender, EventArgs e)
        {
            Dolzhnosti Win = new Dolzhnosti(ID);
            Win.Owner = this;
            this.Hide();
            Win.Show();
        }
    }
}
