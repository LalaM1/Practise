using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    internal class Basket
    {
        public List<BasketItem> products { get; set; } = new List<BasketItem>();

        //sebetde olan butun productlar
        public void ShowBasket()
        {
            foreach (var p in products)
            {
                Console.WriteLine("🍔🍔🍔🍔🍔🍔🍔🍔🍔🍔🍔🍔🍔🍔🍔🍔🍔🍔🍔🍔🍔🍔");
                p.ShowItem();
                Console.WriteLine("🍔🍔🍔🍔🍔🍔🍔🍔🍔🍔🍔🍔🍔🍔🍔🍔🍔🍔🍔🍔🍔🍔");
            }
        }

        //Eger o id-de mehsul varsa sayini artirir, yoxdursa elave edir
        public void AddProduct(Product new_Product, int count)
        {
            foreach (var item in products)
            {
                if (item.ProductItem.ID == new_Product.ID)
                {
                    item.Count += count;
                    return;
                }
            }

            var basketItem = new BasketItem(new_Product, count);
            products.Add(basketItem);
        }

        public void RemoveProduct(int id)
        {
            foreach (var item in products)
            {
                if (item.ProductItem.ID == id)
                {
                    products.Remove(item);
                    return;
                }
            }
            throw new Exception("Product not found....");
        }

    }
}
