using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LessonController: ControllerBase
    {
        public LessonController()
        {
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