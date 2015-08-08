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
        static void Main1(string[] args)
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

        static void Main(string[] args)
        {
            var e = new Employee();
            e.Code = "E01";
            e.Name = "Michael Suyama";
            e.Birthdate = DateTime.Now.AddYears(-40);

            var nancy = new Employee
            { 
                Code = "E02", 
                Name = "Nancy Davolio", 
                Birthdate = DateTime.Now.AddYears(-30), 
            };

            var momogi = new Product { Code = "P01", Name = "Momogi", UnitPrice = 500m };
            var pepsi = new Product { Code = "P02", Name = "Pepsi", UnitPrice = 5000m };

            var s01 = new Sale();
            s01.Code = "S01";
            s01.Cashier = e;
            s01.Products.Add(momogi);
            s01.Products.Add(momogi);
            s01.Products.Add(pepsi);
            ShowReceipt(s01);

            var s02 = new Sale();
            s02.Code = "S01";
            s02.Cashier = nancy;
            s02.Products.Add(pepsi);
            s02.Products.Add(pepsi);
            ShowReceipt(s02);
        }

        private static void ShowReceipt(Sale sale)
        {
            Console.WriteLine(sale.Code);
            Console.WriteLine(sale.Time);
            Console.WriteLine(sale.Cashier.Name);
            foreach (var p in sale.Products)
                Console.WriteLine("{0} {1}", p.Name, p.UnitPrice);
            Console.WriteLine("-------------+\n{0}", sale.GetTotal());
        }
    }
}
