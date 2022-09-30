using LogicClassLibrary.Products;
using LogicClassLibrary.User;
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
    public partial class fAddEmployee : Form
    {
        private UserHandler userHandler;
        public fAddEmployee(UserHandler userHandler)
        {
            InitializeComponent();
            this.userHandler = userHandler;
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            string firstName, lastName, email, phoneNumber, streetName, houseNumber, postalCode, role;

            try
            {
                if (string.IsNullOrEmpty(tbFirstName.Text)) { MessageBox.Show("Please enter first name"); return; }
                if (string.IsNullOrEmpty(tbLastName.Text)) { MessageBox.Show("Please enter last name"); return; }
                if (string.IsNullOrEmpty(tbEmail.Text)) { MessageBox.Show("Please enter email"); return; }
                if (string.IsNullOrEmpty(tbPhoneNumber.Text)) { MessageBox.Show("Please enter phone number"); return; }
                if (string.IsNullOrEmpty(tbStreetName.Text)) { MessageBox.Show("Please enter street name"); return; }
                if (string.IsNullOrEmpty(tbHouseNumber.Text)) { MessageBox.Show("Please enter house number"); return; }
                if (string.IsNullOrEmpty(tbPostalCode.Text)) { MessageBox.Show("Please enter postal code"); return; }
                if (string.IsNullOrEmpty(cboxRoles.Text)) { MessageBox.Show("Please enter select role"); return; }

                firstName = tbFirstName.Text;
                lastName = tbLastName.Text;
                email = tbEmail.Text;
                phoneNumber = tbPhoneNumber.Text;
                streetName = tbStreetName.Text;
                houseNumber = tbHouseNumber.Text;
                postalCode = tbPostalCode.Text;
                role = cboxRoles.Text;

                userHandler.AddEmployee(firstName, lastName, email, phoneNumber, role, streetName, houseNumber, postalCode);

                foreach (Control co in this.Controls)
                {
                    if (co is TextBox || co is ComboBox)
                    {
                        co.ResetText();
                    }
                }
                MessageBox.Show("Employee added successfully!");
                fEmployee.ADD_EMPLOYEE_FORM_OPEN = false;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fAddEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            fEmployee.ADD_EMPLOYEE_FORM_OPEN = false;
        }
    }
}
