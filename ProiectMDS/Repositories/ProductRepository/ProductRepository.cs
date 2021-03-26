using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MFA.Models;
using MFA.Contexts;

namespace MFA.Repositories.ProductRepository
{
    public class ProductRepository: IProductRepository
    {

        public Context _context { get; set; }
        public ProductRepository(Context context)
        {
            _context = context;
        }
        public Product Create(Product product)
        {
            var result = _context.Add<Product>(product);
            _context.SaveChanges();
            return result.Entity;
        }
        public Product Get(int Id)
        {
            return _context.Products.SingleOrDefault(x => x.Id == Id);
        }
        public List<Product> GetAll()
        {
            return _context.Products.ToList();
        }
        public Product Update(Product product)
        {
            _context.Entry(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return product;
        }
        public Product Delete(Product product)
        {
            var result = _context.Remove(product);
            _context.SaveChanges();
            return result.Entity;
        }
    }
}
