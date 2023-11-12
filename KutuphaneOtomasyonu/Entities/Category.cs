using KutuphaneOtomasyonu.Entities.Base;

namespace KutuphaneOtomasyonu.Entities
{
    public class Category : BaseModel
    {
        public ICollection<BookCategory> CategoryBooks { get; set; }
    }

}
