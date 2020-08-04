using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStores.Models
{
    public class Subscription
    {
        public int Id { get; set; }
        public string SubscriptionName { get; set; }
        public bool Selected { get; set; }
    }
}
