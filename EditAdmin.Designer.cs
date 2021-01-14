namespace Kurs3
{
    partial class EditAdmin
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
            this.tarifButton = new System.Windows.Forms.Label();
            this.staffButton = new System.Windows.Forms.Label();
            this.serviceButton = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.Label();
            this.dataPanel = new System.Windows.Forms.Panel();
            this.addStaff = new System.Windows.Forms.Panel();
            this.passportBox = new System.Windows.Forms.TextBox();
            this.passportStaff = new System.Windows.Forms.Label();
            this.idPosition = new System.Windows.Forms.Label();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.phoneStaff = new System.Windows.Forms.Label();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.adresStaff = new System.Windows.Forms.Label();
            this.addStaffButton = new System.Windows.Forms.Button();
            this.idStaff = new System.Windows.Forms.Label();
            this.idStaffBox = new System.Windows.Forms.TextBox();
            this.genderStaff = new System.Windows.Forms.Label();
            this.nameStaff = new System.Windows.Forms.Label();
            this.ageBox = new System.Windows.Forms.TextBox();
            this.fioBox = new System.Windows.Forms.TextBox();
            this.ageStaff = new System.Windows.Forms.Label();
            this.addPanel = new System.Windows.Forms.Panel();
            this.costBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.idService = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.cost = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.descripBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.Label();
            this.genderCombo = new System.Windows.Forms.ComboBox();
            this.positionCombo = new System.Windows.Forms.ComboBox();
            this.tariffPanel = new System.Windows.Forms.Panel();
            this.idTariff = new System.Windows.Forms.Label();
            this.idTarifBox = new System.Windows.Forms.TextBox();
            this.nameTarifBox = new System.Windows.Forms.TextBox();
            this.nameTarif = new System.Windows.Forms.Label();
            this.descTarifBox = new System.Windows.Forms.TextBox();
            this.descTarif = new System.Windows.Forms.Label();
            this.costTariifBox = new System.Windows.Forms.TextBox();
            this.costTarif = new System.Windows.Forms.Label();
            this.addTarifButton = new System.Windows.Forms.Button();
            this.MenuPanel.SuspendLayout();
            this.dataPanel.SuspendLayout();
            this.addStaff.SuspendLayout();
            this.addPanel.SuspendLayout();
            this.tariffPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.MenuPanel.Controls.Add(this.tarifButton);
            this.MenuPanel.Controls.Add(this.staffButton);
            this.MenuPanel.Controls.Add(this.serviceButton);
            this.MenuPanel.Controls.Add(this.Menu);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.MenuPanel.Location = new System.Drawing.Point(600, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(200, 450);
            this.MenuPanel.TabIndex = 17;
            // 
            // tarifButton
            // 
            this.tarifButton.AutoSize = true;
            this.tarifButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tarifButton.ForeColor = System.Drawing.Color.White;
            this.tarifButton.Location = new System.Drawing.Point(50, 95);
            this.tarifButton.Name = "tarifButton";
            this.tarifButton.Size = new System.Drawing.Size(81, 24);
            this.tarifButton.TabIndex = 21;
            this.tarifButton.Text = "Тарифы";
            this.tarifButton.Click += new System.EventHandler(this.tarifButton_Click);
            // 
            // staffButton
            // 
            this.staffButton.AutoSize = true;
            this.staffButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.staffButton.ForeColor = System.Drawing.Color.White;
            this.staffButton.Location = new System.Drawing.Point(50, 71);
            this.staffButton.Name = "staffButton";
            this.staffButton.Size = new System.Drawing.Size(118, 24);
            this.staffButton.TabIndex = 20;
            this.staffButton.Text = "Сотрудники";
            this.staffButton.Click += new System.EventHandler(this.staffButton_Click);
            // 
            // serviceButton
            // 
            this.serviceButton.AutoSize = true;
            this.serviceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.serviceButton.ForeColor = System.Drawing.Color.White;
            this.serviceButton.Location = new System.Drawing.Point(50, 47);
            this.serviceButton.Name = "serviceButton";
            this.serviceButton.Size = new System.Drawing.Size(71, 24);
            this.serviceButton.TabIndex = 19;
            this.serviceButton.Text = "Услуги";
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
            // 
            // dataPanel
            // 
            this.dataPanel.Controls.Add(this.tariffPanel);
            this.dataPanel.Controls.Add(this.addStaff);
            this.dataPanel.Controls.Add(this.addPanel);
            this.dataPanel.Location = new System.Drawing.Point(12, 71);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(582, 367);
            this.dataPanel.TabIndex = 18;
            // 
            // addStaff
            // 
            this.addStaff.Controls.Add(this.positionCombo);
            this.addStaff.Controls.Add(this.genderCombo);
            this.addStaff.Controls.Add(this.passportBox);
            this.addStaff.Controls.Add(this.passportStaff);
            this.addStaff.Controls.Add(this.idPosition);
            this.addStaff.Controls.Add(this.phoneBox);
            this.addStaff.Controls.Add(this.phoneStaff);
            this.addStaff.Controls.Add(this.addressBox);
            this.addStaff.Controls.Add(this.adresStaff);
            this.addStaff.Controls.Add(this.addStaffButton);
            this.addStaff.Controls.Add(this.idStaff);
            this.addStaff.Controls.Add(this.idStaffBox);
            this.addStaff.Controls.Add(this.genderStaff);
            this.addStaff.Controls.Add(this.nameStaff);
            this.addStaff.Controls.Add(this.ageBox);
            this.addStaff.Controls.Add(this.fioBox);
            this.addStaff.Controls.Add(this.ageStaff);
            this.addStaff.Location = new System.Drawing.Point(15, 15);
            this.addStaff.Name = "addStaff";
            this.addStaff.Size = new System.Drawing.Size(545, 335);
            this.addStaff.TabIndex = 10;
            // 
            // passportBox
            // 
            this.passportBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.passportBox.Location = new System.Drawing.Point(117, 223);
            this.passportBox.Name = "passportBox";
            this.passportBox.Size = new System.Drawing.Size(378, 27);
            this.passportBox.TabIndex = 16;
            // 
            // passportStaff
            // 
            this.passportStaff.AutoSize = true;
            this.passportStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.passportStaff.Location = new System.Drawing.Point(20, 226);
            this.passportStaff.Name = "passportStaff";
            this.passportStaff.Size = new System.Drawing.Size(80, 22);
            this.passportStaff.TabIndex = 15;
            this.passportStaff.Text = "Паспорт";
            // 
            // idPosition
            // 
            this.idPosition.AutoSize = true;
            this.idPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.idPosition.Location = new System.Drawing.Point(276, 60);
            this.idPosition.Name = "idPosition";
            this.idPosition.Size = new System.Drawing.Size(104, 22);
            this.idPosition.TabIndex = 13;
            this.idPosition.Text = "Должность";
            // 
            // phoneBox
            // 
            this.phoneBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.phoneBox.Location = new System.Drawing.Point(395, 13);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(100, 27);
            this.phoneBox.TabIndex = 12;
            // 
            // phoneStaff
            // 
            this.phoneStaff.AutoSize = true;
            this.phoneStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.phoneStaff.Location = new System.Drawing.Point(276, 16);
            this.phoneStaff.Name = "phoneStaff";
            this.phoneStaff.Size = new System.Drawing.Size(86, 22);
            this.phoneStaff.TabIndex = 11;
            this.phoneStaff.Text = "Телефон";
            // 
            // addressBox
            // 
            this.addressBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.addressBox.Location = new System.Drawing.Point(117, 190);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(378, 27);
            this.addressBox.TabIndex = 10;
            // 
            // adresStaff
            // 
            this.adresStaff.AutoSize = true;
            this.adresStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.adresStaff.Location = new System.Drawing.Point(20, 193);
            this.adresStaff.Name = "adresStaff";
            this.adresStaff.Size = new System.Drawing.Size(62, 22);
            this.adresStaff.TabIndex = 9;
            this.adresStaff.Text = "Адрес";
            // 
            // addStaffButton
            // 
            this.addStaffButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.addStaffButton.Location = new System.Drawing.Point(327, 277);
            this.addStaffButton.Name = "addStaffButton";
            this.addStaffButton.Size = new System.Drawing.Size(152, 43);
            this.addStaffButton.TabIndex = 8;
            this.addStaffButton.Text = "Добавить";
            this.addStaffButton.UseVisualStyleBackColor = true;
            this.addStaffButton.Click += new System.EventHandler(this.addStaffButton_Click);
            // 
            // idStaff
            // 
            this.idStaff.AutoSize = true;
            this.idStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.idStaff.Location = new System.Drawing.Point(17, 15);
            this.idStaff.Name = "idStaff";
            this.idStaff.Size = new System.Drawing.Size(137, 22);
            this.idStaff.TabIndex = 0;
            this.idStaff.Text = "ID  Сотрудника";
            // 
            // idStaffBox
            // 
            this.idStaffBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.idStaffBox.Location = new System.Drawing.Point(160, 13);
            this.idStaffBox.Name = "idStaffBox";
            this.idStaffBox.Size = new System.Drawing.Size(100, 27);
            this.idStaffBox.TabIndex = 1;
            // 
            // genderStaff
            // 
            this.genderStaff.AutoSize = true;
            this.genderStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.genderStaff.Location = new System.Drawing.Point(21, 106);
            this.genderStaff.Name = "genderStaff";
            this.genderStaff.Size = new System.Drawing.Size(43, 22);
            this.genderStaff.TabIndex = 6;
            this.genderStaff.Text = "Пол";
            // 
            // nameStaff
            // 
            this.nameStaff.AutoSize = true;
            this.nameStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.nameStaff.Location = new System.Drawing.Point(21, 155);
            this.nameStaff.Name = "nameStaff";
            this.nameStaff.Size = new System.Drawing.Size(52, 22);
            this.nameStaff.TabIndex = 2;
            this.nameStaff.Text = "ФИО";
            // 
            // ageBox
            // 
            this.ageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.ageBox.Location = new System.Drawing.Point(160, 60);
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(100, 27);
            this.ageBox.TabIndex = 5;
            // 
            // fioBox
            // 
            this.fioBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.fioBox.Location = new System.Drawing.Point(117, 152);
            this.fioBox.Name = "fioBox";
            this.fioBox.Size = new System.Drawing.Size(378, 27);
            this.fioBox.TabIndex = 3;
            // 
            // ageStaff
            // 
            this.ageStaff.AutoSize = true;
            this.ageStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.ageStaff.Location = new System.Drawing.Point(17, 63);
            this.ageStaff.Name = "ageStaff";
            this.ageStaff.Size = new System.Drawing.Size(78, 22);
            this.ageStaff.TabIndex = 4;
            this.ageStaff.Text = "Возраст";
            // 
            // addPanel
            // 
            this.addPanel.Controls.Add(this.costBox);
            this.addPanel.Controls.Add(this.addButton);
            this.addPanel.Controls.Add(this.idService);
            this.addPanel.Controls.Add(this.idBox);
            this.addPanel.Controls.Add(this.cost);
            this.addPanel.Controls.Add(this.name);
            this.addPanel.Controls.Add(this.descripBox);
            this.addPanel.Controls.Add(this.nameBox);
            this.addPanel.Controls.Add(this.description);
            this.addPanel.Location = new System.Drawing.Point(15, 24);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(310, 251);
            this.addPanel.TabIndex = 9;
            // 
            // costBox
            // 
            this.costBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.costBox.Location = new System.Drawing.Point(116, 148);
            this.costBox.Name = "costBox";
            this.costBox.Size = new System.Drawing.Size(100, 27);
            this.costBox.TabIndex = 7;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.addButton.Location = new System.Drawing.Point(143, 195);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(152, 43);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // idService
            // 
            this.idService.AutoSize = true;
            this.idService.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.idService.Location = new System.Drawing.Point(17, 15);
            this.idService.Name = "idService";
            this.idService.Size = new System.Drawing.Size(94, 22);
            this.idService.TabIndex = 0;
            this.idService.Text = "ID  Услуги";
            // 
            // idBox
            // 
            this.idBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.idBox.Location = new System.Drawing.Point(117, 12);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(100, 27);
            this.idBox.TabIndex = 1;
            // 
            // cost
            // 
            this.cost.AutoSize = true;
            this.cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cost.Location = new System.Drawing.Point(17, 151);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(53, 22);
            this.cost.TabIndex = 6;
            this.cost.Text = "Цена";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.name.Location = new System.Drawing.Point(17, 60);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(92, 22);
            this.name.TabIndex = 2;
            this.name.Text = "Название";
            // 
            // descripBox
            // 
            this.descripBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.descripBox.Location = new System.Drawing.Point(117, 106);
            this.descripBox.Name = "descripBox";
            this.descripBox.Size = new System.Drawing.Size(100, 27);
            this.descripBox.TabIndex = 5;
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.nameBox.Location = new System.Drawing.Point(117, 60);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 27);
            this.nameBox.TabIndex = 3;
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.description.Location = new System.Drawing.Point(17, 106);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(93, 22);
            this.description.TabIndex = 4;
            this.description.Text = "Описание";
            // 
            // genderCombo
            // 
            this.genderCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.genderCombo.FormattingEnabled = true;
            this.genderCombo.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.genderCombo.Location = new System.Drawing.Point(160, 108);
            this.genderCombo.Name = "genderCombo";
            this.genderCombo.Size = new System.Drawing.Size(100, 28);
            this.genderCombo.TabIndex = 17;
            this.genderCombo.SelectedIndexChanged += new System.EventHandler(this.genderCombo_SelectedIndexChanged);
            // 
            // positionCombo
            // 
            this.positionCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.positionCombo.FormattingEnabled = true;
            this.positionCombo.Items.AddRange(new object[] {
            "Диспетчер",
            "Водитель",
            "Механик",
            "Уборщица",
            "Охранник"});
            this.positionCombo.Location = new System.Drawing.Point(395, 62);
            this.positionCombo.Name = "positionCombo";
            this.positionCombo.Size = new System.Drawing.Size(100, 28);
            this.positionCombo.TabIndex = 18;
            this.positionCombo.SelectedIndexChanged += new System.EventHandler(this.positionCombo_SelectedIndexChanged);
            // 
            // tariffPanel
            // 
            this.tariffPanel.Controls.Add(this.addTarifButton);
            this.tariffPanel.Controls.Add(this.costTariifBox);
            this.tariffPanel.Controls.Add(this.costTarif);
            this.tariffPanel.Controls.Add(this.descTarifBox);
            this.tariffPanel.Controls.Add(this.descTarif);
            this.tariffPanel.Controls.Add(this.nameTarifBox);
            this.tariffPanel.Controls.Add(this.nameTarif);
            this.tariffPanel.Controls.Add(this.idTarifBox);
            this.tariffPanel.Controls.Add(this.idTariff);
            this.tariffPanel.Location = new System.Drawing.Point(3, 3);
            this.tariffPanel.Name = "tariffPanel";
            this.tariffPanel.Size = new System.Drawing.Size(401, 361);
            this.tariffPanel.TabIndex = 11;
            // 
            // idTariff
            // 
            this.idTariff.AutoSize = true;
            this.idTariff.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.idTariff.Location = new System.Drawing.Point(12, 21);
            this.idTariff.Name = "idTariff";
            this.idTariff.Size = new System.Drawing.Size(98, 22);
            this.idTariff.TabIndex = 0;
            this.idTariff.Text = "ID Тарифа";
            // 
            // idTarifBox
            // 
            this.idTarifBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.idTarifBox.Location = new System.Drawing.Point(116, 18);
            this.idTarifBox.Name = "idTarifBox";
            this.idTarifBox.Size = new System.Drawing.Size(100, 27);
            this.idTarifBox.TabIndex = 1;
            // 
            // nameTarifBox
            // 
            this.nameTarifBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.nameTarifBox.Location = new System.Drawing.Point(116, 58);
            this.nameTarifBox.Name = "nameTarifBox";
            this.nameTarifBox.Size = new System.Drawing.Size(100, 27);
            this.nameTarifBox.TabIndex = 3;
            // 
            // nameTarif
            // 
            this.nameTarif.AutoSize = true;
            this.nameTarif.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.nameTarif.Location = new System.Drawing.Point(12, 61);
            this.nameTarif.Name = "nameTarif";
            this.nameTarif.Size = new System.Drawing.Size(92, 22);
            this.nameTarif.TabIndex = 2;
            this.nameTarif.Text = "Название";
            this.nameTarif.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // descTarifBox
            // 
            this.descTarifBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.descTarifBox.Location = new System.Drawing.Point(116, 97);
            this.descTarifBox.Name = "descTarifBox";
            this.descTarifBox.Size = new System.Drawing.Size(100, 27);
            this.descTarifBox.TabIndex = 5;
            // 
            // descTarif
            // 
            this.descTarif.AutoSize = true;
            this.descTarif.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.descTarif.Location = new System.Drawing.Point(12, 100);
            this.descTarif.Name = "descTarif";
            this.descTarif.Size = new System.Drawing.Size(93, 22);
            this.descTarif.TabIndex = 4;
            this.descTarif.Text = "Описание";
            // 
            // costTariifBox
            // 
            this.costTariifBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.costTariifBox.Location = new System.Drawing.Point(116, 136);
            this.costTariifBox.Name = "costTariifBox";
            this.costTariifBox.Size = new System.Drawing.Size(100, 27);
            this.costTariifBox.TabIndex = 7;
            // 
            // costTarif
            // 
            this.costTarif.AutoSize = true;
            this.costTarif.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.costTarif.Location = new System.Drawing.Point(12, 139);
            this.costTarif.Name = "costTarif";
            this.costTarif.Size = new System.Drawing.Size(100, 22);
            this.costTarif.TabIndex = 6;
            this.costTarif.Text = "Стоимость";
            // 
            // addTarifButton
            // 
            this.addTarifButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.addTarifButton.Location = new System.Drawing.Point(219, 289);
            this.addTarifButton.Name = "addTarifButton";
            this.addTarifButton.Size = new System.Drawing.Size(137, 43);
            this.addTarifButton.TabIndex = 8;
            this.addTarifButton.Text = "Добавить";
            this.addTarifButton.UseVisualStyleBackColor = true;
            this.addTarifButton.Click += new System.EventHandler(this.addTarifButton_Click);
            // 
            // EditAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataPanel);
            this.Controls.Add(this.MenuPanel);
            this.Name = "EditAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditAdmin";
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.dataPanel.ResumeLayout(false);
            this.addStaff.ResumeLayout(false);
            this.addStaff.PerformLayout();
            this.addPanel.ResumeLayout(false);
            this.addPanel.PerformLayout();
            this.tariffPanel.ResumeLayout(false);
            this.tariffPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Label tarifButton;
        private System.Windows.Forms.Label staffButton;
        private System.Windows.Forms.Label serviceButton;
        private System.Windows.Forms.Label Menu;
        private System.Windows.Forms.Panel dataPanel;
        private System.Windows.Forms.TextBox costBox;
        private System.Windows.Forms.Label cost;
        private System.Windows.Forms.TextBox descripBox;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label idService;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Panel addPanel;
        private System.Windows.Forms.Panel addStaff;
        private System.Windows.Forms.TextBox passportBox;
        private System.Windows.Forms.Label passportStaff;
        private System.Windows.Forms.Label idPosition;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.Label phoneStaff;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.Label adresStaff;
        private System.Windows.Forms.Button addStaffButton;
        private System.Windows.Forms.Label idStaff;
        private System.Windows.Forms.TextBox idStaffBox;
        private System.Windows.Forms.Label genderStaff;
        private System.Windows.Forms.Label nameStaff;
        private System.Windows.Forms.TextBox ageBox;
        private System.Windows.Forms.TextBox fioBox;
        private System.Windows.Forms.Label ageStaff;
        private System.Windows.Forms.ComboBox positionCombo;
        private System.Windows.Forms.ComboBox genderCombo;
        private System.Windows.Forms.Panel tariffPanel;
        private System.Windows.Forms.TextBox idTarifBox;
        private System.Windows.Forms.Label idTariff;
        private System.Windows.Forms.Button addTarifButton;
        private System.Windows.Forms.TextBox costTariifBox;
        private System.Windows.Forms.Label costTarif;
        private System.Windows.Forms.TextBox descTarifBox;
        private System.Windows.Forms.Label descTarif;
        private System.Windows.Forms.TextBox nameTarifBox;
        private System.Windows.Forms.Label nameTarif;
    }
}