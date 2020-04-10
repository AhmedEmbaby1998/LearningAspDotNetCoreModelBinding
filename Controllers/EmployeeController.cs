using Microsoft.AspNetCore.Mvc;
using ModelBinding.Models.entities;
using ModelBinding.Models.repositories;

namespace ModelBinding.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IRepositories<Employee> _repo;
        
        public EmployeeController(IRepositories<Employee> repo)
        {
            _repo = repo;
        }
        
        [Route("get/{id?}")]
        public ActionResult Index(int id)
        {
            if (id == 0) id = 1;
            return View(_repo[id]);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            if (!_repo.Contains(employee.Id)) 
                _repo[employee.Id] = employee;
            return RedirectToAction("Index", new {id = employee.Id});

        }
    }
}