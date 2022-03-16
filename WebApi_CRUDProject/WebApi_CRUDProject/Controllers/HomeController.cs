using CRUD_WebAPI.Infraa;
using CRUD_WebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_WebAPI.Controllers
{
    [ApiController]
    [Route("[Controller]/[Action]")]
    [Route("Home")]
    public class HomeController : Controller
    {
        private readonly ITeacher _repo;
        public HomeController(ITeacher repo)
        {
            _repo = repo;
        }
        [HttpGet]
        [Route("Index")]
        public IActionResult Index()
        {
            var teacherList = _repo.GetTeachers();
            return Ok(teacherList);
        }
        [HttpGet]
        [Route("Create")]
        public IActionResult Create()
        {
            return Ok();
        }
        [HttpPost]
        public IActionResult Create(Teacher teacher)
        {
            _repo.Create(teacher);
            return Ok();
        }
        /*[HttpGet]
        public IActionResult Edit(int Id)
        {
            var tr = _repo.GetTeacher(Id);
            return Ok(tr);
        }
*/
        //public IActionResult Edit(Employee employee)
        //{
        //    _repo.Update(employee);
        //    return View();

        //}
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }


}
