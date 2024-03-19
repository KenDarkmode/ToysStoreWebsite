using Nhom07_ThuyetTrinh.Models;
using System.Collections.Generic;

namespace Nhom07_ThuyetTrinh.Repositories
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories();
    }
}
