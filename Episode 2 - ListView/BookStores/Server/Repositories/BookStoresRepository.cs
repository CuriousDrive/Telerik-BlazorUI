using BookStoresWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telerik.Blazor.Components;

namespace BookStores.Server.Repositories
{
    public class BookStoresRepository
    {
        public List<Author> AuthorList = new List<Author>();
        public List<Publisher> PublisherList = new List<Publisher>();

        public BookStoresRepository()
        {
            LoadAuthorList();
            LoadPublishers();
        }

        //Loading Data
        private void LoadAuthorList()
        {
            AuthorList.Add(new Author { AuthorId = 1, LastName = "Stringer", FirstName = "Dirk", Phone = "415 843-2991", Address = "301 Putnam", City = "Oakland", State = "CA", Zip = "95688", EmailAddress = "dirk.stringer@gmail.com" });
            AuthorList.Add(new Author { AuthorId = 2, LastName = "McBadden", FirstName = "Heather", Phone = "707 448 - 4982", Address = "301 Putnam", City = "Vacaville", State = "CA", Zip = "95688", EmailAddress = "heather.mcbadden@gmail.com" });
            AuthorList.Add(new Author { AuthorId = 3, LastName = "del Castillo", FirstName = "Innes", Phone = "615 996-8275", Address = "2286 Cram Pl. #86", City = "Ann Arbor", State = "MI", Zip = "48105", EmailAddress = "innes.del castillo@gmail.com" });
            AuthorList.Add(new Author { AuthorId = 4, LastName = "White", FirstName = "Johnson", Phone = "408 496-7223", Address = "10932 Bigge Rd.", City = "Menlo Park", State = "CA", Zip = "94025", EmailAddress = "johnson.white@gmail.com" });
            AuthorList.Add(new Author { AuthorId = 5, LastName = "Karsen", FirstName = "Livia", Phone = "415 534-9219", Address = "5720 McAuley St.", City = "Oakland", State = "CA", Zip = "94609", EmailAddress = "livia.karsen@gmail.com" });
            AuthorList.Add(new Author { AuthorId = 6, LastName = "Green", FirstName = "Marjorie", Phone = "415 986-7020", Address = "309 63rd St. #411", City = "Oakland", State = "CA", Zip = "94618", EmailAddress = "marjorie.green@gmail.com" });
            AuthorList.Add(new Author { AuthorId = 7, LastName = "Smith", FirstName = "Meander", Phone = "913 843-0462", Address = "22 Cleveland Av. #14", City = "Lawrence", State = "KS", Zip = "66044", EmailAddress = "meander.smith@gmail.com" });
            AuthorList.Add(new Author { AuthorId = 8, LastName = "OLeary", FirstName = "Michael", Phone = "408 286-2428", Address = "3 Balding Pl.", City = "San Jose", State = "CA", Zip = "95128", EmailAddress = "michael.oleary@gmail.com" });
            AuthorList.Add(new Author { AuthorId = 9, LastName = "DeFrance", FirstName = "Michel", Phone = "219 547 - 9982", Address = "22 Graybar House Rd.", City = "Gary", State = "IN", Zip = "46403", EmailAddress = "michel.defrance@gmail.com" });
            AuthorList.Add(new Author { AuthorId = 10, LastName = "Greene", FirstName = "Morningstar", Phone = "615 297-2723", Address = "3 Silver Ct.", City = "Nashville", State = "TN", Zip = "37215", EmailAddress = "morningstar.greene@gmail.com" });
            AuthorList.Add(new Author { AuthorId = 11, LastName = "Yokomoto", FirstName = "Akiko", Phone = "415 935-4228", Address = "55 Hillsdale Bl.", City = "Walnut Creek", State = "CA", Zip = "94595", EmailAddress = "akiko.yokomoto@gmail.com" });
            AuthorList.Add(new Author { AuthorId = 12, LastName = "Blotchet-Halls", FirstName = "Reginald", Phone = "503 745-6402", Address = "3410 Blonde St.", City = "Corvallis", State = "OR", Zip = "97330", EmailAddress = "reginald.blotchet-halls@gmail.com" });
            AuthorList.Add(new Author { AuthorId = 13, LastName = "Hunter", FirstName = "Sheryl", Phone = "415 836-7128", Address = "44 Upland Hts.", City = "Palo Alto", State = "CA", Zip = "94301", EmailAddress = "sheryl.hunter@gmail.com" });
            AuthorList.Add(new Author { AuthorId = 14, LastName = "MacFeather", FirstName = "Stearns", Phone = "415 354-7128", Address = "1956 Arlington Pl.", City = "Oakland", State = "CA", Zip = "94612", EmailAddress = "stearns.macfeather@gmail.com" });
            AuthorList.Add(new Author { AuthorId = 15, LastName = "Panteley", FirstName = "Sylvia", Phone = "301 946 - 8853", Address = "67 Seventh Av.", City = "Rockville", State = "MD", Zip = "20853", EmailAddress = "sylvia.panteley@gmail.com" });
            AuthorList.Add(new Author { AuthorId = 16, LastName = "Ringer", FirstName = "Albert", Phone = "801 826-0752", Address = "3410 Blonde St.", City = "Salt Lake City", State = "UT", Zip = "84152", EmailAddress = "albert.ringer@gmail.com" });
            AuthorList.Add(new Author { AuthorId = 17, LastName = "Dull", FirstName = "Ann", Phone = "415 836-7128", Address = "67 Seventh Av.", City = "Palo Alto", State = "CA", Zip = "94301", EmailAddress = "ann.dull@gmail.com" });
            AuthorList.Add(new Author { AuthorId = 18, LastName = "Ringer", FirstName = "Anne", Phone = "801 826 - 0752", Address = "PO Box 792", City = "Salt Lake City", State = "UT", Zip = "84152", EmailAddress = "anne.ringer@gmail.com" });
            AuthorList.Add(new Author { AuthorId = 19, LastName = "Gringlesby", FirstName = "Burt", Phone = "707 938-6445", Address = "PO Box 792.", City = "Covelo", State = "CA", Zip = "95428", EmailAddress = "burt.gringlesby@gmail.com" });
        }
        private void LoadPublishers()
        {
            PublisherList.Add(new Publisher { PubId = 1, PublisherName = "New Moon Books", City = "Boston", State = "MA", Country = "USA" });
            PublisherList.Add(new Publisher { PubId = 2, PublisherName = "Binnet & Hardley", City = "Washington", State = "DC", Country = "USA" });
            PublisherList.Add(new Publisher { PubId = 3, PublisherName = "Algodata Infosystems", City = "Berkeley", State = "CA", Country = "USA" });
            PublisherList.Add(new Publisher { PubId = 4, PublisherName = "Five Lakes Publishing", City = "Chicago", State = "IL", Country = "USA" });
            PublisherList.Add(new Publisher { PubId = 5, PublisherName = "Ramona Publishers", City = "Dallas", State = "TX", Country = "USA" });
            PublisherList.Add(new Publisher { PubId = 6, PublisherName = "HarperCollins", City = "Washington", State = "DC", Country = "USA" });
            PublisherList.Add(new Publisher { PubId = 7, PublisherName = "Scootney Books", City = "New York", State = "NY", Country = "USA" });
            PublisherList.Add(new Publisher { PubId = 8, PublisherName = "Workman Publishing", City = "New York", State = "NY", Country = "USA" });
            PublisherList.Add(new Publisher { PubId = 9, PublisherName = "Addison-Wesley", City = "Boston", State = "MA", Country = "USA" });
            PublisherList.Add(new Publisher { PubId = 10, PublisherName = "Chronicle Books", City = "Portland", State = "OR", Country = "USA" });
            PublisherList.Add(new Publisher { PubId = 11, PublisherName = "Sourcebooks", City = "Naperville", State = "IL", Country = "USA" });
            PublisherList.Add(new Publisher { PubId = 12, PublisherName = "B&H Publishing", City = "Nashville", State = "TN", Country = "USA" });
            PublisherList.Add(new Publisher { PubId = 13, PublisherName = "W.W. Norton", City = "New York", State = "NY", Country = "USA" });            
        }

