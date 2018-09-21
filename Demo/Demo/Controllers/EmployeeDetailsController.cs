using Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.Controllers
{
    public class EmployeeDetailsController : Controller
    {
        // GET: EmployeeDetails
        public ActionResult Details()
        {
            EmployeeDetails employee = new EmployeeDetails()
            {
                EmployeeIDValue = 101,
                FirstNameValue = "Ananya",
                LastNameValue = "Bhavana",
                SalaryValue = 200000

            };
            return View(employee);
        }
    }
}