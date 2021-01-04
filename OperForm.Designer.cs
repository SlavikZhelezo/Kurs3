namespace Kurs3
{
    partial class OperMainForm
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
            this.phoneNumber = new System.Windows.Forms.Label();
            this.From = new System.Windows.Forms.Label();
            this.To = new System.Windows.Forms.Label();
            this.tariff = new System.Windows.Forms.Label();
            this.services = new System.Windows.Forms.Label();
            this.auto = new System.Windows.Forms.Label();
            this.phoneField = new System.Windows.Forms.TextBox();
            this.whereField = new System.Windows.Forms.TextBox();
            this.toField = new System.Windows.Forms.TextBox();
            this.tarifField = new System.Windows.Forms.TextBox();
            this.serviceField = new System.Windows.Forms.TextBox();
            this.autoField = new System.Windows.Forms.TextBox();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.queryButton = new System.Windows.Forms.Label();
            this.orderPay = new System.Windows.Forms.Button();
            this.MenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // phoneNumber
            // 
            this.phoneNumber.AutoSize = true;
            this.phoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneNumber.Location = new System.Drawing.Point(40, 16);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(79, 20);
            this.phoneNumber.TabIndex = 1;
            this.phoneNumber.Text = "Телефон";
            // 
            // From
            // 
            this.From.AutoSize = true;
            this.From.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.From.Location = new System.Drawing.Point(54, 46);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(65, 20);
            this.From.TabIndex = 2;
            this.From.Text = "Откуда";
            // 
            // To
            // 
            this.To.AutoSize = true;
            this.To.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.To.Location = new System.Drawing.Point(73, 76);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(46, 20);
            this.To.TabIndex = 3;
            this.To.Text = "Куда";
            // 
            // tariff
            // 
            this.tariff.AutoSize = true;
            this.tariff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tariff.Location = new System.Drawing.Point(59, 106);
            this.tariff.Name = "tariff";
            this.tariff.Size = new System.Drawing.Size(60, 20);
            this.tariff.TabIndex = 4;
            this.tariff.Text = "Тариф";
            this.tariff.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // services
            // 
            this.services.AutoSize = true;
            this.services.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.services.Location = new System.Drawing.Point(59, 136);
            this.services.Name = "services";
            this.services.Size = new System.Drawing.Size(60, 20);
            this.services.TabIndex = 5;
            this.services.Text = "Услуги";
            // 
            // auto
            // 
            this.auto.AutoSize = true;
            this.auto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.auto.Location = new System.Drawing.Point(72, 166);
            this.auto.Name = "auto";
            this.auto.Size = new System.Drawing.Size(47, 20);
            this.auto.TabIndex = 6;
            this.auto.Text = "Авто";
            // 
            // phoneField
            // 
            this.phoneField.Location = new System.Drawing.Point(140, 16);
            this.phoneField.Name = "phoneField";
            this.phoneField.Size = new System.Drawing.Size(157, 20);
            this.phoneField.TabIndex = 8;
            // 
            // whereField
            // 
            this.whereField.Location = new System.Drawing.Point(140, 46);
            this.whereField.Name = "whereField";
            this.whereField.Size = new System.Drawing.Size(259, 20);
            this.whereField.TabIndex = 9;
            // 
            // toField
            // 
            this.toField.Location = new System.Drawing.Point(140, 76);
            this.toField.Name = "toField";
            this.toField.Size = new System.Drawing.Size(259, 20);
            this.toField.TabIndex = 10;
            // 
            // tarifField
            // 
            this.tarifField.Location = new System.Drawing.Point(140, 106);
            this.tarifField.Name = "tarifField";
            this.tarifField.Size = new System.Drawing.Size(71, 20);
            this.tarifField.TabIndex = 11;
            // 
            // serviceField
            // 
            this.serviceField.Location = new System.Drawing.Point(140, 136);
            this.serviceField.Name = "serviceField";
            this.serviceField.Size = new System.Drawing.Size(71, 20);
            this.serviceField.TabIndex = 12;
            // 
            // autoField
            // 
            this.autoField.Location = new System.Drawing.Point(140, 166);
            this.autoField.Name = "autoField";
            this.autoField.Size = new System.Drawing.Size(71, 20);
            this.autoField.TabIndex = 13;
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.MenuPanel.Controls.Add(this.queryButton);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.MenuPanel.Location = new System.Drawing.Point(470, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(200, 255);
            this.MenuPanel.TabIndex = 14;
            // 
            // queryButton
            // 
            this.queryButton.AutoSize = true;
            this.queryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.queryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.queryButton.ForeColor = System.Drawing.Color.White;
            this.queryButton.Location = new System.Drawing.Point(22, 10);
            this.queryButton.Name = "queryButton";
            this.queryButton.Size = new System.Drawing.Size(92, 25);
            this.queryButton.TabIndex = 5;
            this.queryButton.Text = "Запросы";
            this.queryButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // orderPay
            // 
            this.orderPay.BackColor = System.Drawing.Color.Gray;
            this.orderPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderPay.ForeColor = System.Drawing.Color.White;
            this.orderPay.Location = new System.Drawing.Point(272, 205);
            this.orderPay.Name = "orderPay";
            this.orderPay.Size = new System.Drawing.Size(179, 38);
            this.orderPay.TabIndex = 15;
            this.orderPay.Text = "Оформить заказ";
            this.orderPay.UseVisualStyleBackColor = false;
            this.orderPay.Click += new System.EventHandler(this.orderPay_Click);
            // 
            // OperMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 255);
            this.Controls.Add(this.orderPay);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.autoField);
            this.Controls.Add(this.serviceField);
            this.Controls.Add(this.tarifField);
            this.Controls.Add(this.toField);
            this.Controls.Add(this.whereField);
            this.Controls.Add(this.phoneField);
            this.Controls.Add(this.auto);
            this.Controls.Add(this.services);
            this.Controls.Add(this.tariff);
            this.Controls.Add(this.To);
            this.Controls.Add(this.From);
            this.Controls.Add(this.phoneNumber);
            this.Name = "OperMainForm";
            this.Text = "Оператор";
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label phoneNumber;
        private System.Windows.Forms.Label From;
        private System.Windows.Forms.Label To;
        private System.Windows.Forms.Label tariff;
        private System.Windows.Forms.Label services;
        private System.Windows.Forms.Label auto;
        private System.Windows.Forms.TextBox phoneField;
        private System.Windows.Forms.TextBox whereField;
        private System.Windows.Forms.TextBox toField;
        private System.Windows.Forms.TextBox tarifField;
        private System.Windows.Forms.TextBox serviceField;
        private System.Windows.Forms.TextBox autoField;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Label queryButton;
        private System.Windows.Forms.Button orderPay;
    }
}