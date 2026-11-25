using Microsoft.AspNetCore.Mvc;
using EmployeeManagementAPI.Services;
using STEP1_ASP.NET.Models;

namespace EmployeeManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeService service;

        public EmployeeController(EmployeeService service)
        {
            this.service = service;
        }

        [HttpGet]
        public List<Employee> GetEmployees()
        {
            return service.GetEmployees();
        }
    }
}