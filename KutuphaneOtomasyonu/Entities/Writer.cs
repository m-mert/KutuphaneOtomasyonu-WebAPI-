using KutuphaneOtomasyonu.Entities.Base;

namespace KutuphaneOtomasyonu.Entities
{
    public class Writer : BaseModel
    {
        public string Surname { get; set; }

        public ICollection<WriterBook> WriterBooks { get; set; }

    }
}
