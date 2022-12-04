using AdoTask5.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoTask5.Configurations
{
    public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasColumnType("varchar(max)");
            builder.Property(x => x.EmploymentDate).IsRequired();
            builder.ToTable(x => x.HasCheckConstraint("EmploymentDate", "EmploymentDate>='01.01.1990'"));
            builder.ToTable(x => x.HasCheckConstraint("Premium", "Premium>=0"));
            builder.Property(x => x.Premium).HasDefaultValue(0);
            builder.ToTable(x => x.HasCheckConstraint("Salary", "Salary>0"));
            builder.ToTable(x => x.HasCheckConstraint("Name", "Name<>''"));
            builder.ToTable(x => x.HasCheckConstraint("Surname", "Surname<>''"));
            builder.Property(x => x.Surname).IsRequired().HasColumnType("varchar(max)");



        }
    }
}
