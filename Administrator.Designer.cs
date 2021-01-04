namespace Kurs3
{
    partial class Administrator
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
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.serviceButton = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.Label();
            this.windowofdate = new System.Windows.Forms.DataGridView();
            this.queryPanel = new System.Windows.Forms.Panel();
            this.tarifQuery = new System.Windows.Forms.Label();
            this.staffQuery = new System.Windows.Forms.Label();
            this.serviceQuery = new System.Windows.Forms.Label();
            this.callQuery = new System.Windows.Forms.Label();
            this.autoQuery = new System.Windows.Forms.Label();
            this.queryButton = new System.Windows.Forms.Label();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windowofdate)).BeginInit();
            this.queryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.MenuPanel.Controls.Add(this.queryPanel);
            this.MenuPanel.Controls.Add(this.serviceButton);
            this.MenuPanel.Controls.Add(this.Menu);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.MenuPanel.Location = new System.Drawing.Point(600, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(200, 450);
            this.MenuPanel.TabIndex = 15;
            // 
            // serviceButton
            // 
            this.serviceButton.AutoSize = true;
            this.serviceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.serviceButton.ForeColor = System.Drawing.Color.White;
            this.serviceButton.Location = new System.Drawing.Point(36, 52);
            this.serviceButton.Name = "serviceButton";
            this.serviceButton.Size = new System.Drawing.Size(161, 24);
            this.serviceButton.TabIndex = 19;
            this.serviceButton.Text = "Редактирование";
            this.serviceButton.Click += new System.EventHandler(this.serviceButton_Click);
            // 
            // Menu
            // 
            this.Menu.AutoSize = true;
            this.Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Underline);
            this.Menu.ForeColor = System.Drawing.Color.White;
            this.Menu.Location = new System.Drawing.Point(26, 13);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(79, 29);
            this.Menu.TabIndex = 16;
            this.Menu.Text = "Меню";
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // windowofdate
            // 
            this.windowofdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.windowofdate.Location = new System.Drawing.Point(13, 13);
            this.windowofdate.Name = "windowofdate";
            this.windowofdate.Size = new System.Drawing.Size(581, 425);
            this.windowofdate.TabIndex = 16;
            // 
            // queryPanel
            // 
            this.queryPanel.Controls.Add(this.tarifQuery);
            this.queryPanel.Controls.Add(this.staffQuery);
            this.queryPanel.Controls.Add(this.serviceQuery);
            this.queryPanel.Controls.Add(this.callQuery);
            this.queryPanel.Controls.Add(this.autoQuery);
            this.queryPanel.Controls.Add(this.queryButton);
            this.queryPanel.Location = new System.Drawing.Point(0, 122);
            this.queryPanel.Name = "queryPanel";
            this.queryPanel.Size = new System.Drawing.Size(200, 328);
            this.queryPanel.TabIndex = 28;
            // 
            // tarifQuery
            // 
            this.tarifQuery.AutoSize = true;
            this.tarifQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tarifQuery.ForeColor = System.Drawing.Color.White;
            this.tarifQuery.Location = new System.Drawing.Point(50, 131);
            this.tarifQuery.Name = "tarifQuery";
            this.tarifQuery.Size = new System.Drawing.Size(81, 24);
            this.tarifQuery.TabIndex = 33;
            this.tarifQuery.Text = "Тарифы";
            this.tarifQuery.Click += new System.EventHandler(this.tarifQuery_Click);
            // 
            // staffQuery
            // 
            this.staffQuery.AutoSize = true;
            this.staffQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.staffQuery.ForeColor = System.Drawing.Color.White;
            this.staffQuery.Location = new System.Drawing.Point(50, 107);
            this.staffQuery.Name = "staffQuery";
            this.staffQuery.Size = new System.Drawing.Size(118, 24);
            this.staffQuery.TabIndex = 32;
            this.staffQuery.Text = "Сотрудники";
            this.staffQuery.Click += new System.EventHandler(this.staffQuery_Click);
            // 
            // serviceQuery
            // 
            this.serviceQuery.AutoSize = true;
            this.serviceQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.serviceQuery.ForeColor = System.Drawing.Color.White;
            this.serviceQuery.Location = new System.Drawing.Point(50, 83);
            this.serviceQuery.Name = "serviceQuery";
            this.serviceQuery.Size = new System.Drawing.Size(71, 24);
            this.serviceQuery.TabIndex = 31;
            this.serviceQuery.Text = "Услуги";
            this.serviceQuery.Click += new System.EventHandler(this.serviceQuery_Click);
            // 
            // callQuery
            // 
            this.callQuery.AutoSize = true;
            this.callQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.callQuery.ForeColor = System.Drawing.Color.White;
            this.callQuery.Location = new System.Drawing.Point(50, 59);
            this.callQuery.Name = "callQuery";
            this.callQuery.Size = new System.Drawing.Size(75, 24);
            this.callQuery.TabIndex = 30;
            this.callQuery.Text = "Заказы";
            this.callQuery.Click += new System.EventHandler(this.callQuery_Click);
            // 
            // autoQuery
            // 
            this.autoQuery.AutoSize = true;
            this.autoQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.autoQuery.ForeColor = System.Drawing.Color.White;
            this.autoQuery.Location = new System.Drawing.Point(50, 35);
            this.autoQuery.Name = "autoQuery";
            this.autoQuery.Size = new System.Drawing.Size(55, 24);
            this.autoQuery.TabIndex = 29;
            this.autoQuery.Text = "Авто";
            this.autoQuery.Click += new System.EventHandler(this.autoQuery_Click);
            // 
            // queryButton
            // 
            this.queryButton.AutoSize = true;
            this.queryButton.BackColor = System.Drawing.Color.Transparent;
            this.queryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Underline);
            this.queryButton.ForeColor = System.Drawing.Color.White;
            this.queryButton.Location = new System.Drawing.Point(26, 0);
            this.queryButton.Name = "queryButton";
            this.queryButton.Size = new System.Drawing.Size(112, 29);
            this.queryButton.TabIndex = 28;
            this.queryButton.Text = "Запросы";
            this.queryButton.Click += new System.EventHandler(this.queryButton_Click_1);
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.windowofdate);
            this.Controls.Add(this.MenuPanel);
            this.Name = "Administrator";
            this.Text = "Administrator";
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windowofdate)).EndInit();
            this.queryPanel.ResumeLayout(false);
            this.queryPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Label serviceButton;
        private System.Windows.Forms.Label Menu;
        private System.Windows.Forms.DataGridView windowofdate;
        private System.Windows.Forms.Panel queryPanel;
        private System.Windows.Forms.Label tarifQuery;
        private System.Windows.Forms.Label staffQuery;
        private System.Windows.Forms.Label serviceQuery;
        private System.Windows.Forms.Label callQuery;
        private System.Windows.Forms.Label autoQuery;
        private System.Windows.Forms.Label queryButton;
    }
}