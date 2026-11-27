using STEP1_ASP.NET.Interface;
using STEP1_ASP.NET.Models;

namespace EmployeeManagementAPI.Services
{

    public class EmployeeService : IEmployeeService
    {
        private List<Employee> employees = new List<Employee>()
        {
            new Employee { Id = 1, Name = "Rahul", Department = "IT", Salary = 40000 },
            new Employee { Id = 2, Name = "Priya", Department = "HR", Salary = 35000 },
            new Employee { Id = 3, Name = "Arun", Department = "Finance", Salary = 45000 }
        };

        public List<Employee> GetAllEmployees()
        {
            return employees;
        }

        public Employee GetEmployeeById(int id)
        {
            return employees.FirstOrDefault(e => e.Id == id);
        }

        public string AddEmployee(Employee employee)
        {
            employee.Id = employees.Count + 1;

            employees.Add(employee);

            return "Employee Added Successfully";
        }

        public string UpdateEmployee(int id, Employee employee)
        {
            var existingEmployee = employees.FirstOrDefault(e => e.Id == id);

            if (existingEmployee == null)
            {
                return "Employee Not Found";
            }

            existingEmployee.Name = employee.Name;
            existingEmployee.Department = employee.Department;
            existingEmployee.Salary = employee.Salary;

            return "Employee Updated Successfully";
        }

        public string DeleteEmployee(int id)
        {
            var employee = employees.FirstOrDefault(e => e.Id == id);

            if (employee == null)
            {
                return "Employee Not Found";
            }

            employees.Remove(employee);

            return "Employee Deleted Successfully";
        }
    }
}

        

       
    
