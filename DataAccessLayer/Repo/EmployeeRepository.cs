using DataAccessLayer.Model;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer.Repo
{
    public class EmployeeRepository
    {
        static EmpContext _contextcontext;

        static EmployeeRepository()
        {
            _contextcontext = new EmpContext();
        }

        public static List<Employee> GetEmployees()
        {
            return _contextcontext.Employees.ToList();
        }

        public static bool AddEmployee(Employee employee)
        {
            _contextcontext.Employees.Add(employee);
            return _contextcontext.SaveChanges() > 0;

        }
        //update
        public static bool UpdateEmployee(Employee employee)
        {
            var emp = _contextcontext.Employees.Find(employee.Id);
            _contextcontext.Entry(emp).CurrentValues.SetValues(employee);
            return _contextcontext.SaveChanges() > 0;
        }

        public static bool DeleteEmployee(int id)
        {
            var employee = _contextcontext.Employees.Find(id);
            _contextcontext.Employees.Remove(employee);
            return _contextcontext.SaveChanges() > 0;
        }
    }
}
