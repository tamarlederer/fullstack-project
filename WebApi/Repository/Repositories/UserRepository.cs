using Repository.Entities;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class UserRepository : IRepository<User>
    {
        private readonly IContext _context;
        public UserRepository(IContext context)
        {
            this._context = context;
        }

        public User Add(User entity)
        {
            _context.Users.Add(entity);
            _context.Save();
            return entity;
        }

        public void Delete(int id)
        {
            User u=_context.Users.FirstOrDefault(x => x.Id == id);
            _context.Users.Remove(u);
            _context.Save();
        }

        public List<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public User GetById(int id)
        {
            return _context.Users.FirstOrDefault(x => x.Id == id);
        }

        public User Update(int id, User entity)
        {
            User prev = GetById(id);
            prev.Name = entity.Name;
            prev.Email = entity.Email;
            prev.Phone = entity.Phone;
            prev.Password = entity.Password;
            prev.tz = entity.tz;
            prev.Street = entity.Street;
            prev.City = entity.City;
            prev.Number = entity.Number;
            _context.Save(); 
            return prev;
        }
    }
}
