using LamedhPos.Domain;
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
            var ctx = new LamedhPosContext();
            var query = ctx.Employees.Where(e => e.Name.Contains("Su"));
            foreach (var e in query)
                Console.WriteLine(e.Name);
        }
    }
}
