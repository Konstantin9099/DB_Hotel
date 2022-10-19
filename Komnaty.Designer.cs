
namespace DB_Hotel
{
    partial class Komnaty
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.komnata_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.etazh_tb = new System.Windows.Forms.TextBox();
            this.menu_bt = new System.Windows.Forms.Button();
            this.obnovit_btn = new System.Windows.Forms.Button();
            this.izmenit_btn = new System.Windows.Forms.Button();
            this.dobavit_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "№ комнаты:";
            // 
            // komnata_tb
            // 
            this.komnata_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.komnata_tb.Location = new System.Drawing.Point(23, 46);
            this.komnata_tb.Name = "komnata_tb";
            this.komnata_tb.Size = new System.Drawing.Size(110, 26);
            this.komnata_tb.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(154, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "этаж:";
            // 
            // etazh_tb
            // 
            this.etazh_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.etazh_tb.Location = new System.Drawing.Point(154, 46);
            this.etazh_tb.Name = "etazh_tb";
            this.etazh_tb.Size = new System.Drawing.Size(110, 26);
            this.etazh_tb.TabIndex = 16;
            // 
            // menu_bt
            // 
            this.menu_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.menu_bt.Location = new System.Drawing.Point(285, 44);
            this.menu_bt.Name = "menu_bt";
            this.menu_bt.Size = new System.Drawing.Size(110, 30);
            this.menu_bt.TabIndex = 49;
            this.menu_bt.Text = "Menu";
            this.menu_bt.UseVisualStyleBackColor = true;
            this.menu_bt.Click += new System.EventHandler(this.menu_bt_Click);
            // 
            // obnovit_btn
            // 
            this.obnovit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.obnovit_btn.Location = new System.Drawing.Point(285, 88);
            this.obnovit_btn.Name = "obnovit_btn";
            this.obnovit_btn.Size = new System.Drawing.Size(110, 38);
            this.obnovit_btn.TabIndex = 52;
            this.obnovit_btn.Text = "Обновить";
            this.obnovit_btn.UseVisualStyleBackColor = true;
            this.obnovit_btn.Click += new System.EventHandler(this.obnovit_btn_Click);
            // 
            // izmenit_btn
            // 
            this.izmenit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.izmenit_btn.Location = new System.Drawing.Point(154, 88);
            this.izmenit_btn.Name = "izmenit_btn";
            this.izmenit_btn.Size = new System.Drawing.Size(110, 38);
            this.izmenit_btn.TabIndex = 51;
            this.izmenit_btn.Text = "Изменить";
            this.izmenit_btn.UseVisualStyleBackColor = true;
            this.izmenit_btn.Click += new System.EventHandler(this.izmenit_btn_Click);
            // 
            // dobavit_btn
            // 
            this.dobavit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dobavit_btn.Location = new System.Drawing.Point(23, 88);
            this.dobavit_btn.Name = "dobavit_btn";
            this.dobavit_btn.Size = new System.Drawing.Size(110, 38);
            this.dobavit_btn.TabIndex = 50;
            this.dobavit_btn.Text = "Добавить";
            this.dobavit_btn.UseVisualStyleBackColor = true;
            this.dobavit_btn.Click += new System.EventHandler(this.dobavit_btn_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(27, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(368, 306);
            this.dataGridView1.TabIndex = 53;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Komnaty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.obnovit_btn);
            this.Controls.Add(this.izmenit_btn);
            this.Controls.Add(this.dobavit_btn);
            this.Controls.Add(this.menu_bt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.etazh_tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.komnata_tb);
            this.Name = "Komnaty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Комнаты";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Komnaty_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox komnata_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox etazh_tb;
        private System.Windows.Forms.Button menu_bt;
        private System.Windows.Forms.Button obnovit_btn;
        private System.Windows.Forms.Button izmenit_btn;
        private System.Windows.Forms.Button dobavit_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}