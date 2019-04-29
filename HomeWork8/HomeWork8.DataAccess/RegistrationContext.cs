using HomeWork8.Models;
using System;
using System.Data.Entity;
using System.Linq;
namespace HomeWork8.DataAccess
{
    public class RegistrationContext : DbContext
    {
        public RegistrationContext()
            : base("name=RegistrationContext")
        {
            Database.SetInitializer<RegistrationContext>(new DataInitializer());
        }

        public DbSet<Guest> Guests { get; set; }
    }
}