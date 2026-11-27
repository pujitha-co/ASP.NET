using EmployeeManagementAPI.Services;
using Microsoft.AspNetCore.Mvc;
using STEP1_ASP.NET.DTO;
using STEP1_ASP.NET.Interface;
using STEP1_ASP.NET.Models;

namespace EmployeeManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]


    public class PracticeController : ControllerBase
    {
        private readonly HttpClient _client;

        public PracticeController(HttpClient client)
        {
            _client = client;
        }

        // 1. HttpClient
        [HttpGet("external-users")]
        public async Task<IActionResult> GetExternalUsers()
        {
            var response = await _client.GetAsync(
                "https://dummyjson.com/users");

            if (!response.IsSuccessStatusCode)
            {
                return StatusCode((int)response.StatusCode);
            }

            var data = await response.Content.ReadAsStringAsync();

            return Content(data, "application/json");
        }

        // 2. HttpRequest
        [HttpGet("request-info")]
        public IActionResult GetRequestInfo()
        {
            var method = HttpContext.Request.Method;

            var path = HttpContext.Request.Path;

            var city = HttpContext.Request.Query["city"];

            return Ok(new
            {
                Method = method,
                Path = path,
                City = city.ToString()
            });
        }

        // 3. HttpResponse
        [HttpGet("response-info")]
        public IActionResult GetResponseInfo()
        {
            HttpContext.Response.Headers["Company"] =
                "ABC Technologies";

            return Ok(new
            {
                Message = "Response sent successfully",
                Status = 200
            });
        }
    }
}