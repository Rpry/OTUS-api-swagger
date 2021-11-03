using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LessonController: ControllerBase
    {
        private readonly ILogger<LessonController> _logger;
        private IMapper _mapper;

        public LessonController(Logger<LessonController> logger, IMapper mapper)
        {
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Add(LessonModel lessonDto)
        {
            return Ok();
        }
        
        [HttpPut("{id}")]
        public async Task<IActionResult> Edit(int id, LessonModel lessonDto)
        {
            return Ok();
        }
    }
}