using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinqWebAPI_Project.LinqDemo
{
    public interface IStudentRepository
    {
        Student GetStudentById(int id);
        List<Student> Stud();
    }
}
