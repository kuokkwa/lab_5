namespace lab_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();

            Product product1 = new Product
            {
                Name = "Pasta shells",
                Price = 60.0,
                Description = "Shells are great with vegetable-based sauces and heartier meat.",
                Category = "Food",
            };

            Product product2 = new Product
            {
                Name = "Pencil",
                Price = 10.0,
                Description = "A writing utensil with a graphite lead embedded in a wooden shaft.",
                Category = "Stationery",
            };

            Product product3 = new Product
            {
                Name = "Wet wipes",
                Price = 20.0,
                Description = "Refreshing wet wipes.",
                Category = "Hygiene",
            };

            shop.AddProduct(product1);
            shop.AddProduct(product2);
            shop.AddProduct(product3);

            User user1 = new User("user1", "password1");
            User user2 = new User("user2", "password2");
            User user3 = new User("user3", "password3");

            shop.AddUser(user1);
            shop.AddUser(user2);
            shop.AddUser(user3);

            List<Product> selectedGoods = new List<Product> { product1, product2 };
            List<int> amount = new List<int> { 3, 2, 1 };

            shop.PlaceOrder(user1, selectedGoods, amount);

            Order order = shop.orders[0];
            shop.MarkOrderAsDelivered(order);

            List<Product> foundProducts = shop.SearchByPriceRange(shop.goods, 10.0, 25.0);
            Console.WriteLine("Goods found by price range:");
            foreach (Product product in foundProducts)
            {
                Console.WriteLine(product.Name);
            }

            foundProducts = shop.SearchByCategory(shop.goods, "Food");
            Console.WriteLine("\nGoods found by category:");
            foreach (Product product in foundProducts)
            {
                Console.WriteLine(product.Name);
            }

            Console.ReadKey();
        }
    }
}