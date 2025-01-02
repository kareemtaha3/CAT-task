using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoListApi.Model;

namespace TodoListApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly TodoListContext _context;
        private readonly ILogger<TodosController> _logger;

        public TodosController(TodoListContext context, ILogger<TodosController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> AddTodo([FromBody] Todo newTodo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                _context.Todos.Add(newTodo);
                await _context.SaveChangesAsync();

                string? path = Url.Action(nameof(GetTodoById), new { id = newTodo.Id });
                if (string.IsNullOrEmpty(path))
                {
                    _logger.LogError("Failed to generate resource URL");
                    return BadRequest("Failed to generate resource URL");
                }
                if (newTodo.DueDate < DateTime.Now)
                {
                    return BadRequest("Due date cannot be in the past");
                }

                if (newTodo.DueDate > DateTime.Now.AddYears(1))
                {
                    return BadRequest("Due date cannot be more than one year in the future");
                }

                return Created(path, newTodo);
            }
            catch (DbUpdateException ex)
            {
                _logger.LogError(ex, "Database update error while adding todo");
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while adding the todo");
            }
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetTodoById(int id)
        {
            var todo = await _context.Todos.FindAsync(id);
            if (todo == null)
            {
                _logger.LogInformation($"Todo item with ID {id} not found");
                return NotFound($"Todo item with ID {id} not found");
            }

            return Ok(todo);
        }

        [HttpGet]
        public async Task<IActionResult> GetTodos()
        {
            var todos = await _context.Todos.ToListAsync();
            return Ok(todos);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateTodoStatus(int id, [FromBody] string newStatus)
        {
            try
            {
                var todo = await _context.Todos.FindAsync(id);
                if (todo == null)
                {
                    _logger.LogInformation($"Todo item with ID {id} not found");
                    return NotFound($"Todo item with ID {id} not found");
                }

                if (newStatus != "pending" && newStatus != "completed")
                {
                    _logger.LogWarning($"Invalid status value '{newStatus}' provided");
                    return BadRequest("Invalid status value. Allowed values are 'pending' or 'completed'");
                }
                if (todo.Status == newStatus)
                {
                    return Conflict("The status is already set to the desired value");
                }
                todo.Status = newStatus;
                await _context.SaveChangesAsync();

                return NoContent();
            }
            catch (DbUpdateException ex)
            {
                _logger.LogError(ex, "Database update error while updating todo status");
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while updating the todo status");
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteTodo(int id)
        {
            try
            {
                var todo = await _context.Todos.FindAsync(id);
                if (todo == null)
                {
                    _logger.LogInformation($"Todo item with ID {id} not found");
                    return NotFound($"Todo item with ID {id} not found");
                }

                _context.Todos.Remove(todo);
                await _context.SaveChangesAsync();

                _logger.LogInformation($"Todo item with ID {id} deleted successfully");
                return NoContent();
            }
            catch (DbUpdateException ex)
            {
                _logger.LogError(ex, "Database update error while deleting todo");
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while deleting the todo");
            }
        }
    }
}