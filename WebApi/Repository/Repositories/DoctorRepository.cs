using Repository.Entities;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class DoctorRepository : IRepository<Doctor>
    {
        private readonly IContext _context;
        public DoctorRepository(IContext context)
        {
            this._context = context;
        }
        public Doctor Add(Doctor entity)
        {
            _context.Doctors.Add(entity);
            _context.Save();
            return entity;
        }

        public void Delete(int id)
        {
            Doctor d = _context.Doctors.FirstOrDefault(x => x.Id == id);
            _context.Doctors.Remove(d);
            _context.Save();
        }

        public List<Doctor> GetAll()
        {
            return _context.Doctors.ToList();
        }

        public Doctor GetById(int id)
        {
            return _context.Doctors.FirstOrDefault(x => x.Id == id);
        }

        public Doctor Update(int id, Doctor entity)
        {
            Doctor prev=GetById(id);
            prev.Name = entity.Name;
            prev.Email = entity.Email;
            prev.Password = entity.Password;
            prev.Phone = entity.Phone;
            prev.Description = entity.Description;
            prev.Category = entity.Category;
            prev.Street = entity.Street;
            prev.Number = entity.Number;
            prev.City = entity.City;
            prev.ReceptionDays = entity.ReceptionDays;
            _context.Save();
            return prev;
        }
    }
}
