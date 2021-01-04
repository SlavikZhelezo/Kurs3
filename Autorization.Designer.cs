namespace Kurs3
{
    partial class Autorization
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.autorizText = new System.Windows.Forms.Label();
            this.logText = new System.Windows.Forms.Label();
            this.passText = new System.Windows.Forms.Label();
            this.enterButton = new System.Windows.Forms.Button();
            this.loginField = new System.Windows.Forms.TextBox();
            this.passField = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.autorizText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 70);
            this.panel1.TabIndex = 0;
            // 
            // autorizText
            // 
            this.autorizText.AutoSize = true;
            this.autorizText.Font = new System.Drawing.Font("Microsoft Tai Le", 33F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.autorizText.ForeColor = System.Drawing.Color.White;
            this.autorizText.Location = new System.Drawing.Point(3, 9);
            this.autorizText.Name = "autorizText";
            this.autorizText.Size = new System.Drawing.Size(304, 51);
            this.autorizText.TabIndex = 6;
            this.autorizText.Text = "Авторизация";
            // 
            // logText
            // 
            this.logText.AutoSize = true;
            this.logText.BackColor = System.Drawing.Color.Gray;
            this.logText.Font = new System.Drawing.Font("Microsoft Tai Le", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logText.ForeColor = System.Drawing.Color.White;
            this.logText.Location = new System.Drawing.Point(24, 99);
            this.logText.Name = "logText";
            this.logText.Size = new System.Drawing.Size(89, 32);
            this.logText.TabIndex = 1;
            this.logText.Text = "Логин";
            // 
            // passText
            // 
            this.passText.AutoSize = true;
            this.passText.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passText.ForeColor = System.Drawing.Color.White;
            this.passText.Location = new System.Drawing.Point(-1, 163);
            this.passText.Name = "passText";
            this.passText.Size = new System.Drawing.Size(114, 32);
            this.passText.TabIndex = 2;
            this.passText.Text = "Пароль";
            // 
            // enterButton
            // 
            this.enterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterButton.Location = new System.Drawing.Point(77, 237);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(153, 50);
            this.enterButton.TabIndex = 3;
            this.enterButton.TabStop = false;
            this.enterButton.Text = "Вход";
            this.enterButton.UseVisualStyleBackColor = true;
            // 
            // loginField
            // 
            this.loginField.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.loginField.Location = new System.Drawing.Point(119, 96);
            this.loginField.Multiline = true;
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(183, 43);
            this.loginField.TabIndex = 4;
            // 
            // passField
            // 
            this.passField.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.passField.Location = new System.Drawing.Point(119, 160);
            this.passField.Multiline = true;
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(183, 43);
            this.passField.TabIndex = 5;
            // 
            // Autorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(314, 314);
            this.Controls.Add(this.passField);
            this.Controls.Add(this.loginField);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.passText);
            this.Controls.Add(this.logText);
            this.Controls.Add(this.panel1);
            this.Name = "Autorization";
            this.Text = "Авторизация";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label autorizText;
        private System.Windows.Forms.Label logText;
        private System.Windows.Forms.Label passText;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.TextBox passField;
    }
}

