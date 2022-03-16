using Demo_CRUD_Project.Infra;
using Demo_CRUD_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Demo_CRUD_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IEmployee _repo;    

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public HomeController(IEmployee repo)
        {
           _repo = repo;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var employeeList = _repo.GetEmployees();
            return View(employeeList);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            _repo.Create(employee);
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var emp = _repo.GetEmployee(Id);
            return View(emp);
        }
        [HttpPost]
        public IActionResult Edit(Employee employee)
        {
            _repo.Update(employee);
            return View();
            
        }


        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
