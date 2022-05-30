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
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("GET"), "https://app.salsify.com/api/v1/orgs/s-26b1104b-8ce0-44f4-b121-9acb3f679099/products/100004"))
                {
                    request.Headers.TryAddWithoutValidation("Authorization", "Bearer " + AppSettings.ApiKey + "");

                    var response = await httpClient.SendAsync(request);

                    return Ok(response);
                }
            }             
        }
    }
}