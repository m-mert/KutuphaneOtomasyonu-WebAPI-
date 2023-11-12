using KutuphaneOtomasyonu.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KutuphaneOtomasyonu.EntityTypeConfigurations
{
    public class BookConfiguration : BaseModelConfiguration<Book>
    {
        public override void Configure(EntityTypeBuilder<Book> builder)
        {
            base.Configure(builder);
            
        }

    }
}
