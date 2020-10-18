using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStores.Models
{
    public class Author
    {   
        public int AuthorId { get; set; }
        public string FirstName { get; set; }        
        public string LastName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string EmailAddress { get; set; }        
        public string Phone { get; set; }
        public decimal Salary { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int BooksCount { get; set; }

        public Author()
        {

        }
        public Author(int authorId, string firstName, string lastName, string emailAddress,int salary,
                    string phoneNumber, string city)
        {
            AuthorId = authorId;
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            EmailAddress = emailAddress;
            Phone = phoneNumber;
            City = city;
        }

        public void clear()
        {
            AuthorId = 0;
            FirstName = "";
            LastName = "";
            Salary = 0;
            EmailAddress = "";
            Phone = "";
            City = "";
        }
    }
}
