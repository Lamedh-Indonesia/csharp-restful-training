using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamedhPos.Domain
{
    public class EmployeeService
    {
        private IEmployeeRepository employeeRepo;

        public EmployeeService(IEmployeeRepository employeeRepo)
        {
            this.employeeRepo = employeeRepo;
        }

        public string GenerateCode()
        {
            return "E" + (employeeRepo.GetCount() + 1);
        }
    }
}
