using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreDemo.Models;

namespace CoreDemo.Models
{
    public class EmployeeRepository:Interface
    {
        private List<Employee> emp;
        public EmployeeRepository()
        {
            emp = new List<Employee>() { new Employee ( 1, "dsfk","dsfgdsg@gmail.com",Dept.Insurance),
            new Employee ( 2, "dsfk","dsfgdsg@gmail.com",Dept.Healthcare),
            new Employee ( 3, "dsfk","dsfgdsg@gmail.com",Dept.Accounts)};
        }
        public Employee GetEmploy(int id)
        {
            Employee e = emp.FirstOrDefault(e => e.Id == id);
            //foreach(Employ X in emp)
            //{
            //    if (X.Id == id) return X;

            return e;
        }
        public List<Employee>display()
        {
            return emp;
        }
        public bool AddEmployee(Employee empl)
        {
            empl.Id = emp.Max(e => e.Id) + 1;
            emp.Add(empl);
            return true;
        }
    }
}
