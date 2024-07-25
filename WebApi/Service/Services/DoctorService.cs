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
    public class DoctorService : IService<DoctorDto>
    {
        private readonly IRepository<Doctor> irepository;
        private readonly IMapper map;
        public DoctorService(IRepository<Doctor> irepository, IMapper map)
        {
            this.irepository = irepository;
            this.map = map;
        }
        public DoctorDto Add(DoctorDto entity)
        {
            return map.Map<DoctorDto>(irepository.Add(map.Map<Doctor>(entity)));
        }

        public void Delete(int id)
        {
            irepository.Delete(id);
        }

        public List<DoctorDto> GetAll()
        {
            return map.Map<List<DoctorDto>>(irepository.GetAll());
        }

        public DoctorDto GetById(int id)
        {
            return map.Map<DoctorDto>(irepository.GetById(id));
        }

        public DoctorDto Update(int id, DoctorDto entity)
        {
            return map.Map<DoctorDto>(irepository.Update(id, map.Map<Doctor>(entity)));
        }
    }
}
