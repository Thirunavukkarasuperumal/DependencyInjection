using MvcConcepts.Entities;
using System.Data.Entity.ModelConfiguration;
namespace MvcConcepts.Mappings
{
    public class EnrollmentMapping : EntityTypeConfiguration<Enrollment>
    {
        public EnrollmentMapping()
        {
            ToTable("Enrollment");
            HasKey(x => x.UserId);
        }
    }
}
