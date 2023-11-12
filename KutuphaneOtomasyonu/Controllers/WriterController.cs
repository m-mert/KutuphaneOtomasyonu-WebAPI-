using KutuphaneOtomasyonu.Context;
using KutuphaneOtomasyonu.Dtos.CategoryDto;
using KutuphaneOtomasyonu.Dtos.WriterDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KutuphaneOtomasyonu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WriterController : ControllerBase
    {
        private readonly LibraryDBContext _dbContext;

        public WriterController(LibraryDBContext dbContext)
        {
            this._dbContext = dbContext;
        }

        [HttpGet]
        [Route("GetAllAuthors")] //localhost:5700/api/Author/GetAllAuthors
        public ActionResult<IEnumerable<WriterDto>> GetAll() //AuthorDto
        {
            List<WriterDto> writers = _dbContext.Writers.Select(x => new WriterDto
            {
                Id = x.Id,
                FirsName = x.Name,
                LastName = x.Surname
            }).ToList();

            if (writers.Count == 0) return NotFound();

            return writers;
        }
        [HttpGet]
        [Route("GetWriterById")]
        public ActionResult<WriterDto> GetWriterById(Guid id)
        {
            var writer = _dbContext.Writers.FirstOrDefault(x => x.Id == id);
            if (writer == null) return NotFound();
            WriterDto writerDto = new WriterDto() 
            {   Id = writer.Id,
                FirsName=writer.Name,
                LastName=writer.Surname 
            };

            return writerDto;

        }

    }
}
