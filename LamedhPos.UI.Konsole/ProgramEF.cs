using LamedhPos.Domain;
using LamedhPos.Infras.Data.EFRepositories;
using LamedhPos.Infras.Data.SqlRepositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamedhPos.UI.Konsole
{
    class ProgramEF
    {
        static void Main(string[] args)
        {
            //var employeeRepo = new EmployeeEFRepo();
            var employeeRepo = new EmployeeSqlRepository();
            var service = new EmployeeService(employeeRepo);
            var e = service.New();
            Console.WriteLine(e.Code);
        }
    }
}
