using Microsoft.AspNetCore.Mvc;
using WebAPIProject.Models;

namespace WebAPIProject.Controllers
{
    [ApiController]
    [Route("Product")]
    public class ProductController : ControllerBase
    {
        private ProjectContext context;
        public ProductController(ProjectContext _context)
        {
            context = _context;
        }

        [HttpPost("AddProduct")]
        public IActionResult AddProduct(Product proDuct)
        {
            context.Products.Add(proDuct);
            context.SaveChanges();
            return Ok(proDuct);
        }

        [HttpDelete("RemoveProduct")]
        public IActionResult RemoveProduct(int proDuctId)
        {
            Product proDuct = context.Products.FirstOrDefault(p => p.ProductId == proDuctId);
            if (proDuct != null)
            {
                context.Products.Remove(proDuct);
                context.SaveChanges();
                return Ok();
            }
            return NotFound();
        }

        [HttpGet("GetProductById")]
        public IActionResult GetProductById(int proDuctId)
        {
            Product proDuct = context.Products.FirstOrDefault(p => p.ProductId == proDuctId);
            if (proDuct != null)
            {
                return Ok(proDuct);
            }
            return NotFound();
        }

        [HttpGet("GetAllProducts")]
        public IActionResult GetAllProducts()
        {
            // List<Product> products = context.Products.ToList();
            // return products;
            return Ok(context.Products.ToList());
        }
        
        [HttpGet("GetProductByName")]
        public IActionResult GetProductByName(string productName)
        {
            // List<Product> products = context.Products.Where(p => p.ProductName.Contains(productName)).ToList();
            // return products;
            var products = context.Products.Where(p => p.ProductName.Contains(productName)).ToList();
            if (products.Any())
            {
                return Ok(products);
            }
            return NotFound();
        }

        // Update product details
        [HttpPut("UpdateProduct")]
        public IActionResult UpdateProduct(Product proDuct)
        {
            context.Products.Update(proDuct);
            context.SaveChanges();
            return Ok(proDuct);
        }

        [HttpPut("UpdateProductPrice")]
        public IActionResult UpdateProductPrice(int productId, decimal newPrice)
        {
            Product proDuct = context.Products.FirstOrDefault(p => p.ProductId == productId);
            if (proDuct != null)
            {
                proDuct.ProductPrice = newPrice;
                context.SaveChanges();
                return Ok(proDuct);
            }
            return NotFound();
        }
        

        [HttpPut("UpdateProductName")]
        public IActionResult UpdateProductName(int productId, string newName)
        {
            Product proDuct = context.Products.FirstOrDefault(p => p.ProductId == productId);
            if (proDuct != null)
            {
                proDuct.ProductName = newName;
                context.SaveChanges();
                return Ok(proDuct);
            }
            return NotFound();
        }
    }
}

            }