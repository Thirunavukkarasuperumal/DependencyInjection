using MvcConcepts.Entities;
using MvcConcepts.Mappings;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace MvcConcepts.DBContext
{
    public class ClientDbContext : DbContext, IClientDbContext
    {
        public virtual IDbSet<Enrollment> Enrollments { get; set; }

        public ClientDbContext(string clientDbConnectionString)
           : base(clientDbConnectionString)
        {
            Database.SetInitializer<ClientDbContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EnrollmentMapping());
        }

    }
}
