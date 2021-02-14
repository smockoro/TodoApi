using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using TodoApi.Domain.Model;
using TodoApi.Domain.App;

namespace TodoApi.Controllers
{
    [ApiController]
    [Route("api/todo")]
    public class TodoController : ControllerBase
    {
        private static readonly List<Todo> SampleTodos = new List<Todo>{
            new Todo() { Id = 1, Name = "sample1"},
            new Todo() { Id = 2, Name = "sample2"},
            new Todo() { Id = 3, Name = "sample3"},
            new Todo() { Id = 4, Name = "sample4"},
            new Todo() { Id = 5, Name = "sample5"},
        };

        private readonly ILogger<TodoController> _logger;
        private readonly ITodoUsecase _todoUsecase;

        public TodoController(ILogger<TodoController> logger, ITodoUsecase todoUsecase)
        {
            _logger = logger;
            _todoUsecase = todoUsecase;
        }

        [HttpGet]
        public IEnumerable<Todo> Get()
        {
            return SampleTodos;
        }

        [HttpGet("{Id}", Name = "Todo")]
        public ActionResult<Todo> GetById(Int64 id)
        {
            Todo todo = SampleTodos.Find(todo => todo.Id == id);
            if (todo == null)
            {
                return NotFound();
            }
            _logger.LogInformation(todo.ToString());
            return Ok(todo);
        }

        [HttpGet("usecase", Name = "TodoUsecase")]
        public ActionResult<Todo> GetFromUsecase()
        {
            return Ok(_todoUsecase.findTodo());
        }
    }
}