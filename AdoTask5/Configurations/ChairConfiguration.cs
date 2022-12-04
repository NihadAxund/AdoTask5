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
    public class ChairConfiguration : IEntityTypeConfiguration<Chair>
    {
        public void Configure(EntityTypeBuilder<Chair> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasColumnType("varchar(100)");
            builder.HasIndex(x => x.Name).IsUnique();
            builder.Property(x => x.Financing).HasDefaultValue(0);
            builder.ToTable(x => x.HasCheckConstraint("Name", "Name<>''"));
            builder.ToTable(x => x.HasCheckConstraint("Financing", "Financing>=0"));
        }
    }
}
