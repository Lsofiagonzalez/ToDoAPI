using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ToDoAPI.Core.Entitities;
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



        [HttpGet("{id}")]
        public async Task<IActionResult> GetToDos(int id)
        {
            var todo = await _toDoRepository.GetToDos(id);
            return Ok(todo);

        }

        [HttpPost]

        public async Task<ActionResult> Post(ToDo todo)
        {
            await _toDoRepository.InsertToDos(todo);
            return Ok(todo);
        }

        [HttpPut]

        public async Task<ActionResult> Put(int id,ToDo todo)
        {
            todo.Id = id;
            await _toDoRepository.UpdateToDo(todo);
            return Ok(todo);
        }
    }
}
