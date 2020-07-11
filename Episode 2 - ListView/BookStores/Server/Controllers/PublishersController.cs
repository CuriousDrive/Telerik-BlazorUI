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
        public ActionResult<IEnumerable<Publisher>> GetPublishers()
        {
            List<Publisher> publisherList = _bookStoresRepository.GetPublishers();
            return publisherList;
        }

        // GET: api/Publishers/5
        [HttpGet("GetPublisher/{id}")]
        
        public ActionResult<Publisher> GetPublisher(int id)
        {
            return _bookStoresRepository.GetPublisher(id);
        }

        // PUT: api/Publishers/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("UpdatePublisher/{id}")]
        public IActionResult UpdatePublisher(int id, Publisher publisher)
        {
            _bookStoresRepository.UpdatePublisher(id, publisher);
            return NoContent();
        }

        // POST: api/Publishers
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost("CreatePublisher")]
        public ActionResult<Publisher> CreatePublisher(Publisher publisher)
        {
            _bookStoresRepository.CreatePublisher(publisher);            
            return NoContent();
        }

        // DELETE: api/Publishers/5
        [HttpDelete("DeletePublisher/{id}")]
        public ActionResult<Publisher> DeletePublisher(int id)
        {
            _bookStoresRepository.DeletePublisher(id);
            return NoContent();
        }

        private bool PublisherExists(int id)
        {
            return false;
        }
    }
}
