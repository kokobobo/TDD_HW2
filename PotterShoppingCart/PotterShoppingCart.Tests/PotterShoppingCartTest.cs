using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PotterShoppingCart.Tests
{    
    public class BookOrderData
    {
        public int Volumn { get; set; }
        public int Amount { get; set; }
    }

    [TestClass]
    public class PotterShoppingCartTest
    {
        private const int BOOK_ORIGINALPRICE = 100;

        [TestMethod]
        public void Test_買_第一集_一本_價格為_100()
        {
            // arrange
            var orders = new List<BookOrderData>()
            {
               new BookOrderData() { Volumn = 1, Amount = 1}
            };
            
            var expected = 100;
            // act
            var actual = CountShoppingCartPrice(orders);
            // assert
            Assert.AreEqual(expected, actual);
        }

        public int CountShoppingCartPrice(IEnumerable<BookOrderData> orders)
        {
            return 0;
        }
    }
}
