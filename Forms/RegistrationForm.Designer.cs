
namespace TicketSalesPanel.Forms
{
    partial class RegistrationForm
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
            this.components = new System.ComponentModel.Container();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.MiddleNameTextBox = new System.Windows.Forms.TextBox();
            this.MiddleNameLabel = new System.Windows.Forms.Label();
            this.PassportSeriesTextBox = new System.Windows.Forms.TextBox();
            this.PassportSeriesLabel = new System.Windows.Forms.Label();
            this.PassportNumberTextBox = new System.Windows.Forms.TextBox();
            this.PassportNumberLabel = new System.Windows.Forms.Label();
            this.ResidentialAddressTextBox = new System.Windows.Forms.TextBox();
            this.ResidentialAddressLabel = new System.Windows.Forms.Label();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.FlightNumberСomboBox = new System.Windows.Forms.ComboBox();
            this.TypeOfSalonComboBox = new System.Windows.Forms.ComboBox();
            this.FlightNumberLabel = new System.Windows.Forms.Label();
            this.TypeOfSalonLabel = new System.Windows.Forms.Label();
            this.итогDataSet = new TicketSalesPanel.итогDataSet();
            this.рейсыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.рейсыTableAdapter = new TicketSalesPanel.итогDataSetTableAdapters.РейсыTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.итогDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.рейсыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(87, 7);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(29, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Имя";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(88, 23);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(159, 20);
            this.NameTextBox.TabIndex = 1;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(88, 62);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(159, 20);
            this.SurnameTextBox.TabIndex = 3;
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(87, 46);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(56, 13);
            this.SurnameLabel.TabIndex = 2;
            this.SurnameLabel.Text = "Фамилия";
            // 
            // MiddleNameTextBox
            // 
            this.MiddleNameTextBox.Location = new System.Drawing.Point(88, 101);
            this.MiddleNameTextBox.Name = "MiddleNameTextBox";
            this.MiddleNameTextBox.Size = new System.Drawing.Size(159, 20);
            this.MiddleNameTextBox.TabIndex = 5;
            // 
            // MiddleNameLabel
            // 
            this.MiddleNameLabel.AutoSize = true;
            this.MiddleNameLabel.Location = new System.Drawing.Point(87, 85);
            this.MiddleNameLabel.Name = "MiddleNameLabel";
            this.MiddleNameLabel.Size = new System.Drawing.Size(54, 13);
            this.MiddleNameLabel.TabIndex = 4;
            this.MiddleNameLabel.Text = "Отчество";
            // 
            // PassportSeriesTextBox
            // 
            this.PassportSeriesTextBox.Location = new System.Drawing.Point(88, 140);
            this.PassportSeriesTextBox.Name = "PassportSeriesTextBox";
            this.PassportSeriesTextBox.Size = new System.Drawing.Size(47, 20);
            this.PassportSeriesTextBox.TabIndex = 7;
            // 
            // PassportSeriesLabel
            // 
            this.PassportSeriesLabel.AutoSize = true;
            this.PassportSeriesLabel.Location = new System.Drawing.Point(87, 124);
            this.PassportSeriesLabel.Name = "PassportSeriesLabel";
            this.PassportSeriesLabel.Size = new System.Drawing.Size(38, 13);
            this.PassportSeriesLabel.TabIndex = 6;
            this.PassportSeriesLabel.Text = "Серия";
            // 
            // PassportNumberTextBox
            // 
            this.PassportNumberTextBox.Location = new System.Drawing.Point(150, 140);
            this.PassportNumberTextBox.Name = "PassportNumberTextBox";
            this.PassportNumberTextBox.Size = new System.Drawing.Size(97, 20);
            this.PassportNumberTextBox.TabIndex = 9;
            // 
            // PassportNumberLabel
            // 
            this.PassportNumberLabel.AutoSize = true;
            this.PassportNumberLabel.Location = new System.Drawing.Point(149, 124);
            this.PassportNumberLabel.Name = "PassportNumberLabel";
            this.PassportNumberLabel.Size = new System.Drawing.Size(93, 13);
            this.PassportNumberLabel.TabIndex = 8;
            this.PassportNumberLabel.Text = "Номер Паспорта";
            // 
            // ResidentialAddressTextBox
            // 
            this.ResidentialAddressTextBox.Location = new System.Drawing.Point(88, 179);
            this.ResidentialAddressTextBox.Name = "ResidentialAddressTextBox";
            this.ResidentialAddressTextBox.Size = new System.Drawing.Size(159, 20);
            this.ResidentialAddressTextBox.TabIndex = 11;
            // 
            // ResidentialAddressLabel
            // 
            this.ResidentialAddressLabel.AutoSize = true;
            this.ResidentialAddressLabel.Location = new System.Drawing.Point(87, 163);
            this.ResidentialAddressLabel.Name = "ResidentialAddressLabel";
            this.ResidentialAddressLabel.Size = new System.Drawing.Size(103, 13);
            this.ResidentialAddressLabel.TabIndex = 10;
            this.ResidentialAddressLabel.Text = "Адрес проживания";
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(88, 218);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(159, 20);
            this.PhoneNumberTextBox.TabIndex = 13;
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(87, 202);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(93, 13);
            this.PhoneNumberLabel.TabIndex = 12;
            this.PhoneNumberLabel.Text = "Номер телефона";
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(88, 343);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(159, 23);
            this.NextButton.TabIndex = 14;
            this.NextButton.Text = "Продолжить";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(88, 372);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(159, 23);
            this.BackButton.TabIndex = 15;
            this.BackButton.Text = "Вернуться в главное меню";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // FlightNumberСomboBox
            // 
            this.FlightNumberСomboBox.FormattingEnabled = true;
            this.FlightNumberСomboBox.Items.AddRange(new object[] {
            "В2-1957",
            "ВА872",
            "ВТ6820",
            "ЛН3187",
            "ПЛ189",
            "ТК1408",
            "ЮТ246"});
            this.FlightNumberСomboBox.Location = new System.Drawing.Point(88, 257);
            this.FlightNumberСomboBox.Name = "FlightNumberСomboBox";
            this.FlightNumberСomboBox.Size = new System.Drawing.Size(159, 21);
            this.FlightNumberСomboBox.TabIndex = 16;
            // 
            // TypeOfSalonComboBox
            // 
            this.TypeOfSalonComboBox.FormattingEnabled = true;
            this.TypeOfSalonComboBox.Items.AddRange(new object[] {
            "1)Для курящих",
            "2)Для не курящих"});
            this.TypeOfSalonComboBox.Location = new System.Drawing.Point(88, 297);
            this.TypeOfSalonComboBox.Name = "TypeOfSalonComboBox";
            this.TypeOfSalonComboBox.Size = new System.Drawing.Size(159, 21);
            this.TypeOfSalonComboBox.TabIndex = 17;
            // 
            // FlightNumberLabel
            // 
            this.FlightNumberLabel.AutoSize = true;
            this.FlightNumberLabel.Location = new System.Drawing.Point(85, 241);
            this.FlightNumberLabel.Name = "FlightNumberLabel";
            this.FlightNumberLabel.Size = new System.Drawing.Size(74, 13);
            this.FlightNumberLabel.TabIndex = 18;
            this.FlightNumberLabel.Text = "Номер рейса";
            // 
            // TypeOfSalonLabel
            // 
            this.TypeOfSalonLabel.AutoSize = true;
            this.TypeOfSalonLabel.Location = new System.Drawing.Point(85, 281);
            this.TypeOfSalonLabel.Name = "TypeOfSalonLabel";
            this.TypeOfSalonLabel.Size = new System.Drawing.Size(65, 13);
            this.TypeOfSalonLabel.TabIndex = 19;
            this.TypeOfSalonLabel.Text = "Тип салона";
            // 
            // итогDataSet
            // 
            this.итогDataSet.DataSetName = "итогDataSet";
            this.итогDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // рейсыBindingSource
            // 
            this.рейсыBindingSource.DataMember = "Рейсы";
            this.рейсыBindingSource.DataSource = this.итогDataSet;
            // 
            // рейсыTableAdapter
            // 
            this.рейсыTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 406);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TypeOfSalonLabel);
            this.Controls.Add(this.FlightNumberLabel);
            this.Controls.Add(this.TypeOfSalonComboBox);
            this.Controls.Add(this.FlightNumberСomboBox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.PhoneNumberTextBox);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.ResidentialAddressTextBox);
            this.Controls.Add(this.ResidentialAddressLabel);
            this.Controls.Add(this.PassportNumberTextBox);
            this.Controls.Add(this.PassportNumberLabel);
            this.Controls.Add(this.PassportSeriesTextBox);
            this.Controls.Add(this.PassportSeriesLabel);
            this.Controls.Add(this.MiddleNameTextBox);
            this.Controls.Add(this.MiddleNameLabel);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация о пасажире";
            ((System.ComponentModel.ISupportInitialize)(this.итогDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.рейсыBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.TextBox MiddleNameTextBox;
        private System.Windows.Forms.Label MiddleNameLabel;
        private System.Windows.Forms.TextBox PassportSeriesTextBox;
        private System.Windows.Forms.Label PassportSeriesLabel;
        private System.Windows.Forms.TextBox PassportNumberTextBox;
        private System.Windows.Forms.Label PassportNumberLabel;
        private System.Windows.Forms.TextBox ResidentialAddressTextBox;
        private System.Windows.Forms.Label ResidentialAddressLabel;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ComboBox FlightNumberСomboBox;
        private System.Windows.Forms.ComboBox TypeOfSalonComboBox;
        private System.Windows.Forms.Label FlightNumberLabel;
        private System.Windows.Forms.Label TypeOfSalonLabel;
        private итогDataSet итогDataSet;
        private System.Windows.Forms.BindingSource рейсыBindingSource;
        private итогDataSetTableAdapters.РейсыTableAdapter рейсыTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}