﻿using System.Collections.Generic;
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

        [TestMethod]
        public void Test_買_第一集_一本_第二集_一本_第三集_一本_第四集_一本_價格為_320()
        {
            // arrange
            var orders = new List<BookOrderData>()
            {
                new BookOrderData() { Volumn = 1, Amount = 1},
                new BookOrderData() { Volumn = 2, Amount = 1},
                new BookOrderData() { Volumn = 3, Amount = 1},
                new BookOrderData() { Volumn = 4, Amount = 1}
            };

            var target = new PotterShoppingCart();
            var expected = 320;
            // act
            var actual = target.CountShoppingCartPrice(orders);
            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_買_第一集_一本_第二集_一本_第三集_一本_第四集_一本_第五集_一本_價格為_375()
        {
            // arrange
            var orders = new List<BookOrderData>()
            {
                new BookOrderData() { Volumn = 1, Amount = 1},
                new BookOrderData() { Volumn = 2, Amount = 1},
                new BookOrderData() { Volumn = 3, Amount = 1},
                new BookOrderData() { Volumn = 4, Amount = 1},
                new BookOrderData() { Volumn = 5, Amount = 1}
            };

            var target = new PotterShoppingCart();
            var expected = 375;
            // act
            var actual = target.CountShoppingCartPrice(orders);
            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_買_第一集_一本_第二集_一本_第三集_兩本_價格為_370()
        {
            // arrange
            var orders = new List<BookOrderData>()
            {
                new BookOrderData() { Volumn = 1, Amount = 1},
                new BookOrderData() { Volumn = 2, Amount = 1},
                new BookOrderData() { Volumn = 3, Amount = 2},
            };

            var target = new PotterShoppingCart();
            var expected = 370;
            // act
            var actual = target.CountShoppingCartPrice(orders);
            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_買_第一集_一本_第二集_兩本_第三集_兩本_價格為_460()
        {
            // arrange
            var orders = new List<BookOrderData>()
            {
                new BookOrderData() { Volumn = 1, Amount = 1},
                new BookOrderData() { Volumn = 2, Amount = 2},
                new BookOrderData() { Volumn = 3, Amount = 2},
            };

            var target = new PotterShoppingCart();
            var expected = 460;
            // act
            var actual = target.CountShoppingCartPrice(orders);
            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}