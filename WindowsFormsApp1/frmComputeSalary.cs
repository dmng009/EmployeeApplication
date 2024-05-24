using EmployeeNamespace;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmComputeSalary : Form
    {
        public frmComputeSalary()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstname = textBox1.Text;
            string lastname = textBox2.Text;
            string department = textBox3.Text; 
            string jobtitle = textBox4.Text;           
            double ratePerHours = Convert.ToDouble(textBox5.Text);
            int basicSalary = Convert.ToInt32(textBox6.Text);

            PartTimeEmployee partTimeEmployee = new PartTimeEmployee(firstname, lastname, department, jobtitle);
            partTimeEmployee.computeSalary(basicSalary, ratePerHours);

           label10.Text = partTimeEmployee.FirstName;
            label11.Text = partTimeEmployee.LastName;
           label12.Text = partTimeEmployee.getSalary().ToString();
        }
    }
}
