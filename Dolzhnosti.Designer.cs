
namespace DB_Hotel
{
    partial class Dolzhnosti
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
            this.poisk_btn = new System.Windows.Forms.Button();
            this.stroka_poiska_tb = new System.Windows.Forms.TextBox();
            this.menu_bt = new System.Windows.Forms.Button();
            this.obnovit_btn = new System.Windows.Forms.Button();
            this.izmenit_btn = new System.Windows.Forms.Button();
            this.dobavit_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dolzhnost_tb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // poisk_btn
            // 
            this.poisk_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.poisk_btn.Location = new System.Drawing.Point(416, 471);
            this.poisk_btn.Name = "poisk_btn";
            this.poisk_btn.Size = new System.Drawing.Size(110, 30);
            this.poisk_btn.TabIndex = 60;
            this.poisk_btn.Text = "Найти";
            this.poisk_btn.UseVisualStyleBackColor = true;
            this.poisk_btn.Click += new System.EventHandler(this.poisk_btn_Click);
            // 
            // stroka_poiska_tb
            // 
            this.stroka_poiska_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.stroka_poiska_tb.Location = new System.Drawing.Point(17, 473);
            this.stroka_poiska_tb.Name = "stroka_poiska_tb";
            this.stroka_poiska_tb.Size = new System.Drawing.Size(385, 26);
            this.stroka_poiska_tb.TabIndex = 59;
            // 
            // menu_bt
            // 
            this.menu_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.menu_bt.Location = new System.Drawing.Point(416, 74);
            this.menu_bt.Name = "menu_bt";
            this.menu_bt.Size = new System.Drawing.Size(110, 38);
            this.menu_bt.TabIndex = 58;
            this.menu_bt.Text = "Menu";
            this.menu_bt.UseVisualStyleBackColor = true;
            this.menu_bt.Click += new System.EventHandler(this.menu_bt_Click);
            // 
            // obnovit_btn
            // 
            this.obnovit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.obnovit_btn.Location = new System.Drawing.Point(283, 74);
            this.obnovit_btn.Name = "obnovit_btn";
            this.obnovit_btn.Size = new System.Drawing.Size(110, 38);
            this.obnovit_btn.TabIndex = 57;
            this.obnovit_btn.Text = "Обновить";
            this.obnovit_btn.UseVisualStyleBackColor = true;
            this.obnovit_btn.Click += new System.EventHandler(this.obnovit_btn_Click);
            // 
            // izmenit_btn
            // 
            this.izmenit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.izmenit_btn.Location = new System.Drawing.Point(150, 74);
            this.izmenit_btn.Name = "izmenit_btn";
            this.izmenit_btn.Size = new System.Drawing.Size(110, 38);
            this.izmenit_btn.TabIndex = 56;
            this.izmenit_btn.Text = "Изменить";
            this.izmenit_btn.UseVisualStyleBackColor = true;
            this.izmenit_btn.Click += new System.EventHandler(this.izmenit_btn_Click);
            // 
            // dobavit_btn
            // 
            this.dobavit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dobavit_btn.Location = new System.Drawing.Point(17, 74);
            this.dobavit_btn.Name = "dobavit_btn";
            this.dobavit_btn.Size = new System.Drawing.Size(110, 38);
            this.dobavit_btn.TabIndex = 55;
            this.dobavit_btn.Text = "Добавить";
            this.dobavit_btn.UseVisualStyleBackColor = true;
            this.dobavit_btn.Click += new System.EventHandler(this.dobavit_btn_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(17, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(509, 335);
            this.dataGridView1.TabIndex = 54;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 20);
            this.label1.TabIndex = 53;
            this.label1.Text = "Наименование должности:";
            // 
            // dolzhnost_tb
            // 
            this.dolzhnost_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dolzhnost_tb.Location = new System.Drawing.Point(17, 38);
            this.dolzhnost_tb.Name = "dolzhnost_tb";
            this.dolzhnost_tb.Size = new System.Drawing.Size(385, 26);
            this.dolzhnost_tb.TabIndex = 52;
            // 
            // Dolzhnosti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 515);
            this.Controls.Add(this.poisk_btn);
            this.Controls.Add(this.stroka_poiska_tb);
            this.Controls.Add(this.menu_bt);
            this.Controls.Add(this.obnovit_btn);
            this.Controls.Add(this.izmenit_btn);
            this.Controls.Add(this.dobavit_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dolzhnost_tb);
            this.Name = "Dolzhnosti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Должности";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dolzhnosti_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button poisk_btn;
        private System.Windows.Forms.TextBox stroka_poiska_tb;
        private System.Windows.Forms.Button menu_bt;
        private System.Windows.Forms.Button obnovit_btn;
        private System.Windows.Forms.Button izmenit_btn;
        private System.Windows.Forms.Button dobavit_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dolzhnost_tb;
    }
}