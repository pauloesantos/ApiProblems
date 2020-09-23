using System;
using Microsoft.AspNetCore.Mvc;
using ProblemsApi.Helpers;
using ApiProblems.Models;
using System.Threading.Tasks;
using ProblemsApi.Data;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ProblemsApi.Controllers
{
    //Endpoint => URL
    //http://localhost:5000
    //https://localhost:5001
    [ApiController]
    [Route("api/problems")]
    public class ProblemsController : ControllerBase
    {
        #region Injectio dependency BD
        private readonly TodoContext _todoDbContext;

        public ProblemsController(TodoContext todoDbContext)
        {
            _todoDbContext = todoDbContext;
        }
        #endregion

        ///
        /// hello word api get
        ///
        [Route("")]
        [HttpGet]
        public string MeuMetodo()
        {
            return "Olá mundo!";
        }

        #region CNPJ Validate

        ///
        /// CNPJ Validate via Get
        /// Replace value "/" for "%2F"
        ///
        [Route("cnpjvalidate/{cnpj}")]
        [HttpGet]
        public IActionResult CnpjValidate(string cnpj)
        {
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "").Replace("%2F", "");
            if (ValidatedCnpj.ValidarCNPJ(cnpj))
            {
                return Ok("Valid!");
            }
            else
            {
                return BadRequest("Invalid!");
            }
        }

        ///
        /// Cnpj Validade Via Post
        ///
        [Route("cnpjvalidatepost")]
        [HttpPost]
        public IActionResult CnpjValidatePost([FromBody] string cnpj)
        {
            //cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "").Replace("%2F", "");
            if (ValidatedCnpj.ValidarCNPJ(cnpj))
            {
                return Ok("Valid!");
            }
            else
            {
                return BadRequest("Invalid!");
            }
        }
        ///
        /// Validate digits CNPj
        /// Not Work
        ///
        [Route("cnpjdigitvalidate/{cnpj}")]
        [HttpGet]
        public IActionResult CnpjDigitValidate(QueryCnpj cnpj)
        {
            Console.WriteLine(ControllerContext.ActionDescriptor.AttributeRouteInfo.Name);
            return Ok(cnpj);
        }
        #endregion

        [HttpPost]
        [Route("isintersects")]
        public IActionResult IsRectanglesIntersects([FromBody] Rectangles Rect)
        {

            if (Rect.RectA.L.X <= Rect.RectB.R.X && Rect.RectB.L.X <= Rect.RectA.R.X &&
            Rect.RectA.L.Y <= Rect.RectB.R.Y && Rect.RectB.L.Y <= Rect.RectA.R.Y)
            {
                return Ok("True");
            }
            else
            {
                return BadRequest("False");
            }
        }
        [Route("whichintersection")]
        [HttpPost]
        public IActionResult IsintersectionRectangles([FromBody] Rectangles Rect)
        {
            int x = Intersection.CountIntersect(Rect);
            return Ok();

        }

        #region TodoItem

        [Route("todoitems")]
        [HttpPost]
        public async Task<ActionResult<TodoItem>> AddTodo(TodoItem todoItem)
        {
            var itemTodo = new TodoItem
            {
                IsComplete = todoItem.IsComplete,
                Name = todoItem.Name
            };
            _todoDbContext.TodoItems.Add(itemTodo);

            await _todoDbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(AddTodo), new { id = itemTodo.Id }, ItemTo(itemTodo));
        }

        [Route("todoitems")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TodoItem>>> GetTodoItems()
        {
            return await _todoDbContext.TodoItems
            .Select(x => ItemTo(x))
            .ToListAsync();
        }

        [Route("todoitems/{id}")]
        [HttpGet]
        public async Task<ActionResult<TodoItem>> GetTodoItem(long id)
        {
            var todoItem = await _todoDbContext.TodoItems.FindAsync(id);

            if (todoItem == null)
            {
                return NotFound();
            }

            return todoItem;
        }

        [Route("todoitems/{id}")]
        [HttpPut]
        public async Task<IActionResult> UpdateTodoItem(long id, TodoItem todoItem)
        {
            if (id != todoItem.Id)
            {
                return BadRequest();
            }

            var itemTodo = await _todoDbContext.TodoItems.FindAsync(id);
            if (itemTodo == null)
            {
                return NotFound();
            }

            itemTodo.Name = todoItem.Name;
            itemTodo.IsComplete = todoItem.IsComplete;

            try
            {
                await _todoDbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) when (!TodoItemExists(id))
            {
                return NotFound();
            }

            return NoContent();
        }

        [Route("todoitems/{id}")]
        [HttpDelete]
        public async Task<ActionResult<TodoItem>> DeleteTodoItem(long id)
        {
            var todoItem = await _todoDbContext.TodoItems.FindAsync(id);
            if (todoItem == null)
            {
                return NotFound();
            }

            _todoDbContext.TodoItems.Remove(todoItem);
            await _todoDbContext.SaveChangesAsync();

            return todoItem;
        }

        private bool TodoItemExists(long id) =>
                 _todoDbContext.TodoItems.Any(e => e.Id == id);
        private static TodoItem ItemTo(TodoItem todoItem) =>
            new TodoItem
            {
                Id = todoItem.Id,
                Name = todoItem.Name,
                IsComplete = todoItem.IsComplete
            };
        #endregion

        [Route("worldclock")]
        [HttpGet]
        public IActionResult GetWorldClock()
        {
            return Ok();
        }
        [Route("simpleordermanager")]
        [HttpGet]
        public IActionResult GeSimpleOrderManager()
        {
            return Ok();
        }
        [Route("uxprototype")]
        [HttpGet]
        public IActionResult GetUxPrototype()
        {
            return Ok();
        }

    }
}