using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MFA.Models;

namespace MFA.Repositories.ProductRepository
{
    public interface IProductRepository
    {
        List<Product> GetAll();
        Product Get(int Id);
        Product Create(Product product);
        Product Update(Product product);
        Product Delete(Product product);
    }
}
