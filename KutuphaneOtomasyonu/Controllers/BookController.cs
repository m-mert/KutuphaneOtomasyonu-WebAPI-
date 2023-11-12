using KutuphaneOtomasyonu.Context;
using KutuphaneOtomasyonu.Dtos.BookDto;
using KutuphaneOtomasyonu.Dtos.CategoryDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KutuphaneOtomasyonu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly LibraryDBContext _dbContext;

        public BookController(LibraryDBContext dbContext)
        {
            this._dbContext = dbContext;
        }

        [HttpGet]
        [Route("GetAllBooks")] //localhost:5700/api/Book/GetAllBooks
        public ActionResult<IEnumerable<BookDto>> GetAll() //BookDto
        {
            List<BookDto> books = _dbContext.Books.Select(x => new BookDto
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();

            if (books.Count == 0) return NotFound();

            return books;
        }
        [HttpGet]
        [Route("GetBookById")]
        public ActionResult<BookDto>GetBookById(Guid id)
        {
            var book = _dbContext.Books.FirstOrDefault(x => x.Id == id);
            if (book == null) return NotFound();
            BookDto bookDto =new BookDto() { Id=book.Id, Name=book.Name };

            return bookDto;
        }

    }
}
