using Microsoft.AspNetCore.Mvc;
using ShoeSalesAPI.Models;
using ShoeSalesAPI.Services;

namespace ShoeSalesAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShoeController : Controller
    {
        private readonly ShoeService _shoeService;

        public ShoeController(ShoeService shoeService) =>
            _shoeService = shoeService;

        // Finds all products
        [Route("allproducts")]
        [HttpGet]
        public async Task<List<Shoe>> Get() =>
            await _shoeService.GetAllProducts();

        // Filters shoes by their prices, with min and maximum
        [Route("filterprice")]
        [HttpGet]
        public async Task<List<Shoe>> GetPrice(double minPrice, double maxPrice) =>
            await _shoeService.GetShoesByPrice(minPrice, maxPrice);

        // Finds all availible stock and displays it
        [Route("instock")]
        [HttpGet]
        public async Task<IActionResult> GetStock()
        {
            var stock = await _shoeService.GetShoesByAvailibility();

            if (stock == null)
            {
                return NotFound();
            }
            return Ok(stock);

        }


    }
}
