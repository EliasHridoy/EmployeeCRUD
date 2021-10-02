using EmployeeWebAPI.Models;
using EmployeeWebAPI.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace EmployeeWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _repo;

        public EmployeeController(IEmployeeRepository repository)
        {
            _repo = repository;
        }
        // Select All using --> api/Employee
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return _repo.GetAll();
        }

        // Select using --> api/Employee/5
        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            return _repo.GetById(id);
        }

        // Create api/Employee
        [HttpPost]
        public bool Post(Employee employee)
        {
            return _repo.Add(employee);
        }

        // Update api/Employee/5
        [HttpPut("{id}")]
        public bool Put(int id,  Employee employee)
        {
            return _repo.Update(id, employee);
        }

        // DELETE api/Employee/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            var employee = _repo.GetById(id);
            return _repo.Remove(employee);
        }
    }
}
