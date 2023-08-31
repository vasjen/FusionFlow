
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [ApiController]
    public class TransferController : Controller
{
    private readonly HttpClient _httpClient;
        private readonly ILogger<TransferController> _logger;

        public TransferController(IHttpClientFactory httpClientFactory, ILogger<TransferController> logger)
    {
        _httpClient = httpClientFactory.CreateClient("api");
        _logger = logger;
        
    }

    [HttpPost, Route("[action]")]
    public async Task<IActionResult> CheckPalindrome([FromForm]string s)
    {
        
        // var request = s.ToStringDto();
        // HttpResponseMessage response = await _httpClient.PostAsJsonAsync($"/Main/isPalindrome",request);
        // string result = await response.Content.ReadAsStringAsync();
        // _logger.LogInformation(result);
        return new JsonResult("ok");
    }
    [HttpPost, Route("[action]")]
    public async Task<IActionResult> SumEverySecond([FromForm]string s)
    {
        // var request = s.ToArrayDto();
        // HttpResponseMessage response = await _httpClient.PostAsJsonAsync($"/Main/SumEverySecond", request);
        // string result = await response.Content.ReadAsStringAsync();
        // _logger.LogInformation(result);
        return new JsonResult("result");
    }
    [HttpPost, Route("[action]")]
    public async Task<IActionResult> Sort([FromForm]string s)
    {
        // var request = s.ToArrayDto();
        // HttpResponseMessage response = await _httpClient.PostAsJsonAsync($"/Main/SortArray", request); 
        // string result = await response.Content.ReadAsStringAsync();
    //    _logger.LogInformation(result);
        return new JsonResult("result");
}

}
}