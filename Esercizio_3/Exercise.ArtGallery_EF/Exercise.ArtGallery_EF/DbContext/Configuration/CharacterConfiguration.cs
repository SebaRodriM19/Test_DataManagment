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
    public class CharacterConfiguration : IEntityTypeConfiguration<Character>
    {

        public void Configure(EntityTypeBuilder<Character> builder)
        {
            builder.HasKey(x => x.IdCharachter).HasName("PK_Id_Character");
            builder.ToTable("Character");

            builder.Property(x => x.IdCharachter);
            builder.Property(x => x.Name).HasMaxLength(50);
        }
    }
}
