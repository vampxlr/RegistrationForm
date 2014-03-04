using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Registration.Models
{
    public class RegistrationContext : DbContext
    {
        public RegistrationContext()
            : base("registration")
        {
        }
        public DbSet<RegistrationModel> Registrations { get; set; }
    }
}