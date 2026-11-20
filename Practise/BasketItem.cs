using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    internal class BasketItem
    {
        public BasketItem(Product? productItem, int count)
        {
            ProductItem = productItem;
            Count = count;
        }

        public Product? ProductItem { get; set; }
        public int Count { get; set; }  //mehsulun sayi

        public void ShowItem()
        {
            if (ProductItem == null)
            {
                Console.WriteLine("No item");
            }
            else
            {
                ProductItem.Show();
                Console.WriteLine($"Count: {Count}");
            }
        }
    }
}
