using KutuphaneOtomasyonu.Entities.Base;

namespace KutuphaneOtomasyonu.Entities
{
    public class BookCategory : BaseModel
    {
        public int Id { get; set; }
        public Guid BookId { get; set; }
        public Book Book { get; set; }
        public Guid CategoryId { get; set; }
        public Category CAtegories { get; set; }
    }
}
