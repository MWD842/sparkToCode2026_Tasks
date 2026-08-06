using Microsoft.AspNetCore.Mvc;
using WebAPIProject.Models;

namespace WebAPIProject.Controllers
{
    [ApiController]
    [Route("Category")]
    public class CategoryController : ControllerBase
    {
        private ProjectContext context;
        public CategoryController(ProjectContext _context)
        {
            context = _context;
        }

        [HttpPost("AddCategory")]
        public IActionResult AddCategory(Category cateGory)
        {
            context.Categories.Add(cateGory);
            context.SaveChanges();
            return Ok(cateGory);
        }

        [HttpDelete("RemoveCategory")]
        public IActionResult RemoveCategory(int categoryId)
        {
            Category cateGory = context.Categories.FirstOrDefault(c => c.CategoryId == categoryId);
            if (cateGory != null)
            {
                context.Categories.Remove(cateGory);
                context.SaveChanges();
                return Ok();
            }
            return NotFound();
        }

        [HttpGet("GetCategoryById")]
        public IActionResult GetCategoryById(int categoryId)
        {
            Category cateGory = context.Categories.FirstOrDefault(c => c.CategoryId == categoryId);
            if (cateGory != null)
            {
                return Ok(cateGory);
            }
            return NotFound();
        }

        [HttpGet("GetAllCategories")]
        public IActionResult GetAllCategories()
        {
            // List<Category> categories = context.Categories.ToList();
            // return categories;
            return Ok(context.Categories.ToList());
        }

        [HttpPut("UpdateCategory")]
        public IActionResult UpdateCategory(Category cateGory)
        {
            context.Categories.Update(cateGory);
            context.SaveChanges();
            return Ok(cateGory);
        }

        [HttpPut("UpdateCategoryName")]
        public IActionResult UpdateCategoryName(int categoryId, string newName)
        {
            Category cateGory = context.Categories.FirstOrDefault(c => c.CategoryId == categoryId);
            if (cateGory != null)
            {
                cateGory.CategoryName = newName;
                context.SaveChanges();
                return Ok(cateGory);
            }
            return NotFound();
        }
    }
}
