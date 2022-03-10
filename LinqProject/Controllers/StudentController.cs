using LinqProject.DemoLinq;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinqProject.Controllers
{
    [ApiController]
    [Route("[controller]/[Action]")]
    public class StudentController : Controller
    {
        [HttpGet]
        public ActionResult Stud()
        {
            TestStudentRepository repo = new TestStudentRepository();
            List<Student> details = repo.Stud();
            return Ok(details);
        }
       
        [HttpGet]
        public ActionResult GetStudentById(int id)
        {
            TestStudentRepository repo = new TestStudentRepository();
            Student details = repo.GetStudentById(id);
            return Ok(details);
        }



        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
