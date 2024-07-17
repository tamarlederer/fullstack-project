using Repository.Entities;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class CategoryRepository : IRepository<Category>
    {
        private readonly IContext _context;
        public CategoryRepository(IContext context)
        {
            this._context = context;
        }
        public Category Add(Category entity)
        {
            _context.Categories.Add(entity);
            _context.save();
            return entity;  
        }

        public void Delete(int id)
        {
            Category c= _context.Categories.FirstOrDefault(x=>x.Id==id);
            _context.Categories.Remove(c);
            _context.save();
        }

        public List<Category> GetAll()
        {
            return _context.Categories.ToList();
        }

        public Category GetById(int id)
        {
            return _context.Categories.FirstOrDefault(x=>x.Id==id);
        }

        public Category Update(int id, Category entity)
        {
            Category prev=GetById(id);
            prev.Name = entity.Name;
            _context.save();
            return prev;
        }
    }
}
