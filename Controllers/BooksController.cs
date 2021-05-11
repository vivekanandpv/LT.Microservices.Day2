using LT.Microservices.Day2.Models;
using LT.Microservices.Day2.ViewModels;
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
        public ActionResult<IEnumerable<BookListViewModel>> Get()
        {
            return Ok(new List<BookListViewModel>());
        }

        [HttpGet("{id}")]
        public ActionResult<BookListViewModel> Get(int id)
        {
            return Ok(new BookListViewModel { Id = id, NPages = 285, Price = 100, Title = "C# Programming" });
        }

        //  POST
        [HttpPost]
        public IActionResult Create(BookCreateViewModel viewModel)
        {
            return Created($"http://localhost:5000/api/books/145", viewModel);
        }

        //  PUT
        [HttpPut]
        public IActionResult Update(BookUpdateViewModel viewModel)
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
