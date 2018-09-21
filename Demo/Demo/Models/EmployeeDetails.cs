using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Demo.Models
{
    public class EmployeeDetails
    {
        long EmployeeID, Salary;
        string FirstName, LastName;
        

      
        public long EmployeeIDValue
        {
            get
            {
                return EmployeeID;
            }
            set
            {
                EmployeeID = value;
            }
        }
        public long SalaryValue
        {
            get
            {
                return Salary;
            }
            set
            {
                Salary = value;
            }
        }
        public string FirstNameValue
        {
            get
            {
                return FirstName;
            }
            set
            {
                FirstName = value;
            }
        }
        public string LastNameValue
        {
            get
            {
                return LastName;
            }
            set
            {
                LastName = value;
            }
        }
        

    }
}