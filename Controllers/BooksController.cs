using LT.Microservices.Day2.Models;
using LT.Microservices.Day2.Services;
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
        private readonly IBookService _service;

        public BooksController(IBookService service)
        {
            _service = service;
        }


        //  GET
        //  Get All
        [HttpGet]
        public ActionResult<IEnumerable<BookListViewModel>> Get()
        {
            return Ok(_service.Get());
        }

        [HttpGet("{id}")]
        public ActionResult<BookListViewModel> Get(int id)
        {
            return Ok(_service.Get(id));
        }

        //  POST
        [HttpPost]
        public IActionResult Create(BookCreateViewModel viewModel)
        {
            _service.Create(viewModel);
            return Ok();
        }

        //  PUT
        [HttpPut]
        public IActionResult Update(BookUpdateViewModel viewModel)
        {
            _service.Update(viewModel);
            return Ok();
        }

        //  DELETE

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return Ok();
        }
    }
}
