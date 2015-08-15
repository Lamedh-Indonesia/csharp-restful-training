using LamedhPos.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamedhPos.UI.Konsole
{
    class Scratch
    {
        static void Main(string[] args)
        {
            var e = new Employee { Id = 1, Code = "E01", Name = "Suyama" };
            var e1 = new Employee { Id = 1, Code = "E01", Name = "Suyama" };
            Console.WriteLine(e == e1);
            Object n = e;
            Console.WriteLine(e.Equals(e1));
            Console.WriteLine(e.Equals("budi"));

            Console.WriteLine(e.GetHashCode());
            Console.WriteLine(e1.GetHashCode());
        }
    }
}
