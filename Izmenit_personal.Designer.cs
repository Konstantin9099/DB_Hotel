
namespace DB_Hotel
{
    partial class Izmenit_personal
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
            this.label2 = new System.Windows.Forms.Label();
            this.dolzhnost_cmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fio_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nazad_btn = new System.Windows.Forms.Button();
            this.sohranit_btn = new System.Windows.Forms.Button();
            this.id_dolz_lb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 20);
            this.label2.TabIndex = 61;
            this.label2.Text = "Наименование должности:";
            // 
            // dolzhnost_cmb
            // 
            this.dolzhnost_cmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dolzhnost_cmb.FormattingEnabled = true;
            this.dolzhnost_cmb.Location = new System.Drawing.Point(12, 99);
            this.dolzhnost_cmb.Name = "dolzhnost_cmb";
            this.dolzhnost_cmb.Size = new System.Drawing.Size(385, 28);
            this.dolzhnost_cmb.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 59;
            this.label1.Text = "ФИО сотрудника:";
            // 
            // fio_tb
            // 
            this.fio_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fio_tb.Location = new System.Drawing.Point(12, 37);
            this.fio_tb.Name = "fio_tb";
            this.fio_tb.Size = new System.Drawing.Size(385, 26);
            this.fio_tb.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 183);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 66;
            this.label3.Text = "ID";
            this.label3.Visible = false;
            // 
            // nazad_btn
            // 
            this.nazad_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nazad_btn.Location = new System.Drawing.Point(12, 143);
            this.nazad_btn.Name = "nazad_btn";
            this.nazad_btn.Size = new System.Drawing.Size(170, 37);
            this.nazad_btn.TabIndex = 65;
            this.nazad_btn.Text = "Назад";
            this.nazad_btn.UseVisualStyleBackColor = true;
            this.nazad_btn.Click += new System.EventHandler(this.nazad_btn_Click);
            // 
            // sohranit_btn
            // 
            this.sohranit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.sohranit_btn.Location = new System.Drawing.Point(227, 143);
            this.sohranit_btn.Name = "sohranit_btn";
            this.sohranit_btn.Size = new System.Drawing.Size(170, 37);
            this.sohranit_btn.TabIndex = 64;
            this.sohranit_btn.Text = "Сохранить";
            this.sohranit_btn.UseVisualStyleBackColor = true;
            this.sohranit_btn.Click += new System.EventHandler(this.sohranit_btn_Click);
            // 
            // id_dolz_lb
            // 
            this.id_dolz_lb.AutoSize = true;
            this.id_dolz_lb.Location = new System.Drawing.Point(346, 71);
            this.id_dolz_lb.Name = "id_dolz_lb";
            this.id_dolz_lb.Size = new System.Drawing.Size(53, 17);
            this.id_dolz_lb.TabIndex = 78;
            this.id_dolz_lb.Text = "id_dolz";
            this.id_dolz_lb.Visible = false;
            // 
            // Izmenit_personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 205);
            this.Controls.Add(this.id_dolz_lb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nazad_btn);
            this.Controls.Add(this.sohranit_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dolzhnost_cmb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fio_tb);
            this.Name = "Izmenit_personal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменить данные сотрудника";
            this.Load += new System.EventHandler(this.Izmenit_personal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button nazad_btn;
        private System.Windows.Forms.Button sohranit_btn;
        public System.Windows.Forms.ComboBox dolzhnost_cmb;
        public System.Windows.Forms.TextBox fio_tb;
        public System.Windows.Forms.Label id_dolz_lb;
    }
}