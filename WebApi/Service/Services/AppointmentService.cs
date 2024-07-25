using AutoMapper;
using Common.Dto;
using Repository.Entities;
using Repository.Interfaces;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class AppointmentService : IService<AppointmentDto>
    {
        private readonly IRepository<Appointment> irepository;
        private readonly IMapper map;
        public AppointmentService(IRepository<Appointment> irepository, IMapper map)
        {
            this.irepository = irepository;
            this.map = map;
        }
        public AppointmentDto Add(AppointmentDto entity)
        {
            return map.Map<AppointmentDto>(irepository.Add(map.Map<Appointment>( entity)));
        }

        public void Delete(int id)
        {
            irepository.Delete(id);
        }

        public List<AppointmentDto> GetAll()
        {
            return map.Map<List<AppointmentDto>>(irepository.GetAll());

        }

        public AppointmentDto GetById(int id)
        {
            return map.Map<AppointmentDto>(irepository.GetById(id));

        }

        public AppointmentDto Update(int id, AppointmentDto entity)
        {
            return map.Map<AppointmentDto>(irepository.Update(id, map.Map<Appointment>(entity)));

        }
    }
}
