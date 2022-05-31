using Microsoft.AspNetCore.Mvc;

namespace Salsify.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    { 
        private readonly ILogger<ProductsController> _logger;

        public ProductsController(ILogger<ProductsController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Auth")]
        public async Task<IActionResult> GetAsync()
        {

                var requri = "https://app.salsify.com/api/v1/orgs/s-26b1104b-8ce0-44f4-b121-9acb3f679099/products?access_token=DZIf0dDZ-oWwuXwedyhbskz7K0ec6k28udQvjs3158k";

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(requri))
                {
                    var apiResponse = await response.Content.ReadAsStringAsync();
                    return Ok(apiResponse);
                }
            }
                    
        }
    }
}