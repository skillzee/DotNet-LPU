using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using To_Do_Api_App.Models;

namespace To_Do_Api_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {

        static List<TodoItem> todos = new List<TodoItem>
        {
            new TodoItem
            {
                Id = 101,
                Title = "Study Web Api",
                IsCompleted = false            },
            new TodoItem
            {
                Id = 102,
                Title = "Eat Food",
                IsCompleted = true
            },
            new TodoItem
            {
                Id = 103,
                Title = "Drink Tea",
                IsCompleted = true
            }
        };



        [HttpGet]
        public ActionResult<List<TodoItem>> GetTodos()
        {
            return todos;
        }


        [HttpPost]
        public ActionResult<TodoItem> CreateTodo(TodoItem todo)
        {
            todos.Add(todo);
            return todo;
        }


        [HttpGet("{id}")]
        public ActionResult<TodoItem> GetTodoById(int id)
        {
            var todo  = todos.FirstOrDefault(x => x.Id == id);
            if(todo == null)
            {
                return NotFound();
            }
            return todo;
        }
    }
}