        //Publishers
        public List<Publisher> GetPublishers()
        {
            return this.PublisherList;
        }

        public Publisher GetPublisher(int id)
        {
            return this.PublisherList.Where(pub => pub.PubId == id).FirstOrDefault();
        }

        public void UpdatePublisher(int id, Publisher publisher)
        {
            Publisher publisherToUpdate = this.PublisherList.Where(pub => pub.PubId == id).First();
            var index = this.PublisherList.IndexOf(publisherToUpdate);

            if (index != -1)
                this.PublisherList[index] = publisher;
        }

        public void CreatePublisher(Publisher publisher)
        {
            publisher.PubId = PublisherList.Max(pub => pub.PubId) + 1;
            this.PublisherList.Add(publisher);
        }

        public void DeletePublisher(int id)
        {
            Publisher publisher = this.PublisherList.Where(pub => pub.PubId == id).FirstOrDefault();
            this.PublisherList.Remove(publisher);
        }

        //Authors
        public List<Author> GetAuthors()
        {
            return this.AuthorList;
        }

        public Author GetAuthor(int id)
        {
            return this.AuthorList.Where(auth => auth.AuthorId == id).FirstOrDefault();
        }

        public void UpdateAuthor(int id, Author author)
        {
            Author AuthorToUpdate = this.AuthorList.Where(auth => auth.AuthorId == id).First();
            var index = this.AuthorList.IndexOf(AuthorToUpdate);

            if (index != -1)
                this.AuthorList[index] = author;
        }

        public void CreateAuthor(Author author)
        {
            author.AuthorId = AuthorList.Max(auth => auth.AuthorId) + 1;
            this.AuthorList.Add(author);
        }

        public void DeleteAuthor(int id)
        {
            Author Author = this.AuthorList.Where(auth => auth.AuthorId == id).FirstOrDefault();
            this.AuthorList.Remove(Author);
        }

    }
}
