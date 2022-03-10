using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinqProject.DemoLinq
{
    interface IStudentRepository
    {
        Student GetStudentById(int id);
        List<Student> Stud();
        

        
    }
}
