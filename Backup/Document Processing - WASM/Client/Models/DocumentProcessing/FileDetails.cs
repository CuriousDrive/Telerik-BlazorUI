using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStores.Client.Models.DocumentProcessing
{
    public class FileDetails
    {
        public string Name { get; set; } = string.Empty;
        public byte[] Data { get; set; }
    }
}
