
namespace TicketSalesPanel
{
    partial class TicketDisplay
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
            this.ExitButton = new System.Windows.Forms.Button();
            this.AirlineNameLabel = new System.Windows.Forms.Label();
            this.PassportNumSeriesLabel = new System.Windows.Forms.Label();
            this.FIOLabel = new System.Windows.Forms.Label();
            this.FromLabel = new System.Windows.Forms.Label();
            this.ToLabel = new System.Windows.Forms.Label();
            this.FlightNumberLabel = new System.Windows.Forms.Label();
            this.DepartTimeLabel = new System.Windows.Forms.Label();
            this.NumSaetLabel = new System.Windows.Forms.Label();
            this.TypeSeatLabel = new System.Windows.Forms.Label();
            this.NumPassLabel = new System.Windows.Forms.Label();
            this.DepartDateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.SandyBrown;
            this.ExitButton.Location = new System.Drawing.Point(151, 427);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(200, 23);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "Выход в главное меню";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // AirlineNameLabel
            // 
            this.AirlineNameLabel.AutoSize = true;
            this.AirlineNameLabel.Location = new System.Drawing.Point(12, 35);
            this.AirlineNameLabel.Name = "AirlineNameLabel";
            this.AirlineNameLabel.Size = new System.Drawing.Size(35, 13);
            this.AirlineNameLabel.TabIndex = 1;
            this.AirlineNameLabel.Text = "label1";
            // 
            // PassportNumSeriesLabel
            // 
            this.PassportNumSeriesLabel.AutoSize = true;
            this.PassportNumSeriesLabel.Location = new System.Drawing.Point(316, 84);
            this.PassportNumSeriesLabel.Name = "PassportNumSeriesLabel";
            this.PassportNumSeriesLabel.Size = new System.Drawing.Size(35, 13);
            this.PassportNumSeriesLabel.TabIndex = 2;
            this.PassportNumSeriesLabel.Text = "label1";
            // 
            // FIOLabel
            // 
            this.FIOLabel.AutoSize = true;
            this.FIOLabel.Location = new System.Drawing.Point(78, 129);
            this.FIOLabel.Name = "FIOLabel";
            this.FIOLabel.Size = new System.Drawing.Size(35, 13);
            this.FIOLabel.TabIndex = 3;
            this.FIOLabel.Text = "label1";
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.Location = new System.Drawing.Point(78, 166);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(35, 13);
            this.FromLabel.TabIndex = 4;
            this.FromLabel.Text = "label1";
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Location = new System.Drawing.Point(283, 166);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(35, 13);
            this.ToLabel.TabIndex = 5;
            this.ToLabel.Text = "label1";
            // 
            // FlightNumberLabel
            // 
            this.FlightNumberLabel.AutoSize = true;
            this.FlightNumberLabel.Location = new System.Drawing.Point(78, 217);
            this.FlightNumberLabel.Name = "FlightNumberLabel";
            this.FlightNumberLabel.Size = new System.Drawing.Size(35, 13);
            this.FlightNumberLabel.TabIndex = 6;
            this.FlightNumberLabel.Text = "label1";
            // 
            // DepartTimeLabel
            // 
            this.DepartTimeLabel.AutoSize = true;
            this.DepartTimeLabel.Location = new System.Drawing.Point(240, 217);
            this.DepartTimeLabel.Name = "DepartTimeLabel";
            this.DepartTimeLabel.Size = new System.Drawing.Size(35, 13);
            this.DepartTimeLabel.TabIndex = 7;
            this.DepartTimeLabel.Text = "label1";
            // 
            // NumSaetLabel
            // 
            this.NumSaetLabel.AutoSize = true;
            this.NumSaetLabel.Location = new System.Drawing.Point(430, 253);
            this.NumSaetLabel.Name = "NumSaetLabel";
            this.NumSaetLabel.Size = new System.Drawing.Size(35, 13);
            this.NumSaetLabel.TabIndex = 8;
            this.NumSaetLabel.Text = "label2";
            // 
            // TypeSeatLabel
            // 
            this.TypeSeatLabel.AutoSize = true;
            this.TypeSeatLabel.Location = new System.Drawing.Point(383, 275);
            this.TypeSeatLabel.Name = "TypeSeatLabel";
            this.TypeSeatLabel.Size = new System.Drawing.Size(35, 13);
            this.TypeSeatLabel.TabIndex = 9;
            this.TypeSeatLabel.Text = "label1";
            // 
            // NumPassLabel
            // 
            this.NumPassLabel.AutoSize = true;
            this.NumPassLabel.Location = new System.Drawing.Point(78, 323);
            this.NumPassLabel.Name = "NumPassLabel";
            this.NumPassLabel.Size = new System.Drawing.Size(35, 13);
            this.NumPassLabel.TabIndex = 11;
            this.NumPassLabel.Text = "label3";
            // 
            // DepartDateLabel
            // 
            this.DepartDateLabel.AutoSize = true;
            this.DepartDateLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.DepartDateLabel.Location = new System.Drawing.Point(240, 241);
            this.DepartDateLabel.Name = "DepartDateLabel";
            this.DepartDateLabel.Size = new System.Drawing.Size(35, 13);
            this.DepartDateLabel.TabIndex = 12;
            this.DepartDateLabel.Text = "label1";
            // 
            // TicketDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TicketSalesPanel.Properties.Resources.ImagePass;
            this.ClientSize = new System.Drawing.Size(483, 462);
            this.ControlBox = false;
            this.Controls.Add(this.DepartDateLabel);
            this.Controls.Add(this.NumPassLabel);
            this.Controls.Add(this.TypeSeatLabel);
            this.Controls.Add(this.NumSaetLabel);
            this.Controls.Add(this.DepartTimeLabel);
            this.Controls.Add(this.FlightNumberLabel);
            this.Controls.Add(this.ToLabel);
            this.Controls.Add(this.FromLabel);
            this.Controls.Add(this.FIOLabel);
            this.Controls.Add(this.PassportNumSeriesLabel);
            this.Controls.Add(this.AirlineNameLabel);
            this.Controls.Add(this.ExitButton);
            this.Name = "TicketDisplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicketDisplay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label AirlineNameLabel;
        private System.Windows.Forms.Label PassportNumSeriesLabel;
        private System.Windows.Forms.Label FIOLabel;
        private System.Windows.Forms.Label FromLabel;
        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.Label FlightNumberLabel;
        private System.Windows.Forms.Label DepartTimeLabel;
        private System.Windows.Forms.Label NumSaetLabel;
        private System.Windows.Forms.Label TypeSeatLabel;
        private System.Windows.Forms.Label NumPassLabel;
        private System.Windows.Forms.Label DepartDateLabel;
    }
}