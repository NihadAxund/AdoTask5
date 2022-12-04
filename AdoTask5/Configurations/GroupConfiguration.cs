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
    public class GroupConfiguration : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasColumnType("varchar(10)");
            builder.ToTable(x => x.HasCheckConstraint("Name", "Name<>''"));
            builder.HasIndex(x => x.Name).IsUnique();
            builder.ToTable(x => x.HasCheckConstraint("Rating", "Rating>0 AND Rating<5"));
            builder.ToTable(x => x.HasCheckConstraint("Year", "Year>1 AND Year<5"));
        }
    }
}
