using LT.Microservices.Day2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LT.Microservices.Day2.Services
{
    public class BookService : IBookService
    {
        public void Create(BookCreateViewModel viewModel)
        {
            
        }

        public void Delete(int id)
        {
            
        }

        public IEnumerable<BookListViewModel> Get()
        {
            return new List<BookListViewModel>();
        }

        public BookListViewModel Get(int id)
        {
            return new BookListViewModel { Id = id, NPages = 285, Price = 100, Title = "C# Programming" };
        }

        public void Update(BookUpdateViewModel viewModel)
        {
            
        }
    }
}
