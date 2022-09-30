using LogicClassLibrary.Products;
using LogicClassLibrary.User;
using LogicClassLibrary.Users;
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
    public partial class fEmployee : Form
    {
        private UserHandler userHandler;
        private Employee? selectedEmployeeFromList; 
        public static bool ADD_EMPLOYEE_FORM_OPEN = false;

        public fEmployee()
        {
            InitializeComponent();
            userHandler = new UserHandler();
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
                fAddEmployee AddEmployeeForm = new fAddEmployee(userHandler);
                ADD_EMPLOYEE_FORM_OPEN = true;
                AddEmployeeForm.Show();
            }
        }

        private void btnShowAllUsers_Click(object sender, EventArgs e)
        {
           
            try
            {
                listViewEmployees.Items.Clear();

                
                foreach (SystemUser user in userHandler.Users)
                {
                    if (user.GetType().Name == "Employee") { AddUserToListView((Employee)user); }
                        
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
    }
}
