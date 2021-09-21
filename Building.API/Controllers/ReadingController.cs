using Building.BLL.IServices;
using Building.Domain.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Building.API.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class ReadingController : ControllerBase
    {
        private readonly IReadingService _readingService;

        public ReadingController(IReadingService readingService)
        {
            _readingService = readingService;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _readingService.GetAllAsync();

            return Ok(data);
        }

        [HttpGet]
        [Route("api/[controller]/Filter")]
        public async Task<IActionResult> GetAll([FromQuery] ReadingDto readingDto)
        {
            var data = await _readingService.GetAllFilteredAsync(readingDto);

            return Ok(data);
        }
    }
}
