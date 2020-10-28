using BookStoresWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Telerik.Blazor.Components;

namespace BookStores.Server.Repositories
{
    public class BookStoresRepository
    {
        public List<Author> AuthorList = new List<Author>();
        public List<Book> BookList = new List<Book>();
        public List<Publisher> PublisherList = new List<Publisher>();

        public BookStoresRepository()
        {
            LoadAuthorList();
            LoadBookList();
            LoadPublishers();
        }

        //Loading Data
        private void LoadAuthorList()
        {
            AuthorList.Add(new Author { AuthorId = 1, LastName = "Stringer", FirstName = "Dirk", Phone = "415 843-2991", Address = "301 Putnam", City = "Oakland", State = "CA", Zip = "95688", EmailAddress = "dirk.stringer@gmail.com", Salary = 9999.99M, BooksCount = 10, DateOfBirth= new DateTime(1988,12,08) });
            AuthorList.Add(new Author { AuthorId = 2, LastName = "McBadden", FirstName = "Heather", Phone = "707 448-4982", Address = "301 Putnam", City = "Vacaville", State = "CA", Zip = "95688", EmailAddress = "heather.mcbadden@gmail.com", Salary = 7000.00M, BooksCount = 8, DateOfBirth = new DateTime(1978, 11, 01) });
            AuthorList.Add(new Author { AuthorId = 3, LastName = "del Castillo", FirstName = "Innes", Phone = "615 996-8275", Address = "2286 Cram Pl. #86", City = "Ann Arbor", State = "MI", Zip = "48105", EmailAddress = "innes.del castillo@gmail.com", Salary = 110000M, BooksCount = 22, DateOfBirth = new DateTime(1984, 02, 18) });
            AuthorList.Add(new Author { AuthorId = 4, LastName = "White", FirstName = "Johnson", Phone = "408 496-7223", Address = "10932 Bigge Rd.", City = "Menlo Park", State = "CA", Zip = "94025", EmailAddress = "johnson.white@gmail.com", Salary = 99999.99M, BooksCount = 9, DateOfBirth = new DateTime(1990, 12, 08) });
            AuthorList.Add(new Author { AuthorId = 5, LastName = "Karsen", FirstName = "Livia", Phone = "415 534-9219", Address = "5720 McAuley St.", City = "Oakland", State = "CA", Zip = "94609", EmailAddress = "livia.karsen@gmail.com", Salary = 8888.99M, BooksCount = 1, DateOfBirth = new DateTime(1980, 04, 01) });
            AuthorList.Add(new Author { AuthorId = 6, LastName = "Green", FirstName = "Marjorie", Phone = "415 986-7020", Address = "309 63rd St. #411", City = "Oakland", State = "CA", Zip = "94618", EmailAddress = "marjorie.green@gmail.com", Salary = 19999.99M, BooksCount = 3, DateOfBirth = new DateTime(1991, 11, 11) });
            AuthorList.Add(new Author { AuthorId = 7, LastName = "Smith", FirstName = "Meander", Phone = "913 843-0462", Address = "22 Cleveland Av. #14", City = "Lawrence", State = "KS", Zip = "66044", EmailAddress = "meander.smith@gmail.com", Salary = 9999.99M, BooksCount = 4, DateOfBirth = new DateTime(1952, 05, 09) });
            AuthorList.Add(new Author { AuthorId = 8, LastName = "OLeary", FirstName = "Michael", Phone = "408 286-2428", Address = "3 Balding Pl.", City = "San Jose", State = "CA", Zip = "95128", EmailAddress = "michael.oleary@gmail.com", Salary = 2222.22M, BooksCount = 17, DateOfBirth = new DateTime(1966, 1, 21) });
            AuthorList.Add(new Author { AuthorId = 9, LastName = "DeFrance", FirstName = "Michel", Phone = "219 547-9982", Address = "22 Graybar House Rd.", City = "Gary", State = "IN", Zip = "46403", EmailAddress = "michel.defrance@gmail.com", Salary = 7575.45M, BooksCount = 6, DateOfBirth = new DateTime(1979, 03, 05) });
            AuthorList.Add(new Author { AuthorId = 10, LastName = "Greene", FirstName = "Morningstar", Phone = "615 297-2723", Address = "3 Silver Ct.", City = "Nashville", State = "TN", Zip = "37215", EmailAddress = "morningstar.greene@gmail.com", Salary = 1111.22M, BooksCount = 9, DateOfBirth = new DateTime(1977, 04, 11) });
            AuthorList.Add(new Author { AuthorId = 11, LastName = "Yokomoto", FirstName = "Akiko", Phone = "415 935-4228", Address = "55 Hillsdale Bl.", City = "Walnut Creek", State = "CA", Zip = "94595", EmailAddress = "akiko.yokomoto@gmail.com", Salary = 45623.23M, BooksCount = 10, DateOfBirth = new DateTime(1981, 06, 12) });
            AuthorList.Add(new Author { AuthorId = 12, LastName = "Blotchet", FirstName = "Reginald", Phone = "503 745-6402", Address = "3410 Blonde St.", City = "Corvallis", State = "OR", Zip = "97330", EmailAddress = "reginald.blotchet@gmail.com", Salary = 9999.99M, BooksCount = 8, DateOfBirth = new DateTime(1983, 09, 15) });
            AuthorList.Add(new Author { AuthorId = 13, LastName = "Hunter", FirstName = "Sheryl", Phone = "415 836-7128", Address = "44 Upland Hts.", City = "Palo Alto", State = "CA", Zip = "94301", EmailAddress = "sheryl.hunter@gmail.com", Salary = 23423.11M, BooksCount = 9, DateOfBirth = new DateTime(1986, 12, 18) });
            AuthorList.Add(new Author { AuthorId = 14, LastName = "MacFeather", FirstName = "Stearns", Phone = "415 354-7128", Address = "1956 Arlington Pl.", City = "Oakland", State = "CA", Zip = "94612", EmailAddress = "stearns.macfeather@gmail.com", Salary = 1122.90M, BooksCount = 2, DateOfBirth = new DateTime(1989, 03, 21) });
            AuthorList.Add(new Author { AuthorId = 15, LastName = "Panteley", FirstName = "Sylvia", Phone = "301 946-8853", Address = "67 Seventh Av.", City = "Rockville", State = "MD", Zip = "20853", EmailAddress = "sylvia.panteley@gmail.com", Salary = 8888M, BooksCount = 1, DateOfBirth = new DateTime(1992, 06, 24) });
            AuthorList.Add(new Author { AuthorId = 16, LastName = "Ringer", FirstName = "Albert", Phone = "801 826-0752", Address = "3410 Blonde St.", City = "Salt Lake City", State = "UT", Zip = "84152", EmailAddress = "albert.ringer@gmail.com", Salary = 3333.33M, BooksCount = 1, DateOfBirth = new DateTime(1971, 09, 27) });
            AuthorList.Add(new Author { AuthorId = 17, LastName = "Dull", FirstName = "Ann", Phone = "415 836-7128", Address = "67 Seventh Av.", City = "Palo Alto", State = "CA", Zip = "94301", EmailAddress = "ann.dull@gmail.com", Salary = 5555.55M, BooksCount = 2, DateOfBirth = new DateTime(1974, 12, 30) });
            AuthorList.Add(new Author { AuthorId = 18, LastName = "Ringer", FirstName = "Anne", Phone = "801 826-0752", Address = "PO Box 792", City = "Salt Lake City", State = "UT", Zip = "84152", EmailAddress = "anne.ringer@gmail.com", Salary = 8237.65M, BooksCount = 5, DateOfBirth = new DateTime(1977, 2, 03) });
            AuthorList.Add(new Author { AuthorId = 19, LastName = "Gringlesby", FirstName = "Burt", Phone = "707 938-6445", Address = "PO Box 792.", City = "Covelo", State = "CA", Zip = "95428", EmailAddress = "burt.gringlesby@gmail.com", Salary = 4375.94M, BooksCount = 6, DateOfBirth = new DateTime(1980, 5, 05) });
            AuthorList.Add(new Author { AuthorId = 20, LastName = "Green", FirstName = "Marjorie", Phone = "415 986-7020", Address = "309 63rd St. #411", City = "Oakland", State = "CA", Zip = "94618", EmailAddress = "marjorie.green@gmail.com", Salary = 19999.99M, BooksCount = 3, DateOfBirth = new DateTime(1983, 8, 09) });
        }
        private void LoadBookList()
        {
            BookList.Add(new Book { BookId = 1, Title = "The Godfather", AuthorName = "Mario Puzo", Type = "Crime novel", Price = 29, Sales = 9988, PublishedDate = DateTime.Now });
            BookList.Add(new Book { BookId = 2, Title = "Harry Potter and the Sorcerer's Stone", AuthorName = "J.K. Rowling", Type = "Fantasy Fiction", Price = 49, Sales = 8949534, PublishedDate = DateTime.Now });
            BookList.Add(new Book { BookId = 3, Title = "Fight club", AuthorName = "Chuck Palahniuk", Type = "Novel", Price = 35, Sales = 75234, PublishedDate = DateTime.Now });
            BookList.Add(new Book { BookId = 4, Title = "The Lord of the Rings. Part 1", AuthorName = "J. R. R. Tolkien", Type = "Adventure fiction", Price = 21, Sales = 897034, PublishedDate = DateTime.Now });
            BookList.Add(new Book { BookId = 5, Title = "Clean Architecture", AuthorName = "Robert Cecil Martin", Type = "Fiction", Price = 30, Sales = 100000, PublishedDate = DateTime.Now });
            BookList.Add(new Book { BookId = 6, Title = "The Sicilian", AuthorName = "Mario Puzo", Type = "Crime novel", Price = 29, Sales = 9988, PublishedDate = DateTime.Now });
            BookList.Add(new Book { BookId = 7, Title = "Harry Potter and the Deathly Hallows", AuthorName = "J.K. Rowling", Type = "Fantasy Fiction", Price = 49, Sales = 824923, PublishedDate = DateTime.Now });
            BookList.Add(new Book { BookId = 8, Title = "Haunted", AuthorName = "Chuck Palahniuk", Type = "Novel", Price = 35, Sales = 75234, PublishedDate = DateTime.Now });            
            BookList.Add(new Book { BookId = 9, Title = "The Hobbit", AuthorName = "J. R. R. Tolkien", Type = "Adventure fiction", Price = 21, Sales = 897034, PublishedDate = DateTime.Now });
            BookList.Add(new Book { BookId = 10, Title = "Clean Code", AuthorName = "Robert Cecil Martin", Type = "Fiction", Price = 30, Sales = 100000, PublishedDate = DateTime.Now });
            BookList.Add(new Book { BookId = 11, Title = "The Last Don", AuthorName = "Mario Puzo", Type = "Crime novel", Price = 29, Sales = 9988, PublishedDate = DateTime.Now });
            BookList.Add(new Book { BookId = 12, Title = "Harry Potter and the Chamber of Secrets", AuthorName = "J.K. Rowling", Type = "Fantasy Fiction", Price = 49, Sales = 234234, PublishedDate = DateTime.Now });
            BookList.Add(new Book { BookId = 13, Title = "Survivor", AuthorName = "Chuck Palahniuk", Type = "Novel", Price = 35, Sales = 34535, PublishedDate = DateTime.Now });
            BookList.Add(new Book { BookId = 14, Title = "Unfinished Tales", AuthorName = "J. R. R. Tolkien", Type = "Adventure fiction", Price = 21, Sales = 897034, PublishedDate = DateTime.Now });
            BookList.Add(new Book { BookId = 15, Title = "Clean Agile: Back to Basics", AuthorName = "Robert Cecil Martin", Type = "Fiction", Price = 30, Sales = 100000, PublishedDate = DateTime.Now });
            BookList.Add(new Book { BookId = 16, Title = "The Family", AuthorName = "Robert Cecil Martin", Type = "Fiction", Price = 30, Sales = 100000, PublishedDate = DateTime.Now });
            BookList.Add(new Book { BookId = 17, Title = "Harry Potter and the Prisoner of Azkaban", AuthorName = "J.K. Rowling", Type = "Fantasy Fiction", Price = 39, Sales = 332141, PublishedDate = DateTime.Now });
            BookList.Add(new Book { BookId = 18, Title = "The Two Towers", AuthorName = "J. R. R. Tolkien", Type = "Adventure fiction", Price = 21, Sales = 897034, PublishedDate = DateTime.Now });
            BookList.Add(new Book { BookId = 19, Title = "To Kill a Mockingbird", AuthorName = "Harper Lee", Type = "Novel", Price = 9.99M, Sales = 11123, PublishedDate = DateTime.Now });
            BookList.Add(new Book { BookId = 20, Title = "The Great Gatsby", AuthorName = "F. Scott Fitzgerald", Type = "Tragedy", Price = 11.22M, Sales = 23427, PublishedDate = DateTime.Now });
            BookList.Add(new Book { BookId = 21, Title = "One Hundred Years of Solitude", AuthorName = "Gabriel García Márquez", Type = "Novel", Price = 8.99M, Sales = 5323422, PublishedDate = DateTime.Now });
            BookList.Add(new Book { BookId = 22, Title = "A Passage to India", AuthorName = "E. M. Forster", Type = "Novel", Price = 6.77M, Sales = 273648, PublishedDate = DateTime.Now });
            BookList.Add(new Book { BookId = 23, Title = "Invisible Man", AuthorName = "Ralph Ellison", Type = "Fiction", Price = 17.56M, Sales = 897034, PublishedDate = DateTime.Now });
            BookList.Add(new Book { BookId = 24, Title = "War and Peace", AuthorName = "Leo Tolstoy", Type = "Novel", Price = 21.32M, Sales = 213123, PublishedDate = DateTime.Now });            
            BookList.Add(new Book { BookId = 25, Title = "Odyssey", AuthorName = "Homer", Type = "Epic", Price = 21, Sales = 634, PublishedDate = DateTime.Now });
            BookList.Add(new Book { BookId = 26, Title = "Catch-22", AuthorName = "Joseph Heller", Type = "Novel", Price = 45.66M, Sales = 44121, PublishedDate = DateTime.Now });
        }
        private void LoadPublishers()
        {
            PublisherList.Add(new Publisher { PubId = 1, PublisherName = "New Moon Books", City = "Boston", State = "MA", Country = "USA" });
            PublisherList.Add(new Publisher { PubId = 2, PublisherName = "Binnet & Hardley", City = "Washington", State = "DC", Country = "USA" });
            PublisherList.Add(new Publisher { PubId = 3, PublisherName = "Algodata Infosystems", City = "Berkeley", State = "CA", Country = "USA" });
            PublisherList.Add(new Publisher { PubId = 4, PublisherName = "Five Lakes Publishing", City = "Chicago", State = "IL", Country = "USA" });
            PublisherList.Add(new Publisher { PubId = 5, PublisherName = "Ramona Publishers", City = "Dallas", State = "TX", Country = "USA" });
            PublisherList.Add(new Publisher { PubId = 6, PublisherName = "HarperCollins", City = "Washington", State = "DC", Country = "USA" });
            PublisherList.Add(new Publisher { PubId = 7, PublisherName = "Scootney Books", City = "New York City", State = "NY", Country = "USA" });
            PublisherList.Add(new Publisher { PubId = 8, PublisherName = "Workman Publishing", City = "New York City", State = "NY", Country = "USA" });
            PublisherList.Add(new Publisher { PubId = 9, PublisherName = "Addison-Wesley", City = "Boston", State = "MA", Country = "USA" });
            PublisherList.Add(new Publisher { PubId = 10, PublisherName = "Chronicle Books", City = "Portland", State = "OR", Country = "USA" });
            PublisherList.Add(new Publisher { PubId = 11, PublisherName = "Sourcebooks", City = "Naperville", State = "IL", Country = "USA" });
            PublisherList.Add(new Publisher { PubId = 12, PublisherName = "B&H Publishing", City = "Nashville", State = "TN", Country = "USA" });
            PublisherList.Add(new Publisher { PubId = 13, PublisherName = "W.W. Norton", City = "New York City", State = "NY", Country = "USA" });            
        }


        //Authors
        public List<Author> GetAuthors()
        {
            return this.AuthorList;
        }

        public List<Author> GetAllAuthors()
        {
            if (this.AuthorList.Count == 20)
            {
                for (int i = 0; i < 249; i++)
                {
                    LoadAuthorList();
                }
            }
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

        //Books
        public List<Book> GetBooks()
        {
            return this.BookList;
        }

        public Book GetBook(int id)
        {
            return this.BookList.Where(auth => auth.BookId == id).FirstOrDefault();
        }

        public void UpdateBook(int id, Book Book)
        {
            Book BookToUpdate = this.BookList.Where(auth => auth.BookId == id).First();
            var index = this.BookList.IndexOf(BookToUpdate);

            if (index != -1)
                this.BookList[index] = Book;
        }

        public void CreateBook(Book Book)
        {
            Book.BookId = BookList.Max(auth => auth.BookId) + 1;
            this.BookList.Add(Book);
        }

        public void DeleteBook(int id)
        {
            Book Book = this.BookList.Where(auth => auth.BookId == id).FirstOrDefault();
            this.BookList.Remove(Book);
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

       

    }
}
