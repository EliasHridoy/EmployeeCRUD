using EmployeeWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeWebAPI.Repository
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(EmployeeRecordsContext context) : base(context)
        {
                
        }
        public bool Update(int id, Employee employee)
        {
            if (id != employee.Id)
            {
                return false;
            }
            try
            {
                _context.Update(employee);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
                
    }
}
