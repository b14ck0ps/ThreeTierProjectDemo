using DataAccessLayer.Model;
using DataAccessLayer.Repo;

namespace BusinessLogicLayer.Services
{
    public class EmployeeService
    {
        public static object GetEmployees()
        {
            return EmployeeRepository.GetEmployees();
        }

        public static bool AddEmployee(Employee employee)
        {
            return EmployeeRepository.AddEmployee(employee);
        }
        public static bool UpdateEmployee(Employee employee)
        {
            return EmployeeRepository.UpdateEmployee(employee);
        }
        public static bool DeleteEmployee(int id)
        {
            return EmployeeRepository.DeleteEmployee(id);
        }
    }
}
