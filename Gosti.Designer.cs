
namespace DB_Hotel
{
    partial class Gosti
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.fio_tb = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.izmenit_btn = new System.Windows.Forms.Button();
            this.dobavit_btn = new System.Windows.Forms.Button();
            this.obnovit_btn = new System.Windows.Forms.Button();
            this.menu_bt = new System.Windows.Forms.Button();
            this.poisk_btn = new System.Windows.Forms.Button();
            this.stroka_poiska_tb = new System.Windows.Forms.TextBox();
            this.udalit_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "ФИО:";
            // 
            // fio_tb
            // 
            this.fio_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fio_tb.Location = new System.Drawing.Point(16, 40);
            this.fio_tb.Name = "fio_tb";
            this.fio_tb.Size = new System.Drawing.Size(376, 26);
            this.fio_tb.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(16, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(509, 335);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // izmenit_btn
            // 
            this.izmenit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.izmenit_btn.Location = new System.Drawing.Point(149, 76);
            this.izmenit_btn.Name = "izmenit_btn";
            this.izmenit_btn.Size = new System.Drawing.Size(110, 38);
            this.izmenit_btn.TabIndex = 26;
            this.izmenit_btn.Text = "Изменить";
            this.izmenit_btn.UseVisualStyleBackColor = true;
            this.izmenit_btn.Click += new System.EventHandler(this.izmenit_btn_Click);
            // 
            // dobavit_btn
            // 
            this.dobavit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dobavit_btn.Location = new System.Drawing.Point(16, 76);
            this.dobavit_btn.Name = "dobavit_btn";
            this.dobavit_btn.Size = new System.Drawing.Size(110, 38);
            this.dobavit_btn.TabIndex = 25;
            this.dobavit_btn.Text = "Добавить";
            this.dobavit_btn.UseVisualStyleBackColor = true;
            this.dobavit_btn.Click += new System.EventHandler(this.dobavit_btn_Click);
            // 
            // obnovit_btn
            // 
            this.obnovit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.obnovit_btn.Location = new System.Drawing.Point(282, 76);
            this.obnovit_btn.Name = "obnovit_btn";
            this.obnovit_btn.Size = new System.Drawing.Size(110, 38);
            this.obnovit_btn.TabIndex = 47;
            this.obnovit_btn.Text = "Обновить";
            this.obnovit_btn.UseVisualStyleBackColor = true;
            this.obnovit_btn.Click += new System.EventHandler(this.obnovit_btn_Click);
            // 
            // menu_bt
            // 
            this.menu_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.menu_bt.Location = new System.Drawing.Point(415, 38);
            this.menu_bt.Name = "menu_bt";
            this.menu_bt.Size = new System.Drawing.Size(110, 30);
            this.menu_bt.TabIndex = 48;
            this.menu_bt.Text = "Menu";
            this.menu_bt.UseVisualStyleBackColor = true;
            this.menu_bt.Click += new System.EventHandler(this.menu_bt_Click);
            // 
            // poisk_btn
            // 
            this.poisk_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.poisk_btn.Location = new System.Drawing.Point(415, 473);
            this.poisk_btn.Name = "poisk_btn";
            this.poisk_btn.Size = new System.Drawing.Size(110, 30);
            this.poisk_btn.TabIndex = 50;
            this.poisk_btn.Text = "Найти";
            this.poisk_btn.UseVisualStyleBackColor = true;
            this.poisk_btn.Click += new System.EventHandler(this.poisk_btn_Click);
            // 
            // stroka_poiska_tb
            // 
            this.stroka_poiska_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.stroka_poiska_tb.Location = new System.Drawing.Point(16, 475);
            this.stroka_poiska_tb.Name = "stroka_poiska_tb";
            this.stroka_poiska_tb.Size = new System.Drawing.Size(385, 26);
            this.stroka_poiska_tb.TabIndex = 49;
            // 
            // udalit_btn
            // 
            this.udalit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.udalit_btn.Location = new System.Drawing.Point(415, 76);
            this.udalit_btn.Name = "udalit_btn";
            this.udalit_btn.Size = new System.Drawing.Size(110, 38);
            this.udalit_btn.TabIndex = 51;
            this.udalit_btn.Text = "Удалить";
            this.udalit_btn.UseVisualStyleBackColor = true;
            this.udalit_btn.Click += new System.EventHandler(this.udalit_btn_Click);
            // 
            // Gosti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 514);
            this.Controls.Add(this.udalit_btn);
            this.Controls.Add(this.poisk_btn);
            this.Controls.Add(this.stroka_poiska_tb);
            this.Controls.Add(this.menu_bt);
            this.Controls.Add(this.obnovit_btn);
            this.Controls.Add(this.izmenit_btn);
            this.Controls.Add(this.dobavit_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fio_tb);
            this.Name = "Gosti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Гости";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Zhilcy_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fio_tb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button izmenit_btn;
        private System.Windows.Forms.Button dobavit_btn;
        private System.Windows.Forms.Button obnovit_btn;
        private System.Windows.Forms.Button menu_bt;
        private System.Windows.Forms.Button poisk_btn;
        private System.Windows.Forms.TextBox stroka_poiska_tb;
        private System.Windows.Forms.Button udalit_btn;
    }
}