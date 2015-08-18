using LamedhPos.Domain;
using LamedhPos.Infras.Data.EFRepositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamedhPos.UI.Konsole
{
    public class LamedhPosContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public LamedhPosContext() : base("Server=.\\SQLEXPRESS;Database=LamedhPos;Integrated Security=SSPI")
        {
        }
    }

    class ProgramEF
    {
        static void Main(string[] args)
        {
            var employeeRepo = new EmployeeEFRepo();
            var employee = employeeRepo.GetByCode("E20");
            Console.WriteLine(employee.Code);
            Console.WriteLine(employee.Name);

            //var e20 = new Employee { Code = "E20", Name = "Margareth Peacock" };
            //employeeRepo.Save(e20);

            Console.WriteLine(employee.Id);
            employeeRepo.Dispose();

            var ctx = new LamedhPosContext();
            ctx.Employees.Remove(new Employee { Id = 5 });
        }
    }
}
