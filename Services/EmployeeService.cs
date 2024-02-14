using JwtProject.Context;
using JwtProject.Interfaces;
using JwtProject.Models;

namespace JwtProject.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly JwtContext _context;
        public EmployeeService(JwtContext context)
        {
            _context = context;
        }
        public Employee AddEmployee(Employee employee)
        {
            var emp = _context.Employees.Add(employee);
            _context.SaveChanges();
            return emp.Entity;
        }

        public bool DeleteEmployee(int id)
        {
            try
            {
                var emp = _context.Employees.SingleOrDefault(x => x.Id == id);

                if (emp == null)
                {
                    throw new Exception("Employee not found");
                }

                _context.Employees.Remove(emp);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e) {
                return false;
            }
        }

        public Employee GetEmployee(int id)
        {
            var employee = _context.Employees.Find(id);
            return employee;
        }

        public List<Employee> GetEmployeeDetails()
        {
            var employee = _context.Employees.ToList();
            return employee;
        }

        public Employee UpdateEmployee(Employee employee)
        {
            var updatedEmployee = _context.Employees.Update(employee);
            _context.SaveChanges();
            return updatedEmployee.Entity;
        }
    }
}
