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
    public class CategoryService : IService<CategoryDto>
    {
        private readonly IRepository<Category> irepository;
        private readonly IMapper map;
        public CategoryService(IRepository<Category> irepository, IMapper map)
        {
            this.irepository = irepository;
            this.map = map;
        }
        public CategoryDto Add(CategoryDto entity)
        {
            return map.Map<CategoryDto>(irepository.Add(map.Map<Category>(entity)));
        }

        public void Delete(int id)
        {
            irepository.Delete(id);
        }

        public List<CategoryDto> GetAll()
        {
            return map.Map<List<CategoryDto>>(irepository.GetAll());
        }

        public CategoryDto GetById(int id)
        {
            return map.Map<CategoryDto>(irepository.GetById(id));
        }

        public CategoryDto Update(int id, CategoryDto entity)
        {
            return map.Map<CategoryDto>(irepository.Update(id, map.Map<Category>(entity)));
        }
    }
}
