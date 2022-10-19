
namespace DB_Hotel
{
    partial class Izmenit_gosti
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
            this.nazad_btn = new System.Windows.Forms.Button();
            this.sohranit_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.fio_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nazad_btn
            // 
            this.nazad_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nazad_btn.Location = new System.Drawing.Point(21, 101);
            this.nazad_btn.Name = "nazad_btn";
            this.nazad_btn.Size = new System.Drawing.Size(170, 37);
            this.nazad_btn.TabIndex = 60;
            this.nazad_btn.Text = "Назад";
            this.nazad_btn.UseVisualStyleBackColor = true;
            this.nazad_btn.Click += new System.EventHandler(this.nazad_btn_Click);
            // 
            // sohranit_btn
            // 
            this.sohranit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.sohranit_btn.Location = new System.Drawing.Point(236, 101);
            this.sohranit_btn.Name = "sohranit_btn";
            this.sohranit_btn.Size = new System.Drawing.Size(170, 37);
            this.sohranit_btn.TabIndex = 59;
            this.sohranit_btn.Text = "Сохранить";
            this.sohranit_btn.UseVisualStyleBackColor = true;
            this.sohranit_btn.Click += new System.EventHandler(this.sohranit_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(17, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 62;
            this.label2.Text = "ФИО:";
            // 
            // fio_tb
            // 
            this.fio_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fio_tb.Location = new System.Drawing.Point(21, 46);
            this.fio_tb.Name = "fio_tb";
            this.fio_tb.Size = new System.Drawing.Size(385, 26);
            this.fio_tb.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 141);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 63;
            this.label1.Text = "ID";
            this.label1.Visible = false;
            // 
            // Izmenit_gosti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 167);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fio_tb);
            this.Controls.Add(this.nazad_btn);
            this.Controls.Add(this.sohranit_btn);
            this.Name = "Izmenit_gosti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменить ФИО гостя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nazad_btn;
        private System.Windows.Forms.Button sohranit_btn;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox fio_tb;
    }
}