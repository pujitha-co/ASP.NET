using STEP1_ASP.NET.Models;

namespace STEP1_ASP.NET.Interface
{
    
        public interface IEmployeeService
        {
            List<Employee> GetAllEmployees();

            Employee GetEmployeeById(int id);

            string AddEmployee(Employee employee);

            string UpdateEmployee(int id, Employee employee);

            string DeleteEmployee(int id);
        }
    }

