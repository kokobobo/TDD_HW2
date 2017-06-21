using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            var setAmount = 0;
            foreach (var order in orders)
            {
                if (setAmount == 0)
                {
                    setAmount = order.Amount;
                }
                else
                {
                    setAmount = Math.Min(setAmount, order.Amount);
                }
            }

            totalPrice += (int)(setAmount * 2 * BOOK_ORIGINALPRICE * 0.95);

            foreach (var order in orders)
            {
                totalPrice += (order.Amount - setAmount) * BOOK_ORIGINALPRICE;
            }
            

            return totalPrice;
        }
    }
}
