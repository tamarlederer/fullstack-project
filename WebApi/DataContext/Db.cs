


using Microsoft.EntityFrameworkCore;
using Repository.Entities;
using Repository.Interfaces;

namespace DataContext
{
    public class Db : DbContext, IContext
    {
        public DbSet<User> Users { get ; set ; }
        public DbSet<Doctor> Doctors { get ; set ; }
        public DbSet<Appointment> Appointments { get ; set ; }
        public DbSet<Category> Categories { get ; set ; }

        public void Save()
        {
            SaveChanges();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=schedulingAppointmentsDb;trusted_connection=true; TrustServerCertificate=True;");
        }
    }
}