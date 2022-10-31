using Desktop_app.Forms;
using LogicLayerEntities;
using LogicLayerHandlers;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Text;

namespace Desktop_app
{
    public partial class LogIn : Form
    {
        
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            UserHandler userHandler = new UserHandler();
            Main fMain;
            string email, password, role;

            try
            {
                if (string.IsNullOrEmpty(tbEmail.Text)) throw new Exception("Please enter an email.");
                if (string.IsNullOrEmpty(tbPassword.Text)) throw new Exception("Please enter a password.");

                email = tbEmail.Text;
                password = tbPassword.Text;

                role = userHandler.ValidateUser(email, password);

                fMain = new Main(this, role);
                fMain.Show();
                this.Hide();
            }
            catch (SqlException) { MessageBox.Show("Unable to communicate with database"); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void tbEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogIn.PerformClick();
            }
        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogIn.PerformClick();
            }
        }
    }
}