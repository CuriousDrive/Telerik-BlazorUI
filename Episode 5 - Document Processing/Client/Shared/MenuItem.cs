using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStores.Client.Shared
{
    public class MenuItem
    {
        public string Text { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }
        public string ImageUrl { get; set; }
        public string Group { get; set; }
        public bool IsSeparator { get; set; }
    }
}
