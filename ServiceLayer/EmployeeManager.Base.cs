using Core.BusinessObject;
using Core.Services;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer
{
    public partial class EmployeeManager : IEmployeeService
    {
        /// <summary>
        /// Add the employee details
        /// </summary>
        public void Add(Employee emp) 
        {
            EmployeeDB employeeDB = new EmployeeDB();
            employeeDB.Add(emp);
        }
        
        /// <summary>
        /// Update the employee details
        /// </summary>
        public void Update(Employee emp) 
        {
            EmployeeDB employeeDB = new EmployeeDB();
            employeeDB.Update(emp);
        }

        public List<Employee> GetAll() 
        {
            EmployeeDB employeeDB = new EmployeeDB();
            List<Employee> employeesList = employeeDB.GetAll();
            if (employeesList != null && employeesList.Count > 0) 
            {
                return employeesList;
            }
            else 
            {
                return new List<Employee>();
            }
        }
    }
}
