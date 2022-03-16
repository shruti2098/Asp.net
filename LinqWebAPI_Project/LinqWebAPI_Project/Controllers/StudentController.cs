using LinqWebAPI_Project.LinqDemo;
using LinqWebAPI_Project.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinqWebAPI_Project.Controllers
{

    [ApiController]
    [Route("[controller]/[Action]")]
    public class StudentController : Controller
    {
        private readonly StudentServices _StudentServices = null;

        public StudentController(StudentServices studentServices)
        {
            _StudentServices = studentServices;
        }

        [HttpGet]
        public ActionResult Stud()
        {
            try
            {
                List<Student> stud = _StudentServices.Stud();
                return Ok(stud);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpGet]
        public ActionResult GetStudentById(int id)
        {

            try
            {
                Student stud = _StudentServices.GetStudentById(id);
                return Ok(stud);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }

}
