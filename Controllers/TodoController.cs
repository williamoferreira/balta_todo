using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MeuTodo.Data;
using MeuTodo.Models;

namespace MeuTodo.Controllers
{
    [ApiController]
    [Route("v1")] /* prefixo da rota  */
    public class TodoController : ControllerBase
    {
        [HttpGet]
        [Route("todos")]
        public async Task<IActionResult> Get(
            [FromServices] MeuTodo.Data.AppDbContext context
        )
        {
            var todos = await context.Todos.To
            return new List<Todo>();
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var todo = await context
        }
    }
}