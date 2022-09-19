using Desktop_app.Forms;

namespace Desktop_app
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            fMain fMain = new fMain(this);
            fMain.Show();
            this.Hide();
        }
    }
}