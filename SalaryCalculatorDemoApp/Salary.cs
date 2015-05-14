using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculatorDemoApp
{
   public class Salary
    {
        public string employeeName;
        public double basicAmount;
        //public double percentileOfHouseRent;
        //public double percentileOfMedicalAllowance;

        public double ShowSalary(double houseRentPercentage , double medicalAllowncePercentage)
        {
            return basicAmount + (basicAmount*houseRentPercentage/100) + (basicAmount*medicalAllowncePercentage/100);

        }

    }
}
