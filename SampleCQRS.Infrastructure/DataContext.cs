using Microsoft.EntityFrameworkCore;
using SampleCQRS.Core;

namespace SampleCQRS.Infrastructure
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Product { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<UserInfo>(entity =>
            //{
            //    entity.HasNoKey();
            //    entity.ToTable("UserInfo");
            //    entity.Property(e => e.UserId).HasColumnName("UserId");
            //    entity.Property(e => e.UserName).HasMaxLength(30).IsUnicode(false);
            //    entity.Property(e => e.Email).HasMaxLength(50).IsUnicode(false);
            //    entity.Property(e => e.Password).HasMaxLength(20).IsUnicode(false);
            //    entity.Property(e => e.CreatedDate).IsUnicode(false);
            //});

        }

    }
}
