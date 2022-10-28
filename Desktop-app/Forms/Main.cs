using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Desktop_app.Forms
{
    public partial class Main : Form
    {
        private Button currentButton;

        private LogIn fLogin;
        private Form activeForm;
        public Main(LogIn fLogin)
        {
            InitializeComponent();
            this.fLogin = fLogin;
        }

        private void fMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            fLogin.Show();
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();

                    currentButton = (Button)btnSender;
                    currentButton.BackColor = ColorTranslator.FromHtml("35, 40, 45");
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Segoe UI", 14F);
                    
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in flpanelContainerSidebar.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = ColorTranslator.FromHtml("75, 144, 149");
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelContainer.Controls.Add(childForm);
            this.panelContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Products(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Employee(), sender);
        }

        private void brnCustomers_Click(object sender, EventArgs e)
        {

        }
    }
}
