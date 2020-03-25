using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.BusinessObject;
using Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ServiceLayer;

namespace BootstrapPracticeSample.Pages
{

    [BindProperties]
    public class IndexModel : PageModel
    {
        public List<Employee> EmployeeList { get; set; }

        public void OnGet()
        {
            IEmployeeService employeeService = new EmployeeManager();
            EmployeeList = employeeService.GetAll();
        }

        /// <summary>
        /// For add or update values
        /// </summary>
        public IActionResult OnGetEdit(string Name, string Mobile,DateTime? DOB,DateTime? DOJ) 
        {
            IEmployeeService employeeService = new EmployeeManager();
            Employee emp = new Employee();
            emp.Name = Name;
            emp.Mobile = Mobile;
            emp.DOB = DOB.Value;
            emp.DOJ = DOJ.Value;
            emp.UpdatedBy = "AKshar";
            emp.UpdatedOnUtc = DateTime.UtcNow;
            emp.IpAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
            employeeService.Update(emp);
            return RedirectToPage();
        }
        
        /// <summary>
        /// For add or update values
        /// </summary>
        public IActionResult OnGetAdd(string Name, string Mobile,DateTime? DOB,DateTime? DOJ) 
        {
            IEmployeeService employeeService = new EmployeeManager();
            Employee emp = new Employee();
            emp.Name = Name;
            emp.Mobile = Mobile;
            emp.DOB = DOB.Value;
            emp.DOJ = DOJ.Value;
            emp.UpdatedBy = emp.CreatedBy = "AKSHAR";
            emp.UpdatedOnUtc = emp.CreatedOnUtc = DateTime.UtcNow;
            emp.IpAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
            employeeService.Add(emp);
            return RedirectToPage();
        }
    }
}
