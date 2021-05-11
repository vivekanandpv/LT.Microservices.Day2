using LT.Microservices.Day2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LT.Microservices.Day2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        //  GET
        //  Get All
        [HttpGet]
        public ActionResult<IEnumerable<Book>> Get()
        {
            return Ok(new List<Book>());
        }

        [HttpGet("{id}")]
        public ActionResult<Book> Get(int id)
        {
            return Ok(new Book { Id = id, NPages = 285, Price = 100, Title = "C# Programming" });
        }

        //  POST
        [HttpPost]
        public IActionResult Create(Book book)
        {
            return Created($"http://localhost:5000/api/books/{book.Id}", book);
        }

        //  PUT
        [HttpPut]
        public IActionResult Update(Book book)
        {
            return Ok();
        }

        //  DELETE

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }
}
