
namespace TicketSalesPanel
{
    partial class SQLRequestsForm
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
            this.SQLButton1 = new System.Windows.Forms.Button();
            this.SQLButton2 = new System.Windows.Forms.Button();
            this.SQLButton3 = new System.Windows.Forms.Button();
            this.SQLButton4 = new System.Windows.Forms.Button();
            this.SQLButton5 = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.InfoDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.InfoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SQLButton1
            // 
            this.SQLButton1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.SQLButton1.Location = new System.Drawing.Point(713, 21);
            this.SQLButton1.Name = "SQLButton1";
            this.SQLButton1.Size = new System.Drawing.Size(75, 23);
            this.SQLButton1.TabIndex = 0;
            this.SQLButton1.Text = "Запрос 1";
            this.SQLButton1.UseVisualStyleBackColor = false;
            this.SQLButton1.Click += new System.EventHandler(this.SQLButton1_Click);
            // 
            // SQLButton2
            // 
            this.SQLButton2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.SQLButton2.Location = new System.Drawing.Point(713, 67);
            this.SQLButton2.Name = "SQLButton2";
            this.SQLButton2.Size = new System.Drawing.Size(75, 23);
            this.SQLButton2.TabIndex = 1;
            this.SQLButton2.Text = "Запрос 2";
            this.SQLButton2.UseVisualStyleBackColor = false;
            this.SQLButton2.Click += new System.EventHandler(this.SQLButton2_Click);
            // 
            // SQLButton3
            // 
            this.SQLButton3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.SQLButton3.Location = new System.Drawing.Point(713, 116);
            this.SQLButton3.Name = "SQLButton3";
            this.SQLButton3.Size = new System.Drawing.Size(75, 23);
            this.SQLButton3.TabIndex = 2;
            this.SQLButton3.Text = "Запрос 3";
            this.SQLButton3.UseVisualStyleBackColor = false;
            this.SQLButton3.Click += new System.EventHandler(this.SQLButton3_Click);
            // 
            // SQLButton4
            // 
            this.SQLButton4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.SQLButton4.Location = new System.Drawing.Point(713, 164);
            this.SQLButton4.Name = "SQLButton4";
            this.SQLButton4.Size = new System.Drawing.Size(75, 23);
            this.SQLButton4.TabIndex = 3;
            this.SQLButton4.Text = "Запрос 4";
            this.SQLButton4.UseVisualStyleBackColor = false;
            this.SQLButton4.Click += new System.EventHandler(this.SQLButton4_Click);
            // 
            // SQLButton5
            // 
            this.SQLButton5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.SQLButton5.Location = new System.Drawing.Point(713, 209);
            this.SQLButton5.Name = "SQLButton5";
            this.SQLButton5.Size = new System.Drawing.Size(75, 23);
            this.SQLButton5.TabIndex = 4;
            this.SQLButton5.Text = "Запрос 5";
            this.SQLButton5.UseVisualStyleBackColor = false;
            this.SQLButton5.Click += new System.EventHandler(this.SQLButton5_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.SandyBrown;
            this.ExitButton.FlatAppearance.BorderColor = System.Drawing.Color.SandyBrown;
            this.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            this.ExitButton.Location = new System.Drawing.Point(634, 345);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(154, 23);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Выход в главное меню";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // InfoDataGridView
            // 
            this.InfoDataGridView.AllowUserToAddRows = false;
            this.InfoDataGridView.AllowUserToDeleteRows = false;
            this.InfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InfoDataGridView.Location = new System.Drawing.Point(28, 21);
            this.InfoDataGridView.Name = "InfoDataGridView";
            this.InfoDataGridView.ReadOnly = true;
            this.InfoDataGridView.Size = new System.Drawing.Size(582, 347);
            this.InfoDataGridView.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Описание:";
            // 
            // SQLRequestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InfoDataGridView);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SQLButton5);
            this.Controls.Add(this.SQLButton4);
            this.Controls.Add(this.SQLButton3);
            this.Controls.Add(this.SQLButton2);
            this.Controls.Add(this.SQLButton1);
            this.Name = "SQLRequestsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQLRequestsForm";
            ((System.ComponentModel.ISupportInitialize)(this.InfoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SQLButton1;
        private System.Windows.Forms.Button SQLButton2;
        private System.Windows.Forms.Button SQLButton3;
        private System.Windows.Forms.Button SQLButton4;
        private System.Windows.Forms.Button SQLButton5;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.DataGridView InfoDataGridView;
        private System.Windows.Forms.Label label1;
    }
}