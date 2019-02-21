using MvcConcepts.Entities;
using MvcConcepts.Mappings;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace MvcConcepts.DBContext
{
    public interface IClientDbContext
    {
        IDbSet<Enrollment> Enrollments { get; set; }

    }
}
