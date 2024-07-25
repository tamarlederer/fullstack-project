using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IService<T>
    {
        public List<T> GetAll();
        public T GetById(int id);
        public T Add(T entity);
        public T Update(int id, T entity);
        public void Delete(int id);
    }
}
