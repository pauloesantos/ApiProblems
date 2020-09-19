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
            Console.WriteLine(ControllerContext.ActionDescriptor.AttributeRouteInfo.Name);
            //ValidatedCnpj.ValidarCNPJ(cnpj);
            return Ok(ValidatedCnpj.ValidarCNPJ(cnpj));
        }
        [Route("cnpjdigitvalidate/{cnpj}")]
        [HttpGet]
        public IActionResult CnpjDigitValidate(string cnpj)
        {
            Console.WriteLine(ControllerContext.ActionDescriptor.AttributeRouteInfo.Name);
            return Ok(cnpj);
        }
        [Route("isintersects")]
        [HttpPost]
        public IActionResult IsRectanglesIntersects()
        {
            Console.WriteLine(ControllerContext.ActionDescriptor.AttributeRouteInfo.Name);
            return Ok();
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