
namespace DB_Hotel
{
    partial class Izmenit_komnata
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
            this.etazh_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.komnata_tb = new System.Windows.Forms.TextBox();
            this.sohranit_btn = new System.Windows.Forms.Button();
            this.nazad_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(155, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "этаж:";
            // 
            // etazh_tb
            // 
            this.etazh_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.etazh_tb.Location = new System.Drawing.Point(155, 54);
            this.etazh_tb.Name = "etazh_tb";
            this.etazh_tb.Size = new System.Drawing.Size(110, 26);
            this.etazh_tb.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "№ комнаты:";
            // 
            // komnata_tb
            // 
            this.komnata_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.komnata_tb.Location = new System.Drawing.Point(24, 54);
            this.komnata_tb.Name = "komnata_tb";
            this.komnata_tb.Size = new System.Drawing.Size(110, 26);
            this.komnata_tb.TabIndex = 18;
            // 
            // sohranit_btn
            // 
            this.sohranit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.sohranit_btn.Location = new System.Drawing.Point(283, 29);
            this.sohranit_btn.Name = "sohranit_btn";
            this.sohranit_btn.Size = new System.Drawing.Size(170, 51);
            this.sohranit_btn.TabIndex = 60;
            this.sohranit_btn.Text = "Сохранить";
            this.sohranit_btn.UseVisualStyleBackColor = true;
            this.sohranit_btn.Click += new System.EventHandler(this.sohranit_btn_Click);
            // 
            // nazad_btn
            // 
            this.nazad_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nazad_btn.Location = new System.Drawing.Point(474, 29);
            this.nazad_btn.Name = "nazad_btn";
            this.nazad_btn.Size = new System.Drawing.Size(170, 51);
            this.nazad_btn.TabIndex = 61;
            this.nazad_btn.Text = "Назад";
            this.nazad_btn.UseVisualStyleBackColor = true;
            this.nazad_btn.Click += new System.EventHandler(this.nazad_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 64;
            this.label3.Text = "ID";
            this.label3.Visible = false;
            // 
            // Izmenit_komnata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 113);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nazad_btn);
            this.Controls.Add(this.sohranit_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.etazh_tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.komnata_tb);
            this.Name = "Izmenit_komnata";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменить номер комнаты";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sohranit_btn;
        private System.Windows.Forms.Button nazad_btn;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox etazh_tb;
        public System.Windows.Forms.TextBox komnata_tb;
    }
}