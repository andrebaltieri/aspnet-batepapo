using Microsoft.AspNetCore.Mvc;
using Todos.Models;

namespace Todos.Controllers
{
    [Route("todos")]
    public class HomeController : ControllerBase
    {
        [Route("")]
        [HttpGet]
        public TodoItem Get()
        {
            var todo = new TodoItem();
            todo.User = "Renan";
            todo.Id = 20;
            todo.Text = "Fizemos deploy no Azure!";
            return todo;
        }

        [Route("{id}")]
        [HttpGet]
        public TodoItem Get(int id)
        {
            return new TodoItem
            {
                Id = id
            };
        }

        [Route("")]
        [HttpPost]
        public TodoItem Post([FromBody] TodoItem item)
        {
            return item;
        }

        [Route("{id}")]
        [HttpPut]
        public TodoItem Put(int id, [FromBody] TodoItem item)
        {
            return item;
        }

        [Route("{id}")]
        [HttpDelete]
        public TodoItem Delete(int id)
        {
            return new TodoItem();
        }
    }
}