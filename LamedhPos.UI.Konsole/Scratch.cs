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
            int[] nums = new int[] { 3, 2, 1, 10, };
            nums[1] = 4;
            for (int i = 0; i < nums.Length; i++)
                Console.WriteLine(nums[i]);

            var ns = new List<int>();
            ns.Add(5);
            ns.Add(4);
            ns.Add(10);
            ns[0] = 3;
            ns.Remove(3);
            for (int i = 0; i < ns.Count; i++)
                Console.WriteLine(ns[i]);
            foreach (var n in nums)
                Console.WriteLine(n);

            var emps = new List<Employee>();
            emps.Add(new Employee { Code = "E01", Name = "Suyama", });
            emps.Add(new Employee { Code = "E02", Name = "Nancy", });
            foreach (var e in emps)
                Console.WriteLine(e.Name);
        }

        private static void ShowReceipt(Sale sale)
        {
            Console.WriteLine(sale.Code);
            Console.WriteLine(sale.Time);
            Console.WriteLine(sale.Cashier.Name);
            foreach (var sli in sale.LineItems)
                Console.WriteLine("{0} {1}", sli.Product.Name, sli.UnitPrice);
            Console.WriteLine("-------------+\n{0}", sale.GetTotal());
        }
    }
}
