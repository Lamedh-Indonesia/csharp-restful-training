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
        public IList<SaleLineItem> LineItems { get; private set; }

        public Sale()
        {
            LineItems = new List<SaleLineItem>();
            Time = DateTime.Now;
        }

        public decimal GetTotal()
        {
            return LineItems.Sum(sli => sli.GetSubtotal());
        }

        public void AddLineItem(Product product, int quantity)
        {
            LineItems.Add(new SaleLineItem { Product = product, Quantity = quantity });
        }

        public void AddLineItem(Product product)
        {
            AddLineItem(product, 1);
        }
    }
}
