using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Models
{
    public interface Interface
    {
        Employee GetEmploy(int id);
        List<Employee> display();
        bool AddEmployee(Employee employee);
    }
}
