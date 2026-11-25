using Microsoft.AspNetCore.Mvc;
using EmployeeManagementAPI.Services;
using STEP1_ASP.NET.Models;

namespace EmployeeManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeService _service;

        public EmployeeController(EmployeeService service)
        {
            _service = service;
        }

        // 1. GET - Get all employees
        [HttpGet]
        public IActionResult GetEmployees()
        {
            return Ok(_service.GetEmployees());
        }

        // 2. GET - Get employee by ID
        [HttpGet("{id}")]

        public IActionResult GetEmployeeById(int id)
        {
            var employee = _service.GetEmployeeById(id);

            if (employee == null)
            {
                return NotFound("Employee not found");
            }

            return Ok(employee);
        }

        // 3. POST - Add employee
        [HttpPost]
        [Route("Addemployee")]
        public IActionResult AddEmployee([FromBody] Employee employee)
        {
            var result = _service.AddEmployee(employee);

            return CreatedAtAction(
                nameof(GetEmployeeById),
                new { id = result.Id },
                result
            );
        }

        // 4. PUT - Update complete employee
        [HttpPut("{id}")]
        public IActionResult UpdateEmployee(int id, Employee updatedEmployee)
        {
            var result = _service.UpdateEmployee(id, updatedEmployee);

            if (result == null)
            {
                return NotFound("Employee not found");
            }

            return Ok(result);
        }

        // 5. PATCH - Update only salary
        [HttpPatch("{id}/salary")]
        public IActionResult UpdateSalary(int id, UpdateSalaryRequest request)
        {
            var result = _service.UpdateSalary(id, request.Salary);

            if (result == null)
            {
                return NotFound("Employee not found");
            }

            return Ok(result);
        }

        // 6. DELETE - Delete employee
        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            bool result = _service.DeleteEmployee(id);

            if (!result)
            {
                return NotFound("Employee not found");
            }

            return NoContent();
        }
    }
}