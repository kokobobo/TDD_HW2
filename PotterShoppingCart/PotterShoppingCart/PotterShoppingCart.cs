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
            var totalprice = 0;
            foreach (var order in orders)
            {
                totalprice += (order.Amount * BOOK_ORIGINALPRICE);
            }
            return totalprice;
        }
    }
}
