using Demo_CRUD_Project.Data;
using Demo_CRUD_Project.Infra;
using Demo_CRUD_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo_CRUD_Project.Services
{
    public class EmployeeRepo:IEmployee
    {
        public DatabaseContext _context;
        public EmployeeRepo(DatabaseContext context)
        {
            _context = context;
        }
        public List<Employee>GetEmployees()
        {
            return _context.Employee.ToList();
        }
        public Employee GetEmployee(int Id)
        {
            return _context.Employee.FirstOrDefault(f => f.Id == f.Id);
        }
        public void Create(Employee employee)
        {
            _context.Add(employee);
            _context.SaveChanges();
        }
        public void Update(Employee employee)
        {
            _context.Update(employee);
            _context.SaveChanges();
        }
    }
}
