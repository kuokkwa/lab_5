using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
    public class Order
    {
        public List<Product> Goods { get; set; }
        public List<int> Amount { get; set; }
        public double TotalPrice { get; set; }
        public bool IsDelivered { get; set; }

        public Order()
        {
            Goods = new List<Product>();
            Amount = new List<int>();
            TotalPrice = 0;
            IsDelivered = false;
        }
    }
}
