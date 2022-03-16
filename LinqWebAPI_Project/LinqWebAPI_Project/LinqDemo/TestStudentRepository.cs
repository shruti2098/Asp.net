using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinqWebAPI_Project.LinqDemo
{
    public class TestStudentRepository : IStudentRepository
    {
        public List<Student> DataSource()
        {

            return new List<Student>()
            {
                new Student()
                {
                    id=1,
                    name="Shruti",
                    address="Ahmednagar"
                },
               new Student()
               {
                id = 2,
                name = "Rohini",
                address = "Pune"
               },
            new Student()
               {
                id = 3,
                name = "Trisha",
                address = "Mumbai"
               },
            new Student()
            {
                id=4,
                name="Rahul",
                address="Nasik"
            },
        };

        }
        public Student GetStudentById(int id)
        {
            return DataSource().FirstOrDefault(st => st.id == id);

        }
        public List<Student> Stud()
        {
            return DataSource();
        }

    }
}
