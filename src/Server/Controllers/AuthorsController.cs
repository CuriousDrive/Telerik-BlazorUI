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
    public class AuthorsController : ControllerBase
    {
        private BookStoresRepository _bookStoresRepository;

        public AuthorsController(BookStoresRepository bookStoresRepository)
        {
            _bookStoresRepository = bookStoresRepository;
        }

        // GET: api/Authors
        [HttpGet("GetAuthors")]
        public ActionResult<IEnumerable<Author>> GetAuthors()
        {
            List<Author> authorList = _bookStoresRepository.GetAuthors();
            return authorList;
        }

        // GET: api/Authors/5
        [HttpGet("GetAuthor/{id}")]
        public ActionResult<Author> GetAuthor(int id)
        {
            return _bookStoresRepository.GetAuthor(id);
        }

        // PUT: api/Authors/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("UpdateAuthor/{id}")]
        public IActionResult UpdateAuthor(int id, Author author)
        {
            _bookStoresRepository.UpdateAuthor(id, author);
            return NoContent();
        }

        // POST: api/Authors
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost("CreateAuthor")]
        public ActionResult<Author> CreateAuthor(Author author)
        {
            _bookStoresRepository.CreateAuthor(author);
            return NoContent();
        }

        // DELETE: api/Authors/5
        [HttpDelete("DeleteAuthor/{id}")]
        public ActionResult<Author> DeleteAuthor(int id)
        {
            _bookStoresRepository.DeleteAuthor(id);
            return NoContent();
        }

        private bool AuthorExists(int id)
        {
            return false;
        }

        
    }
}
