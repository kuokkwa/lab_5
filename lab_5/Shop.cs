using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
    public class Shop: ISearchable
    {
        public List<Product> goods;
        public List<User> users;
        public List<Order> orders;

        public Shop()
        {
            goods = new List<Product>();
            users = new List<User>();
            orders = new List<Order>();
        }

        public void AddProduct(Product product)
        {
            goods.Add(product);
        }

        public void AddUser(User user)
        {
            users.Add(user);
        }

        public void PlaceOrder(User user, List<Product> selectedGoods, List<int> amount)
        {
            Order order = new Order();
            for(int i = 0; i < selectedGoods.Count; i++)
            {
                order.Goods.Add(selectedGoods[i]);
                order.Amount.Add(amount[i]);
                order.TotalPrice += selectedGoods[i].Price * amount[i];
            }
            user.PurchaseHistory.Add(order);
            orders.Add(order);
        }

        public void MarkOrderAsDelivered(Order order)
        {
            order.IsDelivered = true;
        }

        public List<Product> SearchByPriceRange(List<Product> products, double minPrice, double maxPrice)
        {
            return products.Where(p => p.Price >= minPrice && p.Price <= maxPrice).ToList();
        }

        public List<Product> SearchByCategory(List<Product> products, string category)
        {
            return products.Where(p => p.Category == category).ToList();
        }
    }
}
