using System;
using System.Collections.Generic;

namespace BookStoresWebAPI.Models
{
    public partial class Publisher
    {
        public Publisher()
        {
            Books = new HashSet<Book>();            
        }

        public int PubId { get; set; }
        public string PublisherName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
