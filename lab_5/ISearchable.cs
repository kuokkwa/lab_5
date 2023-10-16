using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
    public interface ISearchable
    {
        List<Product> SearchByPriceRange(List<Product> goods, double minPrice, double maxPrice);
        List<Product> SearchByCategory(List<Product> goods, string category);
    }
}
