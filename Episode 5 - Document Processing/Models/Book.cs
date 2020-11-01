using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentProcessing.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
        public int Sales { get; set; }
        public DateTime PublishedDate { get; set; }
    }
}
