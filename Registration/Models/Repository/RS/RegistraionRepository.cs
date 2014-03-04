
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace Registration.Models
{
    public class RegistraionRepository : GenericRepository<RegistrationModel>
    {
        public RegistraionRepository(DbContext context) : base(context) { }
    }
}