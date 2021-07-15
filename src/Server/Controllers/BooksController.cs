using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BookStoresWebAPI.Models;
using Microsoft.AspNetCore.Authorization;
using BookStores.Server.Repositories;

namespace BookStoresWebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private BookStoresRepository _bookStoresRepository;

        public BooksController(BookStoresRepository bookStoresRepository)
        {
            _bookStoresRepository = bookStoresRepository;
        }

        // GET: api/Books
        [HttpGet("GetBooks")]
        public ActionResult<IEnumerable<Book>> GetBooks()
        {
            List<Book> BookList = _bookStoresRepository.GetBooks();
            return BookList;
        }

        // GET: api/Books/5
        [HttpGet("GetBook/{id}")]
        public ActionResult<Book> GetBook(int id)
        {
            return _bookStoresRepository.GetBook(id);
        }

        // PUT: api/Books/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("UpdateBook/{id}")]
        public IActionResult UpdateBook(int id, Book Book)
        {
            _bookStoresRepository.UpdateBook(id, Book);
            return NoContent();
        }

        // POST: api/Books
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost("CreateBook")]
        public ActionResult<Book> CreateBook(Book Book)
        {
            _bookStoresRepository.CreateBook(Book);
            return NoContent();
        }

        // DELETE: api/Books/5
        [HttpDelete("DeleteBook/{id}")]
        public ActionResult<Book> DeleteBook(int id)
        {
            _bookStoresRepository.DeleteBook(id);
            return NoContent();
        }

        private bool BookExists(int id)
        {
            return false;
        }

        
    }
}
