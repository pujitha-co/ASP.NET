using EmployeeManagementAPI.Services;
using Microsoft.AspNetCore.Mvc;
using STEP1_ASP.NET.DTO;
using STEP1_ASP.NET.Models;

namespace EmployeeManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        [HttpPost]
        
        public IActionResult CreateEmployee(EmployeeRequestDto dto)
        {
            Employee employee = new Employee()
            {
                Id = 1,
                Name = dto.Name,
                Email = dto.Email,
                Salary = dto.Salary,
                Password = dto.Password
            };

            EmployeeResponseDto response = new EmployeeResponseDto()
            {
                Id = employee.Id,
                Name = employee.Name,
                Email = employee.Email,
                Salary = employee.Salary
            };

            return Ok(response);
        }
    }
}