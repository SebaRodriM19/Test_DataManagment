using Exercise.ArtGallery_EF.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.ArtGallery_EF.DbContext.Configuration
{
    public class MuseumConfiguration : IEntityTypeConfiguration<Museum>
    {
        void IEntityTypeConfiguration<Museum>.Configure(EntityTypeBuilder<Museum> builder)
        {
            builder.HasKey(x => x.IdMuseum).HasName("PK_Id_Museum");
            builder.ToTable("Museum");

            builder.Property(x=> x.IdMuseum);
            builder.Property(x => x.MuseumName).HasMaxLength(50);
            builder.Property(x=> x.City).HasMaxLength(50);
        }
    }
}
