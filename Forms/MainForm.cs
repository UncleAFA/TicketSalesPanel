using System.Windows.Forms;
using TicketSalesPanel.Forms;

namespace TicketSalesPanel
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void RegistrationOfNewPassengerButton_Click(object sender, System.EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
        }

        private void SQLRequestsButton_Click(object sender, System.EventArgs e)
        {
            SQLRequestsForm sQLRequestsForm = new SQLRequestsForm();
            sQLRequestsForm.Show();
        }
    }
}
