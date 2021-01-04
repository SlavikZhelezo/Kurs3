namespace Kurs3
{
    partial class OperatorQuery
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
            this.dataWindow = new System.Windows.Forms.DataGridView();
            this.driverButton = new System.Windows.Forms.Label();
            this.tarifButton = new System.Windows.Forms.Label();
            this.servicesButton = new System.Windows.Forms.Label();
            this.queryPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataWindow)).BeginInit();
            this.queryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataWindow
            // 
            this.dataWindow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataWindow.Location = new System.Drawing.Point(153, 12);
            this.dataWindow.Name = "dataWindow";
            this.dataWindow.Size = new System.Drawing.Size(479, 234);
            this.dataWindow.TabIndex = 29;
            // 
            // driverButton
            // 
            this.driverButton.AutoSize = true;
            this.driverButton.BackColor = System.Drawing.Color.Transparent;
            this.driverButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.driverButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.driverButton.ForeColor = System.Drawing.Color.White;
            this.driverButton.Location = new System.Drawing.Point(12, 98);
            this.driverButton.Name = "driverButton";
            this.driverButton.Size = new System.Drawing.Size(124, 29);
            this.driverButton.TabIndex = 33;
            this.driverButton.Text = "Водители";
            this.driverButton.Click += new System.EventHandler(this.driverButton_Click);
            // 
            // tarifButton
            // 
            this.tarifButton.AutoSize = true;
            this.tarifButton.BackColor = System.Drawing.Color.Transparent;
            this.tarifButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tarifButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tarifButton.ForeColor = System.Drawing.Color.White;
            this.tarifButton.Location = new System.Drawing.Point(12, 56);
            this.tarifButton.Name = "tarifButton";
            this.tarifButton.Size = new System.Drawing.Size(108, 29);
            this.tarifButton.TabIndex = 32;
            this.tarifButton.Text = "Тарифы";
            this.tarifButton.Click += new System.EventHandler(this.tarifButton_Click);
            // 
            // servicesButton
            // 
            this.servicesButton.AutoSize = true;
            this.servicesButton.BackColor = System.Drawing.Color.Transparent;
            this.servicesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.servicesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.servicesButton.ForeColor = System.Drawing.Color.White;
            this.servicesButton.Location = new System.Drawing.Point(12, 12);
            this.servicesButton.Name = "servicesButton";
            this.servicesButton.Size = new System.Drawing.Size(92, 29);
            this.servicesButton.TabIndex = 31;
            this.servicesButton.Text = "Услуги";
            this.servicesButton.Click += new System.EventHandler(this.servicesButton_Click);
            // 
            // queryPanel
            // 
            this.queryPanel.BackColor = System.Drawing.Color.Gray;
            this.queryPanel.Controls.Add(this.driverButton);
            this.queryPanel.Controls.Add(this.servicesButton);
            this.queryPanel.Controls.Add(this.tarifButton);
            this.queryPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.queryPanel.Location = new System.Drawing.Point(0, 0);
            this.queryPanel.Name = "queryPanel";
            this.queryPanel.Size = new System.Drawing.Size(147, 258);
            this.queryPanel.TabIndex = 34;
            // 
            // OperatorQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 258);
            this.Controls.Add(this.dataWindow);
            this.Controls.Add(this.queryPanel);
            this.Name = "OperatorQuery";
            this.Text = "Оператор";
            ((System.ComponentModel.ISupportInitialize)(this.dataWindow)).EndInit();
            this.queryPanel.ResumeLayout(false);
            this.queryPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataWindow;
        private System.Windows.Forms.Label driverButton;
        private System.Windows.Forms.Label tarifButton;
        private System.Windows.Forms.Label servicesButton;
        private System.Windows.Forms.Panel queryPanel;
    }
}