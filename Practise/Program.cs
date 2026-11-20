using System.Text;

namespace Practise
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Product p = new Product("Milla sud", 3.20, new DateTime(2025, 11, 5));
            //BasketItem b=new BasketItem(p,5);
            //Basket basket=new Basket();
            Console.OutputEncoding = Encoding.UTF8;

            Basket basket = new Basket();
            basket.AddProduct(new Product("Milla sud", 3.20, new DateTime(2027, 4, 5)), 10);
            basket.AddProduct(new Product("Lays", 4.50, new DateTime(2025, 11, 5)), 16);

            while (true)
            {
                Console.Write(@"
Show basket (S)
Add Product (A)
Delete Product (D) 
Exit (E)
Choose: ");
                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.S)
                {
                    basket.ShowBasket();
                }
                else if (key.Key == ConsoleKey.A)
                {
                    Console.Write("\nEnter product name: ");
                    string p_name = Console.ReadLine();

                    Console.Write("Enter product price: ");
                    double price = double.Parse(Console.ReadLine());
                    Console.Write("Enter expire year: ");
                    int year = int.Parse(Console.ReadLine());
                    Console.Write("Enter expire month: ");
                    int month = int.Parse(Console.ReadLine());
                    Console.Write("Enter expire day: ");
                    int day = int.Parse(Console.ReadLine());

                    var datetime = new DateTime(year, month, day);
                    Product p = new Product(p_name,price,datetime);
                    Console.Write("Enter count: ");
                    int.TryParse(Console.ReadLine(), out int count );
                    basket.AddProduct(p, count);
                }
                else if (key.Key == ConsoleKey.D)
                {
                    Console.Write("Enter id: ");
                    int.TryParse(Console.ReadLine(), out int id);
                    basket.RemoveProduct(id);
                }
                else if (key.Key == ConsoleKey.E)
                {
                    Console.WriteLine("Program finished...");
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong input...");
                }
            }
        }
    }
}
