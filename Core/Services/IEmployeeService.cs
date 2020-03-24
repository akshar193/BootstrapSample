using Core.BusinessObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Services
{
    public interface IEmployeeService
    {
        List<Employee> GetAll();

        void Add(Employee emp);
        void Update(Employee emp);

    }
}
