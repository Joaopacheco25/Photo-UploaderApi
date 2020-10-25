using System.Reflection.Metadata.Ecma335;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using photo_uploader.Options;

namespace photo_uploader.Models
{
    public class PhotoUploaderDbContext : DbContext
    {
        public DbSet<ItemPhotoPropertySet> ItemPhotoPropertySet { get; set; }
        public DbSet<ItemPhotos> ItemPhotos { get; set; }
        public DbSet<Items> Items { get; set; }
        public DbSet<Properties> Properties { get; set; }
        public DbSet<TypePropertySet> TypePropertySet { get; set; }
        public DbSet<Types> Types { get; set; }
        private readonly DbOptions _options;

        public PhotoUploaderDbContext(IOptions<DbOptions> options)
        {
            _options = options.Value;
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_options.ConnectionString);
            }
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<ItemPhotos>
                (x =>{
                    x.Property(p => p.FileName).IsRequired();
                    x.Property(p => p.TypeId).IsRequired();
                    x.Property(p => p.Position).IsRequired();
                    x.Property(p => p.CreatedAt).IsRequired();
                    x.Property(p => p.ModifiedAt).IsRequired();
                    x.Property(p => p.IsActive);
                    x.HasOne(d => d.Item)
                        .WithOne(x => x.ItemPhotos)
                        .HasForeignKey<ItemPhotos>(x => x.ItemId)
                        .HasConstraintName("FK_ItemPhotos_Items");;
                    x.HasOne(d => d.type)
                        .WithOne(d => d.ItemPhotos)
                        .HasForeignKey<ItemPhotos>(x => x.TypeId)
                        .HasConstraintName("FK_ItemPhotos_Types");
                });
            base.OnModelCreating(modelBuilder);
        }
    }
}