using ProjetoCleanArchiteture.Domain.Entities;

namespace ProjetoCleanArchiteture.Domain.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProducts();
        Task<Product> GetById(int? id);
        void Add(Product product);
        void Update(Product product);
        void Remove(Product product);
    }
}
