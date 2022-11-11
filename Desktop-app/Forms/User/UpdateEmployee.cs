using LogicLayerEntities.Products;
using LogicLayerEntities.User;
using LogicLayerEntities.Users;
using LogicLayerHandlers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_app.Forms.User
{
    public partial class UpdateEmployee : Form
    {
        private UserHandler userHandler;
        private Employee employee;
        private Button updateUsers;
        public UpdateEmployee(UserHandler userHandler, Employee employee, Button updateUsers)
        {
            InitializeComponent();
            this.userHandler = userHandler;
            this.employee = employee;
            this.updateUsers = updateUsers;
        }
        private void UpdateEmployee_Load(object sender, EventArgs e)
        {
            cboxRoles.DataSource = null;
            cboxRoles.DataSource = Enum.GetValues(typeof(EmployeeRoles));

            tbFirstName.Text = employee.FirstName;
            tbLastName.Text = employee.LastName;
            tbEmail.Text = employee.Email;
            tbPhoneNumber.Text = employee.PhoneNumber;
            tbAddress.Text = employee.Address;
            tbPostalCode.Text = employee.PostalCode;
            cboxRoles.Text = employee.Role;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            foreach (Control co in this.Controls) 
            {
                if (co is Label == false)
                {
                    if (co.Name != "tbPassword" && co.Name != "tbRepeatPassword") co.Enabled = true;
                    else co.Enabled = false;
                }
                
            }
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            string firstName, lastName, email, phoneNumber, address, postalCode, role, password, confirmPaswd;
            Employee updateEmploye;
            firstName = tbFirstName.Text;
            lastName = tbLastName.Text;
            email = tbEmail.Text;
            phoneNumber = tbPhoneNumber.Text;
            address = tbAddress.Text;
            postalCode = tbPostalCode.Text;
            role = cboxRoles.Text;

            DialogResult dr = MessageBox.Show("Are You sure you want to Update this Employee?", "Update Employee?", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                try
                {
                    if (tbPassword.Enabled == true && tbRepeatPassword.Enabled == true)
                    {
                        password = tbPassword.Text;
                        confirmPaswd = tbRepeatPassword.Text;

                        if (string.IsNullOrEmpty(confirmPaswd)) { throw new ArgumentException("password confirmation field is empty"); }
                        if (password != confirmPaswd) throw new ArgumentException("Password and confirmation does not match");

                        updateEmploye = new Employee(firstName, lastName, email, password, phoneNumber, address, postalCode, role, DateTime.Now);

                        userHandler.UpdateEmployee(updateEmploye, this.employee);
                    }
                    else 
                    {
                        password = "DoNoTUPdaTePassWord!@#HHGTR";
                        updateEmploye = new Employee(firstName, lastName, email, password, phoneNumber, address, postalCode, role, DateTime.Now);
                        userHandler.UpdateEmployee(updateEmploye, this.employee);
                    }
                    
                    MessageBox.Show("Employee Updated successfully!");
                    fEmployee.UPDATE_EMPLOYEE_FORM_OPEN = false;
                    this.updateUsers.PerformClick();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else return;
        }

        private void UpdateEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            fEmployee.UPDATE_EMPLOYEE_FORM_OPEN = false;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are You sure you want to change the password?", "Change password?", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                tbPassword.Enabled = true;
                tbRepeatPassword.Enabled = true;
            }
            else return ;
        }
    }
}
