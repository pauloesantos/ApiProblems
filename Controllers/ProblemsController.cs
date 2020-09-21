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
            Console.WriteLine(ControllerContext.ActionDescriptor.AttributeRouteInfo.Name);
            return "Olá mundo";
        }
        [Route("cnpjvalidate/{cnpj}")]
        [HttpGet]
        public IActionResult CnpjValidate(string cnpj)
        {
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
            int x = Intersection.CountIntersect(Rect);
            if (x > 0)
            // if (Rect.RectA.X1 <= Rect.RectB.X2 && Rect.RectB.X1 <= Rect.RectA.X2 &&
            //  Rect.RectA.Y1 <= Rect.RectB.Y2 && Rect.RectB.Y1 <= Rect.RectA.Y2)
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
        public IActionResult IsintersectionRectangles()
        {
            Console.WriteLine(ControllerContext.ActionDescriptor.AttributeRouteInfo.Name);
            return Ok();
        }
        [Route("todo/{task}")]
        [HttpPost]
        public IActionResult AddTodo(string task)
        {
            Console.WriteLine(ControllerContext.ActionDescriptor.AttributeRouteInfo.Name);
            return Ok(task);
        }
        [Route("todo")]
        [HttpGet]
        public IActionResult GetListTodo()
        {
            Console.WriteLine(ControllerContext.ActionDescriptor.AttributeRouteInfo.Name);
            return Ok();
        }
        [Route("todo/{id}")]
        [HttpPut]
        public IActionResult UpadteTodo(int id)
        {
            Console.WriteLine(ControllerContext.ActionDescriptor.AttributeRouteInfo.Name);
            return Ok();
        }
        [Route("todo/{id}")]
        [HttpDelete]
        public IActionResult DeleteTodo(int id)
        {
            Console.WriteLine(ControllerContext.ActionDescriptor.AttributeRouteInfo.Name);
            return Ok();
        }
        [Route("worldclock")]
        [HttpGet]
        public IActionResult GetWorldClock()
        {
            Console.WriteLine(ControllerContext.ActionDescriptor.AttributeRouteInfo.Name);
            return Ok();
        }
        [Route("simpleordermanager")]
        [HttpGet]
        public IActionResult GeSimpleOrderManager()
        {
            Console.WriteLine(ControllerContext.ActionDescriptor.AttributeRouteInfo.Name);
            return Ok();
        }
        [Route("uxprototype")]
        [HttpGet]
        public IActionResult GetUxPrototype()
        {
            Console.WriteLine(ControllerContext.ActionDescriptor.AttributeRouteInfo.Name);
            return Ok();
        }

    }
}