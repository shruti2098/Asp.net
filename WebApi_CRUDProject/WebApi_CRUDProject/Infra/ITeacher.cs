using CRUD_WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_WebAPI.Infraa
{
    public interface ITeacher
    {
        public List<Teacher> GetTeachers();
        public Teacher GetTeacher(int Id);
        public void Create(Teacher teacher);
    }
}
