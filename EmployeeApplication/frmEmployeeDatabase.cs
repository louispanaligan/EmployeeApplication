using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeApplication
{
    public partial class frmEmployeeDatabase : Form
    {
        private List<Employee> employees = new List<Employee>();
        public frmEmployeeDatabase()
        {
           
        InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            // Create a new Employee object using the constructor
            Employee employee = new Employee(txtEmployeeID.Text, txtFirstName.Text, txtLastName.Text, txtPosition.Text);

            // Add the employee to the list
            employees.Add(employee);

            // Refresh DataGridView
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = employees;
        
    }
    }
    public class Employee
    {
        private string employeeID;
        private string firstName;
        private string lastName;
        private string position;

        // Properties for accessing private fields
        public string EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        // Constructor overloading
        public Employee() { }

        public Employee(string employeeID, string firstName, string lastName)
        {
            this.employeeID = employeeID;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Employee(string employeeID, string firstName, string lastName, string position)
        {
            this.employeeID = employeeID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.position = position;
        }
    }
}

