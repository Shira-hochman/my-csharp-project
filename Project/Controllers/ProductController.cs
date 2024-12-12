using Microsoft.AspNetCore.Mvc;
using Bll_Services;
using Microsoft.AspNetCore.Http;
using Dto_Common_Enteties;

namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductBll a;

        public ProductsController(IProductBll p)
        {
            this.a = p;
        }


        [HttpGet(Name = "getProduct")]
        public async Task<List<Dto_Common_Enteties.ProductDto>> Get()
        {

            return await a.SelectAllAsync();
        }

        [HttpPost("FilterByCategories")]
        public async Task<IActionResult> GetProductsByCategories([FromBody] List<int> categoryIds)
        {
            if (categoryIds == null || categoryIds.Count == 0)
            {
                return BadRequest("No category IDs provided.");
            }

            // קריאה לשכבת השירות כדי לקבל מוצרים מסוננים
            var products = await a.GetProductsByCategoriesAsync(categoryIds);

            return Ok(products);
        }
        [HttpGet("GetPrice")]
        public async Task<IActionResult> GetPrice([FromQuery] int minPrice, [FromQuery] int maxPrice)
        {
            var products = await a.GetPriceAsync(minPrice, maxPrice);
            return Ok(products); // מחזיר JSON בצורה תקינה
        }


    }
}