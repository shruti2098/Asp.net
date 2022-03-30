using LinqWebAPI_Project.Authentication;
using System.Collections.Generic;
using System.Linq;

namespace LinqWebAPI_Project.LinqDemo
{
    public class TestStudentRepository : IStudentRepository
    {
        AuthenticationDbContext _context;
        public List<Student> DataSource()
        {

            return new List<Student>()
            {
                new Student()
                {
                    id=1,
                    name="Shruti",
                    address="Ahmednagar",
                    marks=90,
                    age=18
                },
               new Student()
               {
                id = 2,
                name = "Rohini",
                address = "Pune",
                marks=87,
                age=19
               },
            new Student()
               {
                id = 3,
                name = "Trisha",
                address = "Mumbai",
                marks=75,
                age=18
               },
            new Student()
            {
                id=4,
                name="Rahul",
                address="Nasik",
                marks=60,
                age=19
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
        public List<Student> GetStudentbyname()
        {
            return DataSource();
            //return _context.Student.ToList();

        }
        //public List<Student> GetStudentByAge()
        //{
        //    //return DataSource();
        //    return _context.Student.ToList();
        //}

    }
}
