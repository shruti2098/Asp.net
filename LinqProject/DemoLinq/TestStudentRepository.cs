using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinqProject.DemoLinq
{
    public class TestStudentRepository:IStudentRepository
    {
        public List<Student> DataSource()
        {

            return new List<Student>()
            {
                new Student()
                {
                    id=1,
                    name="Aishwarya",
                    address="Soalpur"
                },
               new Student()
               {
                id = 2,
                name = "Arpita",
                address = "Pune"
               },
            new Student()
               {
                id = 3,
                name = "Varsha",
                address = "Banglore"
               },
        };
            
        }
        public Student GetStudentById(int id)
        {
            return DataSource().FirstOrDefault(st => st.id == id);
            //return DataSource().First(st => st.id == id);
            // return DataSource().SingleOrDefault(st => st.id == id);
            //return DataSource().Single(st => st.id == id);


        }
        public List<Student> Stud()
        {
            return DataSource();
        }

    }
}
