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
            return _repo.Stud();
        }

        public Student GetStudentById(int StudentId)
        {
            return _repo.GetStudentById(StudentId);
        }
    }

}

