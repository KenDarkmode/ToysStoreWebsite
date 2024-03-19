using Nhom07_ThuyetTrinh.Models;
using System.Collections.Generic;

namespace Nhom07_ThuyetTrinh.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        Product GetById(int id);
        void Add(Product product);

        void Display(Product product);

        void Update(Product product);
        void Delete(int id);
    }
}
