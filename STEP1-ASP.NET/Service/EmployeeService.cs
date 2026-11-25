using STEP1_ASP.NET.Models;

namespace EmployeeManagementAPI.Services
{
    public class EmployeeService
    {
        private List<Employee> employees = new List<Employee>()
        {
            new Employee
            {
                Id = 1,
                Name = "Pujitha",
                Department = "IT",
                Salary = 45000
            },

            new Employee
            {
                Id = 2,
                Name = "Rahul",
                Department = "HR",
                Salary = 35000
            }
        };

        public List<Employee> GetEmployees()
        {
            return employees;
        }

        public Employee? GetEmployeeById(int id)
        {
            return employees.FirstOrDefault(e => e.Id == id);
        }
    }
}