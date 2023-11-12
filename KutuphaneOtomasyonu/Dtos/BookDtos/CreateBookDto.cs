using KutuphaneOtomasyonu.Entities;

namespace KutuphaneOtomasyonu.Dtos.BookDto;

public class CreateBookDto : BookBaseDto
{
    public CreateBookDto()
    {
        Categories = new List<string>();
    }

    public List<string> WriterName { get; set; }
    public List<string> Categories { get; set; }


}
