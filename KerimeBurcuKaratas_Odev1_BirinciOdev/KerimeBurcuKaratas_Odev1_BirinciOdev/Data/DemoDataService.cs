using KerimeBurcuKaratas_Odev1_BirinciOdev.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KerimeBurcuKaratas_Odev1_BirinciOdev.Data
{
    public class DemoDataService
    {
        private List<Book> books = new List<Book>();
        public DemoDataService()
        {
            books.Add(new Book()
            {
                Id = 1,
                BookName = "Harry Potter",
                BookSeriallNumber = "9781408855652",
                BookGenre = "Fantasy",
                BookAuthor = "J.K. Rowling"
            });
            books.Add(new Book()
            {
                Id = 2,
                BookName = "Lord of The Rings",
                BookSeriallNumber = "9781408855650",
                BookGenre = "Fantasy",
                BookAuthor = "J.R.R. Tolkien"
            });
            books.Add(new Book()
            {
                Id = 3,
                BookName = "Dune",
                BookSeriallNumber = "9781408855689",
                BookGenre = "Science Fiction",
                BookAuthor = "Frank Herbert"
            });
            books.Add(new Book()
            {
                Id = 4,
                BookName = "I Robot",
                BookSeriallNumber = "9781408855678",
                BookGenre = "Science Fiction",
                BookAuthor = "Isaac Asimov"
            });
            books.Add(new Book()
            {
                Id = 5,
                BookName = "The Raven",
                BookSeriallNumber = "9781408855569",
                BookGenre = "Drama",
                BookAuthor = "Edgar Allan Poe"
            });
            books.Add(new Book()
            {
                Id = 6,
                BookName = "Yeni Hayat",
                BookSeriallNumber = "9781408855612",
                BookGenre = "Drama",
                BookAuthor = "Orhan Pamuk"
            });
        }

        public List<Book> GetAll()
        {
            return books;

        }
        public Book GetById(int id)
        {
            return books.FirstOrDefault(x => x.Id == id);

        }

        public Book Add(Book book)
        {
            if (book == null)
            {
                throw new ArgumentNullException("Book is null.");

            }
            var bookId = books.Max(x => x.Id)+1;
            book.Id = bookId;
            books.Add(book);    
            return book;
        }

        public bool UpDate(Book book)
        {
            if (book == null)
            {
                throw new ArgumentNullException("Book is null.");

            }
            var index = books.FindIndex(x => x.Id == book.Id);
            if (index == -1)
            {
                return false;
            }
            books.RemoveAt(index);
            books.Add(book);
            return true;

        }

        public bool Delete(int id)
        {
            var x = books.RemoveAll(x => x.Id == id);
            if (x > 1)
            {
                return true;

            }
            return false;


        }




    }
}
