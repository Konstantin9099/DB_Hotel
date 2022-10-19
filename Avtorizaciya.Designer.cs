
namespace DB_Hotel
{
    partial class Avtorizaciya
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.vhod_btn = new System.Windows.Forms.Button();
            this.vyhod_btn = new System.Windows.Forms.Button();
            this.parol_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.login_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vhod_btn
            // 
            this.vhod_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.vhod_btn.Location = new System.Drawing.Point(230, 228);
            this.vhod_btn.Name = "vhod_btn";
            this.vhod_btn.Size = new System.Drawing.Size(103, 38);
            this.vhod_btn.TabIndex = 17;
            this.vhod_btn.Text = "Вход";
            this.vhod_btn.UseVisualStyleBackColor = true;
            this.vhod_btn.Click += new System.EventHandler(this.vhod_btn_Click);
            // 
            // vyhod_btn
            // 
            this.vyhod_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.vyhod_btn.Location = new System.Drawing.Point(75, 228);
            this.vyhod_btn.Name = "vyhod_btn";
            this.vyhod_btn.Size = new System.Drawing.Size(103, 38);
            this.vyhod_btn.TabIndex = 16;
            this.vyhod_btn.Text = "Выход";
            this.vyhod_btn.UseVisualStyleBackColor = true;
            this.vyhod_btn.Click += new System.EventHandler(this.vyhod_btn_Click);
            // 
            // parol_box
            // 
            this.parol_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.parol_box.Location = new System.Drawing.Point(70, 153);
            this.parol_box.Name = "parol_box";
            this.parol_box.PasswordChar = '*';
            this.parol_box.Size = new System.Drawing.Size(263, 30);
            this.parol_box.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(70, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Пароль";
            // 
            // login_box
            // 
            this.login_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.login_box.Location = new System.Drawing.Point(70, 61);
            this.login_box.Name = "login_box";
            this.login_box.PasswordChar = '*';
            this.login_box.Size = new System.Drawing.Size(263, 30);
            this.login_box.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(70, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Логин";
            // 
            // Avtorizaciya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 308);
            this.Controls.Add(this.vhod_btn);
            this.Controls.Add(this.vyhod_btn);
            this.Controls.Add(this.parol_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.login_box);
            this.Controls.Add(this.label1);
            this.Name = "Avtorizaciya";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button vhod_btn;
        private System.Windows.Forms.Button vyhod_btn;
        private System.Windows.Forms.TextBox parol_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox login_box;
        private System.Windows.Forms.Label label1;
    }
}

