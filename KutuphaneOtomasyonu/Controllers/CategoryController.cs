using KutuphaneOtomasyonu.Context;
using KutuphaneOtomasyonu.Dtos.BookDto;
using KutuphaneOtomasyonu.Dtos.CategoryDto;
using KutuphaneOtomasyonu.Dtos.WriterDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KutuphaneOtomasyonu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly LibraryDBContext _dbContext;

        public CategoryController(LibraryDBContext dbContext)
        {
            this._dbContext = dbContext;
        }

        [HttpGet]
        [Route("GetAllCategories")] //localhost:5700/api/Category/GetAllCategories
        public ActionResult<IEnumerable<CategoryDto>> GetAll() //CategoryDto
        {
            List<CategoryDto> categories = _dbContext.Categories.Select(x => new CategoryDto
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();

            if (categories.Count == 0) return NotFound();

            return categories;
        }
        [HttpGet]
        [Route("GetCategoryById")]
        public ActionResult<CategoryDto> GetCategoryById(Guid id)
        {
            var category = _dbContext.Categories.FirstOrDefault(x => x.Id == id);
            if (category == null) return NotFound();
            CategoryDto categoryDto = new CategoryDto() { Id = category.Id, Name = category.Name };

            return categoryDto;

        }
    }
}
