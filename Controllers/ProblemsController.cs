using System;
using Microsoft.AspNetCore.Mvc;
using ProblemsApi.Helpers;

namespace ProblemsApi.Controllers
{
    //Endpoint => URL
    //http://localhost:5000
    //https://localhost:5001
    [ApiController]
    [Route("api/problems")]
    public class ProblemsController : ControllerBase
    {
        [Route("")]
        public string MeuMetodo()
        {
            return "Olá mundo!";
        }
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
        [Route("cnpjdigitvalidate/{cnpj}")]
        [HttpGet]
        public IActionResult CnpjDigitValidate(QueryCnpj cnpj)
        {
            Console.WriteLine(ControllerContext.ActionDescriptor.AttributeRouteInfo.Name);
            return Ok(cnpj);
        }

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
        [Route("todo/{task}")]
        [HttpPost]
        public IActionResult AddTodo(string task)
        {
            return Ok(task);
        }
        [Route("todo")]
        [HttpGet]
        public IActionResult GetListTodo()
        {
            return Ok();
        }
        [Route("todo/{id}")]
        [HttpPut]
        public IActionResult UpadteTodo(int id)
        {
            return Ok();
        }
        [Route("todo/{id}")]
        [HttpDelete]
        public IActionResult DeleteTodo(int id)
        {
            return Ok();
        }
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