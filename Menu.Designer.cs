
namespace DB_Hotel
{
    partial class Menu
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
            this.dolzhnost_btn = new System.Windows.Forms.Button();
            this.gosti_btn = new System.Windows.Forms.Button();
            this.komnaty_btn = new System.Windows.Forms.Button();
            this.personal_btn = new System.Windows.Forms.Button();
            this.registraciya_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dolzhnost_btn
            // 
            this.dolzhnost_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dolzhnost_btn.Location = new System.Drawing.Point(47, 298);
            this.dolzhnost_btn.Name = "dolzhnost_btn";
            this.dolzhnost_btn.Size = new System.Drawing.Size(190, 50);
            this.dolzhnost_btn.TabIndex = 9;
            this.dolzhnost_btn.Text = "Должности";
            this.dolzhnost_btn.UseVisualStyleBackColor = true;
            this.dolzhnost_btn.Click += new System.EventHandler(this.dolzhnost_btn_Click);
            // 
            // gosti_btn
            // 
            this.gosti_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gosti_btn.Location = new System.Drawing.Point(47, 30);
            this.gosti_btn.Name = "gosti_btn";
            this.gosti_btn.Size = new System.Drawing.Size(190, 50);
            this.gosti_btn.TabIndex = 8;
            this.gosti_btn.Text = "Гости";
            this.gosti_btn.UseVisualStyleBackColor = true;
            this.gosti_btn.Click += new System.EventHandler(this.gosti_btn_Click);
            // 
            // komnaty_btn
            // 
            this.komnaty_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.komnaty_btn.Location = new System.Drawing.Point(47, 97);
            this.komnaty_btn.Name = "komnaty_btn";
            this.komnaty_btn.Size = new System.Drawing.Size(190, 50);
            this.komnaty_btn.TabIndex = 7;
            this.komnaty_btn.Text = "Комнаты";
            this.komnaty_btn.UseVisualStyleBackColor = true;
            this.komnaty_btn.Click += new System.EventHandler(this.komnaty_btn_Click);
            // 
            // personal_btn
            // 
            this.personal_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.personal_btn.Location = new System.Drawing.Point(47, 231);
            this.personal_btn.Name = "personal_btn";
            this.personal_btn.Size = new System.Drawing.Size(190, 50);
            this.personal_btn.TabIndex = 6;
            this.personal_btn.Text = "Персонал";
            this.personal_btn.UseVisualStyleBackColor = true;
            this.personal_btn.Click += new System.EventHandler(this.personal_btn_Click);
            // 
            // registraciya_btn
            // 
            this.registraciya_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.registraciya_btn.Location = new System.Drawing.Point(47, 164);
            this.registraciya_btn.Name = "registraciya_btn";
            this.registraciya_btn.Size = new System.Drawing.Size(190, 50);
            this.registraciya_btn.TabIndex = 5;
            this.registraciya_btn.Text = "Регистрация";
            this.registraciya_btn.UseVisualStyleBackColor = true;
            this.registraciya_btn.Click += new System.EventHandler(this.registraciya_btn_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 375);
            this.Controls.Add(this.dolzhnost_btn);
            this.Controls.Add(this.gosti_btn);
            this.Controls.Add(this.komnaty_btn);
            this.Controls.Add(this.personal_btn);
            this.Controls.Add(this.registraciya_btn);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dolzhnost_btn;
        private System.Windows.Forms.Button gosti_btn;
        private System.Windows.Forms.Button komnaty_btn;
        private System.Windows.Forms.Button personal_btn;
        private System.Windows.Forms.Button registraciya_btn;
    }
}