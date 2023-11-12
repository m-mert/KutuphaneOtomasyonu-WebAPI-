using KutuphaneOtomasyonu.Entities.Base;

namespace KutuphaneOtomasyonu.Entities
{
    public class Book : BaseModel
    {
        public ICollection<WriterBook> BookWriters { get; set; }

        public ICollection<BookCategory> BookCategories { get; set; }

    }
}
