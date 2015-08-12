using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LamedhPos.Domain.Tests
{
    [TestClass]
    public class SaleTest
    {
        [TestMethod]
        public void sale_with_2_momogi_and_pepsi_should_be_totaled_6000()
        {
            var sale = new Sale();
            sale.AddLineItem(momogi, 2);
            sale.AddLineItem(pepsi);
            Assert.AreEqual(6000m, sale.GetTotal());
        }

        [TestMethod]
        public void sale_with_2_pepsi_should_be_totaled_10000()
        {
            var sale = new Sale();
            sale.AddLineItem(pepsi, 2);
            Assert.AreEqual(10000m, sale.GetTotal());
        }

        [TestMethod]
        public void sale_total_with_changing_product_price_should_remain_consistent()
        {
            var sale = new Sale();
            sale.AddLineItem(momogi);
            Assert.AreEqual(500m, sale.GetTotal());

            momogi.UnitPrice = 0;
            Assert.AreEqual(500m, sale.GetTotal());
        }

        [TestInitialize]
        public void Initialize()
        {
            momogi = Samples.Momogi;
            pepsi = Samples.Pepsi;
        }

        private Product momogi;
        private Product pepsi;
    }
}
