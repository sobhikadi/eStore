using Desktop_app.Forms.User;
using LogicLayerEntities.Products;
using LogicLayerEntities.User;
using LogicLayerEntities.Users;
using LogicLayerHandlers;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_app.Forms
{
    public partial class fEmployee : Form
    {
        private UserHandler userHandler;
        private Employee? selectedEmployeeFromList; 
        public static bool ADD_EMPLOYEE_FORM_OPEN = false;
        public static bool UPDATE_EMPLOYEE_FORM_OPEN = false;


        public fEmployee()
        {
            InitializeComponent();
            userHandler = new UserHandler();

            cboxSearchCriteria.DataSource = null;
            cboxSearchCriteria.DataSource = Enum.GetValues(typeof(SearchTypeEmployee));
            cboxSearchTerm.DataSource = null;
            cboxSearchTerm.DataSource = Enum.GetValues(typeof(EmployeeRoles));

        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if (ADD_EMPLOYEE_FORM_OPEN != false)
            {
                MessageBox.Show("There is already a window open");
                return;
            }
            else
            {
                AddEmployee AddEmployeeForm = new AddEmployee(userHandler);
                ADD_EMPLOYEE_FORM_OPEN = true;
                AddEmployeeForm.Show();
            }
        }

        private void btnShowAllUsers_Click(object sender, EventArgs e)
        {
           
            try
            {
                listViewEmployees.Items.Clear();

                
                foreach (Person user in userHandler.Users)
                {
                    if (user is Employee) { AddUserToListView((Employee)user); } 
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void listViewUsers_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            selectedEmployeeFromList = (Employee)e.Item.Tag;
        }

        private void listViewUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listViewEmployees.SelectedItems.Count == 0)
            {
                selectedEmployeeFromList = null;
            }

        }

        private void AddUserToListView(Employee employee)
        {
            ListViewItem item = new ListViewItem(employee.Id.ToString());
            item.Tag = employee;
            item.SubItems.Add(employee.FirstName);
            item.SubItems.Add(employee.LastName);
            item.SubItems.Add(employee.Role);
            item.SubItems.Add(employee.Email);

            listViewEmployees.Items.Add(item);
        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            listViewEmployees.Items.Clear();
            string? serchTerm = null;
            try
            {
                if (tbSearchTerm.Visible == true)
                {
                    if (string.IsNullOrEmpty(tbSearchTerm.Text)) throw new Exception("Please enter a search term");
                    serchTerm = tbSearchTerm.Text;
                }
                if (cboxSearchTerm.Visible == true)
                {
                    serchTerm = cboxSearchTerm.Text;
                }


                List<Employee> employees = new List<Employee>();
                employees.AddRange(userHandler.SearchEmployee(serchTerm, (SearchTypeEmployee)cboxSearchCriteria.SelectedValue));


                foreach (Employee emp in employees)
                {
                    AddUserToListView(emp);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboxSearchCriteria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxSearchCriteria.SelectedIndex == (int)SearchTypeEmployee.Role)
            {
                tbSearchTerm.Visible = false;
                cboxSearchTerm.Visible = true;
            }
            else 
            {
                tbSearchTerm.Visible = true;
                cboxSearchTerm.Visible = false;
            }

        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            if (selectedEmployeeFromList == null) 
            {
                MessageBox.Show("Please select an employee first");
                return;
            }
            if (UPDATE_EMPLOYEE_FORM_OPEN != false)
            {
                MessageBox.Show("There is already a window open");
                return;
            }
            else
            {
                UpdateEmployee updateEmployeeForm = new UpdateEmployee(userHandler, selectedEmployeeFromList, btnShowAllUsers);
                UPDATE_EMPLOYEE_FORM_OPEN = true;
                updateEmployeeForm.Show();
            }
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (selectedEmployeeFromList == null)
            {
                MessageBox.Show("Please select an Employee first");
                return;
            }
            DialogResult dr = MessageBox.Show($"Are You sure you want to Delete this Employee ({selectedEmployeeFromList.FirstName} {selectedEmployeeFromList.LastName}) ?", "Delete Employee?", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                try
                {
                    userHandler.DeleteEmployee(selectedEmployeeFromList);
                    MessageBox.Show("Employee has successfully been deleted");
                    btnShowAllUsers.PerformClick();
                }
                catch (SqlException) { MessageBox.Show("Something went wrong with database connection"); }
                catch (Exception ex) { MessageBox.Show(ex.Message); }

            }
            else return;
        }
    }
}
