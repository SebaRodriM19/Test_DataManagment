using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise.ArtGallery_EF.Model;
using Exercise.ArtGallery_EF.DbContext.Configuration;

namespace Exercise.ArtGallery_EF.DbContext
{
    public class ArtGalleryContext
    {
        public virtual DbSet<Museum> Museums { get; set; }
        public virtual DbSet<Artist> Artits { get; set; }
        public virtual DbSet<Character> Characters { get; set; }
        public virtual DbSet<Artwork> Artworks { get; set; }
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new MuseumConfiguration());
        modelBuilder.ApplyConfiguration(new ArtistConfiguration());
        modelBuilder.ApplyConfiguration(new CharacterConfiguration());
        modelBuilder.ApplyConfiguration(new ArtWorkConfiguration());
    }
}
