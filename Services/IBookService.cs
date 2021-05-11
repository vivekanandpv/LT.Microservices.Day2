using LT.Microservices.Day2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LT.Microservices.Day2.Services
{
    public interface IBookService
    {
        IEnumerable<BookListViewModel> Get();
        BookListViewModel Get(int id);
        void Create(BookCreateViewModel viewModel);
        void Update(BookUpdateViewModel viewModel);
        void Delete(int id);
    }
}
