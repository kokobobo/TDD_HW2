using System;
using System.Collections.Generic;
using System.Linq;

namespace PotterShoppingCart
{
    public class BookOrderData
    {
        public int Volumn { get; set; }
        public int Amount { get; set; }
    }

    public class PotterShoppingCart
    {
        private const int BOOK_ORIGINALPRICE = 100;

        public int CountShoppingCartPrice(IEnumerable<BookOrderData> orders)
        {
            var totalPrice = 0;
            var orderGroupList = new List<List<int>>();

            // 把資料分成不重複的一組
            foreach (var order in orders)
            {
                for (int i = 0; i < order.Amount; i++)
                {
                    if (orderGroupList.Count <= i)
                    {
                        var orderGroup = new List<int>();
                        orderGroup.Add(order.Volumn);
                        orderGroupList.Add(orderGroup);
                    }
                    else
                    {
                        orderGroupList[i].Add(order.Volumn);
                    }
                }
            }

            // 尋訪所有組別後依個別折扣計算總價
            foreach (var orderGroup in orderGroupList)
            {
                switch (orderGroup.Count)
                { 
                 case 1: // 原價

                    totalPrice += orderGroup.Count * BOOK_ORIGINALPRICE;
                    break;

                case 2: // 2本95折

                    totalPrice += (int)(orderGroup.Count * BOOK_ORIGINALPRICE * 0.95);
                    break;

                case 3: // 3本9折

                    totalPrice += (int)(orderGroup.Count * BOOK_ORIGINALPRICE * 0.9);
                    break;

                default:
                    throw new Exception("This order is illegal (unknown book?)");
                }
            }

            return totalPrice;
        }
    }
}