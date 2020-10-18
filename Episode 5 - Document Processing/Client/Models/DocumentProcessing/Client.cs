namespace BookStores.Client.Models.DocumentProcessing
{
    public class Client
    {
        public Client(string name, string company)
        {
            this.Name = name;
            this.Company = company;
        }

        public string Name { get; private set; }

        public string Company { get; private set; }
    }
}
