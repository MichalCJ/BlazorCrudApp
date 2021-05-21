using System;
using System.Collections.Generic;

namespace BlazorZaliczenie.Data
{
    interface IEmployeeService
    {
        List<Employee> GetEmployess();

        Employee GetEmployee(Guid id);

        void UpdateEmployee(Employee employee);

        void AddEmployee(Employee employee);

        void DeleteEmployee(Guid id);
    }
}
