using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PotterShoppingCart.Tests
{    


    [TestClass]
    public class PotterShoppingCartTest
    {       
        [TestMethod]
        public void Test_買_第一集_一本_價格為_100()
        {
            // arrange
            var orders = new List<BookOrderData>()
            {
               new BookOrderData() { Volumn = 1, Amount = 1}
            };

            var target = new PotterShoppingCart();
            var expected = 100;
            // act
            var actual = target.CountShoppingCartPrice(orders);
            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_買_第一集_一本_第二集_一本_價格為_190()
        {
            // arrange
            var orders = new List<BookOrderData>()
            {
                new BookOrderData() { Volumn = 1, Amount = 1},
                new BookOrderData() { Volumn = 2, Amount = 1}
            };

            var target = new PotterShoppingCart();
            var expected = 190;
            // act
            var actual = target.CountShoppingCartPrice(orders);
            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_買_第一集_一本_第二集_一本_第三集_一本_價格為_270()
        {
            // arrange
            var orders = new List<BookOrderData>()
            {
                new BookOrderData() { Volumn = 1, Amount = 1},
                new BookOrderData() { Volumn = 2, Amount = 1},
                new BookOrderData() { Volumn = 3, Amount = 1}
            };

            var target = new PotterShoppingCart();
            var expected = 270;
            // act
            var actual = target.CountShoppingCartPrice(orders);
            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
