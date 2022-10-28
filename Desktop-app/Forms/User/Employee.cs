using LogicLayerEntities.Products;
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

namespace Desktop_app.Forms
{
    public partial class Employee : Form
    {
        private UserHandler userHandler;
        private LogicLayerEntities.Users.Employee? selectedEmployeeFromList; 
        public static bool ADD_EMPLOYEE_FORM_OPEN = false;

        public Employee()
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
                    if (user.GetType().Name == "Employee") { AddUserToListView((LogicLayerEntities.Users.Employee)user); }
                        
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void listViewUsers_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            selectedEmployeeFromList = (LogicLayerEntities.Users.Employee)e.Item.Tag;
        }

        private void listViewUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listViewEmployees.SelectedItems.Count == 0)
            {
                selectedEmployeeFromList = null;
            }

        }

        private void AddUserToListView(LogicLayerEntities.Users.Employee employee)
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
