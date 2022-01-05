using GestionEmploye.Common.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace GestionEmploye.DataAccess
{
    public class EmployeContexte : DbContext
    {
        public DbSet<Employe> Employe { get; set; }
        public DbSet<Role> Role { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
              "Data Source= (localdb)\\MSSQLLocalDB; Initial Catalog=EFCoreGestionEmploye");
        }
    }
}
