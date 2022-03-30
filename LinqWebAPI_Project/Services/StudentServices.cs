using LinqWebAPI_Project.LinqDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinqWebAPI_Project.Services
{
    public class StudentServices
    {
        private readonly IStudentRepository _repo = null;

        public StudentServices(IStudentRepository repo)
        {
            _repo = repo;
        }
        public List<Student> Stud()
        {
            //return _repo.Stud();
            List<Student> Student = _repo.Stud();
            return Student.OrderBy(s => s.name).ToList();
        }

        public List<Student> GetStudentbyname()
        {
            //return _repo.GetStudentById(StudentId);
            List<Student> Student = _repo.GetStudentbyname();
            return Student.Where(s => s.marks >= 70).ToList();

        }

        internal Student GetStudentById(int id)
        {
            throw new NotImplementedException();
        }
       
    }

}

