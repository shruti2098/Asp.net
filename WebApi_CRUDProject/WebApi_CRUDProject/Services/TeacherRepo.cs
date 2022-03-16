using CRUD_WebAPI.Data;
using CRUD_WebAPI.Infraa;
using CRUD_WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_WebAPI.Services
{
    public class TeacherRepo : ITeacher
    {
        public DatabaseContext _context;
        public TeacherRepo(DatabaseContext context)
        {
            _context = context;
        }
        public List<Teacher> GetTeachers()
        {
            return _context.Teacher.ToList();
        }
        public Teacher GetTeacher(int Id)
        {
            return _context.Teacher.FirstOrDefault(f => f.Id == f.Id);
        }
        public void Create(Teacher teacher)
        {
            _context.Add(teacher);
            _context.SaveChanges();
        }
    }
}
