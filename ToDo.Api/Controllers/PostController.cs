using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ToDoAPI.Core.Interfaces;
using ToDoAPI.Infrastructure.Repositories;

namespace ToDoAPI.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IToDoRepository _toDoRepository;
        public PostController(IToDoRepository toDoRepository)
        {
            _toDoRepository = toDoRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetToDos()
        {
            var todo = await _toDoRepository.GetToDos();
            return Ok(todo);
        }
    }
}
