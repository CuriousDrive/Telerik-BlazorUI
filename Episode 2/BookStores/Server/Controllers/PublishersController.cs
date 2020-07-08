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
    //[Authorize]
    [Route("[controller]")]
    [ApiController]
    public class PublishersController : ControllerBase
    {

        private BookStoresRepository _bookStoresRepository;

        public PublishersController(BookStoresRepository bookStoresRepository)
        {
            _bookStoresRepository = bookStoresRepository;
        }

        // GET: api/Publishers
        [HttpGet("GetPublishers")]
        public async Task<ActionResult<IEnumerable<Publisher>>> GetPublishers()
        {
            List<Publisher> publisherList = _bookStoresRepository.PublisherList;
            return await Task.FromResult(publisherList);
        }

        // GET: api/Publishers/5
        [HttpGet("GetPublisher/{id}")]
        
        public async Task<ActionResult<Publisher>> GetPublisher(int id)
        {
            return NoContent();
        }

        // PUT: api/Publishers/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("UpdatePublisher/{id}")]
        public async Task<IActionResult> PutPublisher(int id, Publisher publisher)
        {
            Publisher publisher2 = _bookStoresRepository.PublisherList.Where(pub => pub.PubId == id).First();
            var index = _bookStoresRepository.PublisherList.IndexOf(publisher2);

            if (index != -1)
                _bookStoresRepository.PublisherList[index] = publisher;

            return NoContent();
        }

        // POST: api/Publishers
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost("CreatePublisher")]
        public async Task<ActionResult<Publisher>> PostPublisher(Publisher publisher)
        {
            publisher.PubId = _bookStoresRepository.PublisherList.Max(pub => pub.PubId) + 1;
            _bookStoresRepository.PublisherList.Add(publisher);
            
            return NoContent();
        }

        // DELETE: api/Publishers/5
        [HttpDelete("DeletePublisher/{id}")]
        public async Task<ActionResult<Publisher>> DeletePublisher(int id)
        {
            Publisher publisher = _bookStoresRepository.PublisherList.Where(pub => pub.PubId == id).FirstOrDefault();
            _bookStoresRepository.PublisherList.Remove(publisher);
            return NoContent();
        }

        private bool PublisherExists(int id)
        {
            return false;
        }
    }
}
