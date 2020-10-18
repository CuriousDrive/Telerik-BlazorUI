using System;

namespace BookStores.Client.Models.DocumentProcessing
{
    public class DocumentRow
    {
        public DocumentRow(int id, DateTime date, DateTime time, Client client, double discount, Shipping shipping)
        {
            this.Id = id;
            this.Date = date;
            this.Time = time;
            this.Client = client.Name;
            this.Company = client.Company;
            this.Discount = discount;
            this.Shipping = shipping;
        }

        public int Id { get; private set; }

        public DateTime Date { get; private set; }

        public DateTime Time { get; private set; }

        public string Client { get; private set; }

        public string Company { get; private set; }

        public double Discount { get; private set; }

        public Shipping Shipping { get; private set; }
    }
}
