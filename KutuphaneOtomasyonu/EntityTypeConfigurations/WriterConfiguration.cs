using KutuphaneOtomasyonu.Entities;
using KutuphaneOtomasyonu.Entities.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KutuphaneOtomasyonu.EntityTypeConfigurations
{
    public class WriterConfiguration : BaseModelConfiguration<Writer>
    {
        public override void Configure(EntityTypeBuilder<Writer> builder)
        {
            base.Configure(builder);
            
            builder.Property(x => x.Surname).IsRequired().HasMaxLength(30).HasColumnType("nvarchar");
        }
    }
}
