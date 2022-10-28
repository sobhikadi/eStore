using Desktop_app.Forms;
using LogicLayerEntities;

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
            Main fMain = new Main(this);
            fMain.Show();
            this.Hide();
        }
    }
}