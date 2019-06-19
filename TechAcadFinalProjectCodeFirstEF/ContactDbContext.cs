using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Here the context is defined and associated with my connection string in the App.config.
 */

namespace TechAcadFinalProjectCodeFirstEF
{
    class ContactDbContext : DbContext
    {
        public ContactDbContext(): base("name=ContactContext") {  }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactNumber> ContactNumbers { get; set; }
    }
}
