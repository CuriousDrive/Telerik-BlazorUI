using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BookStoresWebAPI.Models;
using Microsoft.AspNetCore.Authorization;

namespace BookStoresWebAPI.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {

        // GET: api/Authors
        [HttpGet("GetAuthors")]
        public async Task<ActionResult<IEnumerable<Author>>> GetAuthors()
        {
            return NoContent();   
        }

        [HttpGet("GetAuthorsCount")]
        public async Task<ActionResult<ItemCount>> GetAuthorsCount()
        {
            return NoContent();
        }
        
        // GET: api/Authors
        [HttpGet("GetAuthorsByPage")]
        public async Task<ActionResult<IEnumerable<Author>>> GetAuthorsByPage(int pageSize, int pageNumber)
        {
            return NoContent();
        }

        // GET: api/Authors/5
        [HttpGet("GetAuthor/{id}")]
        public async Task<ActionResult<Author>> GetAuthor(int id)
        {
            return NoContent();
        }

        // PUT: api/Authors/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("UpdateAuthor/{id}")]
        public async Task<IActionResult> PutAuthor(int id, Author author)
        {
            return NoContent();
        }

        // POST: api/Authors
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost("CreateAuthor")]
        public async Task<ActionResult<Author>> PostAuthor(Author author)
        {
            return NoContent();
        }

        // DELETE: api/Authors/5
        [HttpDelete("DeleteAuthor/{id}")]
        public async Task<ActionResult<Author>> DeleteAuthor(int id)
        {
            return NoContent();
        }

        private bool AuthorExists(int id)
        {
            return false;
        }
    }
}
