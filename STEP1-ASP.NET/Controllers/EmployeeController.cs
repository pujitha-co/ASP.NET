using EmployeeManagementAPI.Services;
using Microsoft.AspNetCore.Mvc;
using STEP1_ASP.NET.DTO;
using STEP1_ASP.NET.Interface;
using STEP1_ASP.NET.Models;

namespace EmployeeManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _service;

        // Constructor Injection
        public EmployeeController(IEmployeeService service)
        {
            _service = service;
        }

        // GET: api/employee
        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            var employees = _service.GetAllEmployees();

            return Ok(employees);
        }

        // GET: api/employee/1
        [HttpGet("{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            var employee = _service.GetEmployeeById(id);

            if (employee == null)
            {
                return NotFound("Employee Not Found");
            }

            return Ok(employee);
        }

        // POST: api/employee
        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            var result = _service.AddEmployee(employee);

            return Ok(result);
        }

        // PUT: api/employee/1
        [HttpPut("{id}")]
        public IActionResult UpdateEmployee(int id, Employee employee)
        {
            var result = _service.UpdateEmployee(id, employee);

            if (result == "Employee Not Found")
            {
                return NotFound(result);
            }

            return Ok(result);
        }

        // DELETE: api/employee/1
        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            var result = _service.DeleteEmployee(id);

            if (result == "Employee Not Found")
            {
                return NotFound(result);
            }

            return Ok(result);
        }
    }
}