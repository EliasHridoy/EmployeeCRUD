using EmployeeWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeWebAPI.Repository
{
    public interface IEmployeeRepository: IGenericRepository<Employee>
    {
        bool Update(int id, Employee employee);
        
    }
}
