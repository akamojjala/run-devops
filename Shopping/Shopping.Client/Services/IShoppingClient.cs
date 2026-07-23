using Shopping.Client.Models;

namespace Shopping.Client.Services
{
    public interface IShoppingClient
    {
        Task<IEnumerable<Product>> GetProducts();
    }
}
