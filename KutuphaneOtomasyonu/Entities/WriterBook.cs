using KutuphaneOtomasyonu.Entities.Base;

namespace KutuphaneOtomasyonu.Entities
{
    public class WriterBook : BaseModel
    {
        public int Id { get; set; }
        public Guid BookId { get; set; }
        public Book Book { get; set; }
        public Guid WriterId { get; set; }
        public Writer Writer { get; set; }

    }
}
