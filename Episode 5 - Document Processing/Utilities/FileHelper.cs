using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentProcessing.Utilities
{
    public class FileHelper
    {
        public int ID { get; set; }
        public int CompressedSize { get; set; }
        public int UncompressedSize { get; set; }
        public string FileNameInZip { get; set; }
        public string IconPath { get; set; }
        public byte[] Data { get; set; }
    }
}
