
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
            this.button1 = new System.Windows.Forms.Button();
            this.RegistrationOfNewPassengerButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(166, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Иное";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // RegistrationOfNewPassengerButton
            // 
            this.RegistrationOfNewPassengerButton.Location = new System.Drawing.Point(12, 12);
            this.RegistrationOfNewPassengerButton.Name = "RegistrationOfNewPassengerButton";
            this.RegistrationOfNewPassengerButton.Size = new System.Drawing.Size(132, 52);
            this.RegistrationOfNewPassengerButton.TabIndex = 1;
            this.RegistrationOfNewPassengerButton.Text = "Регистрация нового пасажира";
            this.RegistrationOfNewPassengerButton.UseVisualStyleBackColor = true;
            this.RegistrationOfNewPassengerButton.Click += new System.EventHandler(this.RegistrationOfNewPassengerButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(89, 99);
            this.ExitButton.MaximumSize = new System.Drawing.Size(132, 52);
            this.ExitButton.MinimumSize = new System.Drawing.Size(132, 52);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(132, 52);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Выход из программы";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 163);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.RegistrationOfNewPassengerButton);
            this.Controls.Add(this.button1);
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

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button RegistrationOfNewPassengerButton;
        private System.Windows.Forms.Button ExitButton;
    }
}