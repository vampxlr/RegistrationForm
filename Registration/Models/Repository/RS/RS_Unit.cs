using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Registration.Models
{
    public class RS_Unit : IDisposable
    {
        private RegistrationContext _context = new RegistrationContext();
        
        private IRepository<RegistrationModel> _Registration = null;


        public IRepository<RegistrationModel> Registrations
        {
            get 
            {
                if (this._Registration == null)
                {
                    this._Registration = new GenericRepository<RegistrationModel>(this._context);
                }
                return this._Registration;
            }
        
        }

     

        public void SaveChanges()
        {
            this._context.SaveChanges();
        }

        public void Dispose()
        {
            if (this._context != null)
            {
                this._context.Dispose();
            }
        }

    }

}