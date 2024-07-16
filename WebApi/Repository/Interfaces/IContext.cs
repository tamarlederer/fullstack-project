using Microsoft.EntityFrameworkCore;
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    //מגדיר את הנתונים
    public interface IContext 
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Doctor> Doctors { get; set; }

        public void save();
    }
}
 