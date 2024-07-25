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
    public class UserService : IService<UserDto>
    {
        private readonly IRepository<User> irepository;
        private readonly IMapper map;
        public UserService(IRepository<User> irepository,IMapper map)
        {
            this.irepository = irepository;
            this.map = map;
        }
        public UserDto Add(UserDto entity)
        {
            return map.Map<UserDto>(irepository.Add(map.Map<User>(entity)));
        }

        public void Delete(int id)
        {
            irepository.Delete(id);
        }

        public List<UserDto> GetAll()
        {
            return map.Map<List<UserDto>>(irepository.GetAll());
        }

        public UserDto GetById(int id)
        {
            return map.Map<UserDto> (irepository.GetById(id));
        }

        public UserDto Update(int id, UserDto entity)
        {
            return map.Map<UserDto>(irepository.Update(id, map.Map<User>(entity)));
        }
    }
}
