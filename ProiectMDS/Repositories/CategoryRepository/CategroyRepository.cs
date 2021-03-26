using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MFA.Models;
using MFA.Contexts;

namespace MFA.Repositories.CategoryRepository
{
    public class CategroyRepository: ICategoryRepository
    {
        public Context _context { get; set; }
        public CategroyRepository(Context context)
        {
            _context = context;
        }
        public Category Create(Category category)
        {
            var result = _context.Add<Category>(category);
            _context.SaveChanges();
            return result.Entity;
        }
        public Category Get(int Id)
        {
            return _context.Categories.SingleOrDefault(x => x.Id == Id);
        }
        public List<Category> GetAll()
        {
            return _context.Categories.ToList();
        }
        public Category Update(Category category)
        {
            _context.Entry(category).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return category;
        }
        public Category Delete(Category category)
        {
            var result = _context.Remove(category);
            _context.SaveChanges();
            return result.Entity;
        }
    }
}
