using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamedhPos.Domain
{
    public class Sale
    {
        public string Code { get; set; }
        public DateTime Time { get; set; }

        public Employee Cashier { get; set; }
        public List<Product> Products { get; set; }

        public Sale()
        {
            Products = new List<Product>();
            Time = DateTime.Now;
        }

        public decimal GetTotal()
        {
            return Products.Sum(p => p.UnitPrice);
        }
    }
}
