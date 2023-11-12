using KutuphaneOtomasyonu.Entities;
using KutuphaneOtomasyonu.EntityTypeConfigurations;
using Microsoft.EntityFrameworkCore;

namespace KutuphaneOtomasyonu.Context
{
    public class LibraryDBContext : DbContext
    {
        public LibraryDBContext(DbContextOptions<LibraryDBContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
        public DbSet<BookCategory> BookCategories { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<WriterBook> WriterBooks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .ApplyConfiguration(new BookCategoryConfiguration())
                .ApplyConfiguration(new BookConfiguration())
                .ApplyConfiguration(new CategoryConfiguration())
                .ApplyConfiguration(new WriterBookConfiguration())
                .ApplyConfiguration(new WriterConfiguration());
            
            base.OnModelCreating(modelBuilder);
        }

    }
}
