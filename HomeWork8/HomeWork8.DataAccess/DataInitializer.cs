using HomeWork8.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8.DataAccess
{
    public class DataInitializer:DropCreateDatabaseAlways<RegistrationContext>
    {
        private List<Guest> _guests;
        public DataInitializer()
        {
            _guests = new List<Guest>()
            {
                new Guest
                {
                    FullName = "Нурсеитов Аслан",
                    DocumentNumber = "412412321",
                    Purpose = "Просто в туалет"
                }
            };
        }
        protected override void Seed(RegistrationContext context)
        {
            context.Guests.AddRange(_guests);
            base.Seed(context);
        }
    }
}
