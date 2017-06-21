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
            var setAmount =
                (from order in orders
                 select order.Amount)
                .Min();

            totalPrice += (int)(setAmount * orders.Count() * BOOK_ORIGINALPRICE * 0.95);

            foreach (var order in orders)
            {
                totalPrice += (order.Amount - setAmount) * BOOK_ORIGINALPRICE;
            }

            return totalPrice;
        }
    }
}