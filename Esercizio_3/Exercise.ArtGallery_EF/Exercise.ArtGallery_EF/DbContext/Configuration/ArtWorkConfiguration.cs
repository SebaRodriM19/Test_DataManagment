using Exercise.ArtGallery_EF.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace Exercise.ArtGallery_EF.DbContext.Configuration
{
    public class ArtWorkConfiguration : IEntityTypeConfiguration<Artwork>
    {

        public void Configure(EntityTypeBuilder<Artwork> builder)
        {
            builder.HasKey(x => x.IdArtwork).HasName("PK_Id_Artwork");
            builder.ToTable("Artwork");

            builder.Property(x => x.IdArtwork);
            builder.Property(x => x.Name).HasMaxLength(50);

            builder.HasOne(x => x.IdMuseum).WithMany(x => x.Museums).HasForeignKey(x => x.IdMuseum);
            builder.HasOne(x => x.IdArtist).WithMany(x => x.Artits).HasForeignKey(x => x.IdArtist);
            builder.HasOne(x => x.IdCharacter).WithMany(x => x.Characters).HasForeignKey(x => x.IdCharacter);

        }
    }
}
