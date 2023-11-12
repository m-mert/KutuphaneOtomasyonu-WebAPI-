using KutuphaneOtomasyonu.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KutuphaneOtomasyonu.EntityTypeConfigurations
{
    public class WriterBookConfiguration : IEntityTypeConfiguration<WriterBook>
    {
        public void Configure(EntityTypeBuilder<WriterBook> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired().UseIdentityColumn(10,1);

            builder.HasOne(x => x.Book).WithMany(x => x.BookWriters).HasForeignKey(x => x.BookId);

            builder.HasOne(x => x.Writer).WithMany(x => x.WriterBooks).HasForeignKey(x => x.WriterId);
        }
    }
}
