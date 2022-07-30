using Microsoft.AspNetCore.Mvc;

using BAKERY.Application.Contracts;
using BAKERY.Application.Dtos.Requests;

namespace BAKERY.API.Controllers
{
    [Route("buns")]
    public class BunController : ControllerBase
    {
        private readonly IBunService _bunService;
        public BunController(IBunService bunService)
        {
            _bunService = bunService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
            => Ok(await _bunService.GetAll());

        [HttpPost]
        [Route("generate-random")]
        public async Task<IActionResult> GenerateRandomBunsByCount([FromBody]GenerateRandomBunDto request)
        {
            await _bunService.GenerateRandomBunsByCount(request.Count);
            return Ok();
        }
    }
}
