using Microsoft.AspNetCore.Mvc;
using ReverseStringAPI.Services;
using System.Runtime.InteropServices;

namespace ReverseStringAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StringController : ControllerBase
    {
        private readonly StringService _stringService;

        public StringController()
        {
            _stringService = new StringService();
        }

        [HttpGet("process")]
        public IActionResult ProcessString([FromQuery] string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return BadRequest("Input string cannot be null or empty.");
            }

            var reversed = _stringService.ReverseString(input);
            var isPalindrome = _stringService.IsPalindrome(input);

            var response = new
            {
                ReversedString = reversed,
                IsPalindrome = isPalindrome
            };

            return Ok(response);
        }
    }
}