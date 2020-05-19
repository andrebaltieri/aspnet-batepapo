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
            return new TodoItem();
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