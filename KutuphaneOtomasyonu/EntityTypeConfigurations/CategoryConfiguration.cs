using KutuphaneOtomasyonu.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KutuphaneOtomasyonu.EntityTypeConfigurations
{
    public class CategoryConfiguration : BaseModelConfiguration<Category>
    {
        public override void Configure(EntityTypeBuilder<Category> builder)
        {
            base.Configure(builder);

        }
    }
}
