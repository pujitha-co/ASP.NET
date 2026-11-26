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
               
                Salary = 45000
            },

            new Employee
            {
                Id = 2,
                Name = "Rahul",
               
                Salary = 35000
            },
            new Employee
            {
                Id = 3,
                Name = "Priya",
                
                Salary = 40000
            }
        };

        // GET: Get all employees
        public List<Employee> GetEmployees()
        {
            return employees;
        }

        // GET: Get employee by ID
        public Employee? GetEmployeeById(int id)
        {
            return employees.FirstOrDefault(e => e.Id == id);
        }

        // POST: Add employee
        public Employee AddEmployee(Employee employee)
        {
            employee.Id = employees.Count == 0
                ? 1
                : employees.Max(e => e.Id) + 1;

            employees.Add(employee);

            return employee;
        }

        // PUT: Update complete employee
        public Employee? UpdateEmployee(int id, Employee updatedEmployee)
        {
            var employee = employees.FirstOrDefault(e => e.Id == id);

            if (employee == null)
            {
                return null;
            }

            employee.Name = updatedEmployee.Name;
            
            employee.Salary = updatedEmployee.Salary;

            return employee;
        }

        // PATCH: Update only salary
        public Employee? UpdateSalary(int id, decimal salary)
        {
            var employee = employees.FirstOrDefault(e => e.Id == id);

            if (employee == null)
            {
                return null;
            }

            employee.Salary = salary;

            return employee;
        }

        // DELETE: Delete employee
        public bool DeleteEmployee(int id)
        {
            var employee = employees.FirstOrDefault(e => e.Id == id);

            if (employee == null)
            {
                return false;
            }

            employees.Remove(employee);

            return true;
        }
    }
}
        

       
    
