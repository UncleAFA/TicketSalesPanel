
namespace TicketSalesPanel
{
    partial class MainForm
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
            this.SQLRequestsButton = new System.Windows.Forms.Button();
            this.RegistrationOfNewPassengerButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SQLRequestsButton
            // 
            this.SQLRequestsButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.SQLRequestsButton.Location = new System.Drawing.Point(166, 12);
            this.SQLRequestsButton.Name = "SQLRequestsButton";
            this.SQLRequestsButton.Size = new System.Drawing.Size(132, 52);
            this.SQLRequestsButton.TabIndex = 0;
            this.SQLRequestsButton.Text = "Запросы";
            this.SQLRequestsButton.UseVisualStyleBackColor = false;
            this.SQLRequestsButton.Click += new System.EventHandler(this.SQLRequestsButton_Click);
            // 
            // RegistrationOfNewPassengerButton
            // 
            this.RegistrationOfNewPassengerButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.RegistrationOfNewPassengerButton.Location = new System.Drawing.Point(12, 12);
            this.RegistrationOfNewPassengerButton.Name = "RegistrationOfNewPassengerButton";
            this.RegistrationOfNewPassengerButton.Size = new System.Drawing.Size(132, 52);
            this.RegistrationOfNewPassengerButton.TabIndex = 1;
            this.RegistrationOfNewPassengerButton.Text = "Регистрация нового пасажира";
            this.RegistrationOfNewPassengerButton.UseVisualStyleBackColor = false;
            this.RegistrationOfNewPassengerButton.Click += new System.EventHandler(this.RegistrationOfNewPassengerButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.SandyBrown;
            this.ExitButton.Location = new System.Drawing.Point(89, 99);
            this.ExitButton.MaximumSize = new System.Drawing.Size(132, 52);
            this.ExitButton.MinimumSize = new System.Drawing.Size(132, 52);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(132, 52);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Выход из программы";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(310, 163);
            this.ControlBox = false;
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.RegistrationOfNewPassengerButton);
            this.Controls.Add(this.SQLRequestsButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(326, 202);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(326, 202);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SQLRequestsButton;
        private System.Windows.Forms.Button RegistrationOfNewPassengerButton;
        private System.Windows.Forms.Button ExitButton;
    }
}