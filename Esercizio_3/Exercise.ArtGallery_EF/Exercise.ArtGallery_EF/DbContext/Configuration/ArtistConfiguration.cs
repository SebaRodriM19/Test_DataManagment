using Exercise.ArtGallery_EF.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.ArtGallery_EF.DbContext.Configuration
{
    public class ArtistConfiguration : IEntityTypeConfiguration<Artist>
    {

        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            builder.HasKey(x => x.IdArtist).HasName("PK_Id_Artist");
            builder.ToTable("Artist");

            builder.Property(x => x.IdArtist);
            builder.Property(x => x.Name).HasMaxLength(50);
            builder.Property(x => x.Country).HasMaxLength(50);
        }
    }
}
