using Repository.Entities;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class AppointmentRepository : IRepository<Appointment>
    {
        private readonly IContext _context;
        public AppointmentRepository(IContext context) 
        {  
            this._context = context;
        }
        public Appointment Add(Appointment entity)
        {
            _context.Appointments.Add(entity);
            _context.Save();
            return entity;
        }

        public void Delete(int id)
        {
            Appointment a = _context.Appointments.FirstOrDefault(x => x.Id == id);
            _context.Appointments.Remove(a);
            _context.Save();
        }

        public List<Appointment> GetAll()
        {
            return _context.Appointments.ToList();
        }

        public Appointment GetById(int id)
        {
            return _context.Appointments.FirstOrDefault(x => x.Id == id);
        }

        public Appointment Update(int id, Appointment entity)
        {
            Appointment prev=GetById(id);
            prev.Date = entity.Date;
            prev.Doctor = entity.Doctor;
            prev.User= entity.User;
            prev.Status = entity.Status;
            _context.Save();
            return prev;
        }
    }
}
