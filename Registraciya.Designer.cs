
namespace DB_Hotel
{
    partial class Registraciya
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.id_komn_lb = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fio_gost_cb = new System.Windows.Forms.ComboBox();
            this.fio_sotr_cb = new System.Windows.Forms.ComboBox();
            this.nom_komn_cb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.udalit_btn = new System.Windows.Forms.Button();
            this.obnovit_btn = new System.Windows.Forms.Button();
            this.izmenit_btn = new System.Windows.Forms.Button();
            this.dobavit_btn = new System.Windows.Forms.Button();
            this.poisk_btn = new System.Windows.Forms.Button();
            this.stroka_poiska_tb = new System.Windows.Forms.TextBox();
            this.menu_bt = new System.Windows.Forms.Button();
            this.print_bt = new System.Windows.Forms.Button();
            this.id_gost_lb = new System.Windows.Forms.Label();
            this.id_sotr_lb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "ФИО гостя:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(11, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Сотрудник, выполнивший запись:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePicker1.Location = new System.Drawing.Point(11, 184);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(221, 26);
            this.dateTimePicker1.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(11, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Дата заезда:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePicker2.Location = new System.Drawing.Point(11, 250);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(221, 26);
            this.dateTimePicker2.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Дата выезда:";
            // 
            // id_komn_lb
            // 
            this.id_komn_lb.AutoSize = true;
            this.id_komn_lb.Location = new System.Drawing.Point(335, 220);
            this.id_komn_lb.Name = "id_komn_lb";
            this.id_komn_lb.Size = new System.Drawing.Size(61, 17);
            this.id_komn_lb.TabIndex = 40;
            this.id_komn_lb.Text = "id_komn";
            this.id_komn_lb.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Location = new System.Drawing.Point(11, 347);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(929, 324);
            this.dataGridView1.TabIndex = 41;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // fio_gost_cb
            // 
            this.fio_gost_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fio_gost_cb.FormattingEnabled = true;
            this.fio_gost_cb.Location = new System.Drawing.Point(11, 48);
            this.fio_gost_cb.Name = "fio_gost_cb";
            this.fio_gost_cb.Size = new System.Drawing.Size(385, 28);
            this.fio_gost_cb.TabIndex = 57;
            this.fio_gost_cb.SelectedIndexChanged += new System.EventHandler(this.fio_gost_cb_SelectedIndexChanged);
            // 
            // fio_sotr_cb
            // 
            this.fio_sotr_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fio_sotr_cb.FormattingEnabled = true;
            this.fio_sotr_cb.Location = new System.Drawing.Point(11, 116);
            this.fio_sotr_cb.Name = "fio_sotr_cb";
            this.fio_sotr_cb.Size = new System.Drawing.Size(385, 28);
            this.fio_sotr_cb.TabIndex = 58;
            this.fio_sotr_cb.SelectedIndexChanged += new System.EventHandler(this.fio_sotr_cb_SelectedIndexChanged);
            // 
            // nom_komn_cb
            // 
            this.nom_komn_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nom_komn_cb.FormattingEnabled = true;
            this.nom_komn_cb.Location = new System.Drawing.Point(265, 182);
            this.nom_komn_cb.Name = "nom_komn_cb";
            this.nom_komn_cb.Size = new System.Drawing.Size(131, 28);
            this.nom_komn_cb.TabIndex = 60;
            this.nom_komn_cb.SelectedIndexChanged += new System.EventHandler(this.nom_komn_cb_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(261, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 59;
            this.label5.Text = "№ комнаты:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView2.Location = new System.Drawing.Point(415, 48);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(525, 228);
            this.dataGridView2.TabIndex = 61;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(415, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 20);
            this.label6.TabIndex = 62;
            this.label6.Text = "Занятые номера:";
            // 
            // udalit_btn
            // 
            this.udalit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.udalit_btn.Location = new System.Drawing.Point(413, 292);
            this.udalit_btn.Name = "udalit_btn";
            this.udalit_btn.Size = new System.Drawing.Size(110, 38);
            this.udalit_btn.TabIndex = 66;
            this.udalit_btn.Text = "Удалить";
            this.udalit_btn.UseVisualStyleBackColor = true;
            this.udalit_btn.Click += new System.EventHandler(this.udalit_btn_Click);
            // 
            // obnovit_btn
            // 
            this.obnovit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.obnovit_btn.Location = new System.Drawing.Point(279, 292);
            this.obnovit_btn.Name = "obnovit_btn";
            this.obnovit_btn.Size = new System.Drawing.Size(110, 38);
            this.obnovit_btn.TabIndex = 65;
            this.obnovit_btn.Text = "Обновить";
            this.obnovit_btn.UseVisualStyleBackColor = true;
            this.obnovit_btn.Click += new System.EventHandler(this.obnovit_btn_Click);
            // 
            // izmenit_btn
            // 
            this.izmenit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.izmenit_btn.Location = new System.Drawing.Point(145, 292);
            this.izmenit_btn.Name = "izmenit_btn";
            this.izmenit_btn.Size = new System.Drawing.Size(110, 38);
            this.izmenit_btn.TabIndex = 64;
            this.izmenit_btn.Text = "Изменить";
            this.izmenit_btn.UseVisualStyleBackColor = true;
            this.izmenit_btn.Click += new System.EventHandler(this.izmenit_btn_Click);
            // 
            // dobavit_btn
            // 
            this.dobavit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dobavit_btn.Location = new System.Drawing.Point(11, 292);
            this.dobavit_btn.Name = "dobavit_btn";
            this.dobavit_btn.Size = new System.Drawing.Size(110, 38);
            this.dobavit_btn.TabIndex = 63;
            this.dobavit_btn.Text = "Добавить";
            this.dobavit_btn.UseVisualStyleBackColor = true;
            this.dobavit_btn.Click += new System.EventHandler(this.dobavit_btn_Click);
            // 
            // poisk_btn
            // 
            this.poisk_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.poisk_btn.Location = new System.Drawing.Point(415, 682);
            this.poisk_btn.Name = "poisk_btn";
            this.poisk_btn.Size = new System.Drawing.Size(110, 38);
            this.poisk_btn.TabIndex = 68;
            this.poisk_btn.Text = "Найти";
            this.poisk_btn.UseVisualStyleBackColor = true;
            this.poisk_btn.Click += new System.EventHandler(this.poisk_btn_Click);
            // 
            // stroka_poiska_tb
            // 
            this.stroka_poiska_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.stroka_poiska_tb.Location = new System.Drawing.Point(11, 688);
            this.stroka_poiska_tb.Name = "stroka_poiska_tb";
            this.stroka_poiska_tb.Size = new System.Drawing.Size(385, 26);
            this.stroka_poiska_tb.TabIndex = 67;
            // 
            // menu_bt
            // 
            this.menu_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.menu_bt.Location = new System.Drawing.Point(547, 292);
            this.menu_bt.Name = "menu_bt";
            this.menu_bt.Size = new System.Drawing.Size(110, 38);
            this.menu_bt.TabIndex = 69;
            this.menu_bt.Text = "Menu";
            this.menu_bt.UseVisualStyleBackColor = true;
            this.menu_bt.Click += new System.EventHandler(this.menu_bt_Click);
            // 
            // print_bt
            // 
            this.print_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.print_bt.Location = new System.Drawing.Point(557, 681);
            this.print_bt.Name = "print_bt";
            this.print_bt.Size = new System.Drawing.Size(110, 38);
            this.print_bt.TabIndex = 70;
            this.print_bt.Text = "Печать";
            this.print_bt.UseVisualStyleBackColor = true;
            this.print_bt.Click += new System.EventHandler(this.print_bt_Click);
            // 
            // id_gost_lb
            // 
            this.id_gost_lb.AutoSize = true;
            this.id_gost_lb.Location = new System.Drawing.Point(342, 18);
            this.id_gost_lb.Name = "id_gost_lb";
            this.id_gost_lb.Size = new System.Drawing.Size(54, 17);
            this.id_gost_lb.TabIndex = 71;
            this.id_gost_lb.Text = "id_gost";
            this.id_gost_lb.Visible = false;
            // 
            // id_sotr_lb
            // 
            this.id_sotr_lb.AutoSize = true;
            this.id_sotr_lb.Location = new System.Drawing.Point(345, 89);
            this.id_sotr_lb.Name = "id_sotr_lb";
            this.id_sotr_lb.Size = new System.Drawing.Size(51, 17);
            this.id_sotr_lb.TabIndex = 72;
            this.id_sotr_lb.Text = "id_sotr";
            this.id_sotr_lb.Visible = false;
            // 
            // Registraciya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 731);
            this.Controls.Add(this.id_sotr_lb);
            this.Controls.Add(this.id_gost_lb);
            this.Controls.Add(this.print_bt);
            this.Controls.Add(this.menu_bt);
            this.Controls.Add(this.poisk_btn);
            this.Controls.Add(this.stroka_poiska_tb);
            this.Controls.Add(this.udalit_btn);
            this.Controls.Add(this.obnovit_btn);
            this.Controls.Add(this.izmenit_btn);
            this.Controls.Add(this.dobavit_btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.nom_komn_cb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fio_sotr_cb);
            this.Controls.Add(this.fio_gost_cb);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.id_komn_lb);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Registraciya";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация гостей";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Registraciya_FormClosed);
            this.Load += new System.EventHandler(this.Registraciya_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox fio_gost_cb;
        private System.Windows.Forms.ComboBox fio_sotr_cb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button udalit_btn;
        private System.Windows.Forms.Button obnovit_btn;
        private System.Windows.Forms.Button izmenit_btn;
        private System.Windows.Forms.Button dobavit_btn;
        private System.Windows.Forms.Button poisk_btn;
        private System.Windows.Forms.TextBox stroka_poiska_tb;
        private System.Windows.Forms.Button menu_bt;
        private System.Windows.Forms.Button print_bt;
        public System.Windows.Forms.ComboBox nom_komn_cb;
        public System.Windows.Forms.Label id_gost_lb;
        public System.Windows.Forms.Label id_sotr_lb;
        public System.Windows.Forms.Label id_komn_lb;
    }
}