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
    public class PublishersController : ControllerBase
    {
        // GET: api/Publishers
        [HttpGet("GetPublishers")]
        public async Task<ActionResult<IEnumerable<Publisher>>> GetPublishers()
        {
            return NoContent();
        }

        // GET: api/Publishers/5
        [HttpGet("GetPublisher/{id}")]
        
        public async Task<ActionResult<Publisher>> GetPublisher(int id)
        {
            return NoContent();
        }

        // GET: api/Publishers/5
        [HttpGet("GetPublisherDetails/{PublisherId}")]
        public async Task<ActionResult<Publisher>> GetPublisherDetails(string PublisherId)
        {
            return NoContent();
        }

        // GET: api/Publishers/5
        [HttpPost("PostPublisherDetails/")]
        public async Task<ActionResult<Publisher>> PostPublisherDetails()
        {
            return NoContent();
        }
                

        // PUT: api/Publishers/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("UpdatePublisher/{id}")]
        public async Task<IActionResult> PutPublisher(int id, Publisher publisher)
        {
            return NoContent();
        }

        // POST: api/Publishers
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost("CreatePublisher")]
        public async Task<ActionResult<Publisher>> PostPublisher(Publisher publisher)
        {
            return NoContent();
        }

        // DELETE: api/Publishers/5
        [HttpDelete("DeletePublisher/{id}")]
        public async Task<ActionResult<Publisher>> DeletePublisher(int id)
        {
            return NoContent();
        }

        private bool PublisherExists(int id)
        {
            return false;
        }
    }
}
