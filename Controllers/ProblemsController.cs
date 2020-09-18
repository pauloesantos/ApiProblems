using Microsoft.AspNetCore.Mvc;

namespace ProblemsApi.Controllers
{
    [Route("api/problems")]
    public class ProblemsController : ControllerBase
    {
        [Route("/cnpjvalidate/{cnpj}")]
        [HttpGet]
        public IActionResult CnpjValidate(string cnpj)
        {
            return Ok(cnpj);
        }
        [Route("/cnpjdigitvalidate/{cnpj}")]
        [HttpGet]
        public IActionResult CnpjDigitValidate(string cnpj)
        {
            return Ok(cnpj);
        }
        [Route("/isintersects/")]
        [HttpPost]
        public IActionResult IsRectanglesIntersects()
        {
            return Ok();
        }
        [Route("/whichintersection/")]
        [HttpPost]
        public IActionResult IsintersectionRectangles()
        {
            return Ok();
        }
        [Route("/todo/{task}")]
        [HttpPost]
        public IActionResult AddTodo(string task)
        {
            return Ok(task);
        }
        [Route("/todo/")]
        [HttpGet]
        public IActionResult GetListTodo()
        {
            return Ok();
        }
        [Route("/todo/{id}")]
        [HttpPut]
        public IActionResult UpadteTodo(int id)
        {
            return Ok();
        }
        [Route("/todo/{id}")]
        [HttpDelete]
        public IActionResult DeleteTodo(int id)
        {
            return Ok();
        }
        [Route("/worldclock/")]
        [HttpGet]
        public IActionResult GetWorldClock()
        {
            return Ok();
        }
        [Route("/simpleordermanager/")]
        [HttpGet]
        public IActionResult GeSimpleOrderManager()
        {
            return Ok();
        }
        [Route("/uxprototype/")]
        [HttpGet]
        public IActionResult GeUxPrototype()
        {
            return Ok();
        }
    }
}