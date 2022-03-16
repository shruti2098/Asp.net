using Demo_CRUD_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo_CRUD_Project.Infra
{
    public interface IEmployee
    {
        public List<Employee> GetEmployees();
        public Employee GetEmployee(int Id);
        public void Create(Employee employee);
        //public void DeleteEmployee(Employee employee);
        public void Update(Employee employee);
    }
}
