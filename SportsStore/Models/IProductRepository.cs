using System.Linq;

namespace SportsStore.Models
{
    public class IProductRepository
    {
        IQueryable<Product> Products { get; }
    }
}
