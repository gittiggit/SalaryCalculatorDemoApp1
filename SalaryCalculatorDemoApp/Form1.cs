using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculatorDemoApp
{
    public partial class SalaryCalculatorUI : Form
    {
        public SalaryCalculatorUI()
        {
            InitializeComponent();
        }
        Salary salary=new Salary();
        public void showSalaryButton_Click(object sender, EventArgs e)
        {
            if (IsTextBoxEmpty())
            {
                MessageBox.Show("Please enter the value .");
            }
            else
            {
                salary.employeeName = nameTextBox.Text;
                salary.basicAmount = Convert.ToDouble(basicAmountTextBox.Text);
                //salary.percentileOfHouseRent = Convert.ToDouble(houseRentTextBox.Text);
                //salary.percentileOfMedicalAllowance = Convert.ToDouble(medicalAllowanceTextBox.Text);
                double totalSalary = salary.ShowSalary(Convert.ToDouble(houseRentTextBox.Text), Convert.ToDouble(medicalAllowanceTextBox.Text));
                MessageBox.Show(salary.employeeName + " , Your Salary is:" + totalSalary);

                nameTextBox.Text = "";
                basicAmountTextBox.Text = "";
                houseRentTextBox.Text = "";
                medicalAllowanceTextBox.Text = "";
            }
            




        }

        private bool IsTextBoxEmpty()
        {
            if (nameTextBox.Text == "" || basicAmountTextBox.Text == "" || houseRentTextBox.Text == "" ||
                medicalAllowanceTextBox.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
