using LogicLayerEntities.Products;
using LogicLayerEntities.User;
using LogicLayerEntities.Users;
using LogicLayerHandlers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_app.Forms
{
    public partial class AddEmployee : Form
    {
        private UserHandler userHandler;
        public AddEmployee(UserHandler userHandler)
        {
            InitializeComponent();
            this.userHandler = userHandler;

            cboxRoles.DataSource = null;
            cboxRoles.DataSource = Enum.GetValues(typeof(EmployeeRoles));
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            string firstName, lastName, email, phoneNumber, address, postalCode, role, password, confirmPaswd;

            firstName = tbFirstName.Text;
            lastName = tbLastName.Text;
            email = tbEmail.Text;
            password = tbPassword.Text;
            confirmPaswd = tbRepeatPassword.Text;
            phoneNumber = tbPhoneNumber.Text;
            address = tbAddress.Text;
            postalCode = tbPostalCode.Text;
            role = cboxRoles.Text;

            DialogResult dr = MessageBox.Show($"Are You sure you want to add this mployee ({firstName})?", "Add Employee?", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                try
                {

                    if (string.IsNullOrEmpty(password)) throw new ArgumentException("The field password cannot be empty");
                    if (string.IsNullOrEmpty(confirmPaswd)) { throw new ArgumentException("password confirmation field is empty"); }
                    if (password != confirmPaswd) throw new ArgumentException("Password and confirmation does not match");

                    Employee employee = new Employee(firstName, lastName, email, password, phoneNumber, address, postalCode, role, null);

                    userHandler.AddEmployee(employee);

                    MessageBox.Show("Employee added successfully!");
                    fEmployee.ADD_EMPLOYEE_FORM_OPEN = false;
                    this.Close();
                }
                catch (SqlException) { MessageBox.Show("Unable to communicate with database"); }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else return;
        }

        private void fAddEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            fEmployee.ADD_EMPLOYEE_FORM_OPEN = false;
        }
    }
}
